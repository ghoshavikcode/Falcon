using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;
using System.IO;
using Newtonsoft.Json;

namespace ComReadWrite
{
    public partial class Main : Form
    {
        #region common
        public Login login;
        private static string DBFilePath = string.Empty;
        static SerialPort port;
        private static int IsConnected = 0;
        private static bool IsReadyToSend = false;
        private static int pushedItem = 0;
        private static int progressValue = 0;
        List<string> upload = new List<string>();
        public Main()
        {
            InitializeComponent();
        }
        public OleDbConnection GetConnection()
        {
            OleDbConnection connection = null;
            if (!string.IsNullOrEmpty(DBFilePath))
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBFilePath + ";User Id=Admin;Password=;";
                connection = new OleDbConnection(connectionString);
            }
            return connection;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cmbModbus.SelectedItem) == "Modbus DB File")
            {
                //TabPage tabPage = tab.SelectedTab;
                //if (tabPage.Name == "tabModbusReg")
                //{
                SaveModBusRegConfig();
                //}
                //else if (tabPage.Name == "tabModBusCfg")
                //{
                SaveModBusCfg();
                //}
                MessageBox.Show("Configuration Saved Successfully", "Information");
            }
            else if (Convert.ToString(cmbModbus.SelectedItem) == "CFG File")
            {
                SaveAllTab();
            }
            else
            {
                MessageBox.Show("Please select save location from top panel first", "Information");
            }

        }
        private void SaveAllTab()
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Config\\config.cfg", false);
            sw.WriteLine(GetIPSettSaveString());
            sw.WriteLine(GetConnectionSaveString());
            sw.WriteLine(GetDeviceSaveString());
            sw.WriteLine(GetMQTTSaveString());
            sw.Close();
            MessageBox.Show("All the configuration saved", "Information");
        }
        private void Main_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            login.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbComPorts.DataSource = SerialPort.GetPortNames();
            this.FormClosed += Main_FormClosed;
            populateIPSettDropdown();
            //Enable Event Handler
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //int intBuffer;
            //intBuffer = port.BytesToRead;
            //byte[] byteBuffer = new byte[intBuffer];
            //port.Read(byteBuffer, 0, intBuffer);
            this.Invoke(new EventHandler(DoUpDate));
        }
        private void DoUpDate(object s, EventArgs e)
        {
            string incomingDetails = port.ReadExisting();
            if (incomingDetails.ToUpper() == "RECEIVED")
            {
                //sIsReadyToSend = true;
                uploadSettings();
            }
            else if (incomingDetails.ToUpper() == "FINISHED")
            {
                IsReadyToSend = false;
                //timerUploadDownload.Enabled = false;
            }
            else if (incomingDetails.ToUpper().Contains("IPSETT"))
            {
                setFieldsIpSett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("CONN"))
            {
                setFieldsConn(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("DEVICE"))
            {
                setFieldsDevice(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("MQTT"))
            {
                setFieldsMQTT(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("MODBUSCFG"))
            {
                setFieldsModbusCnf(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("MREG"))
            {
                setModbusRegData(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("STATUS"))
            {
                setFieldStatus(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("MONITOR"))
            {
                setMonitorFields(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("GSMSTATUS"))
            {
                setGSMStatus(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("IOSTATUS"))
            {
                setIOStatus(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("STATUSINFO"))
            {
                setMonitorStatusInfoFields(incomingDetails);
            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.WriteLine("*readdevice#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void Form1_FromClosing(object sender, EventArgs e)
        {
            port.Close();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConnected == 0)
                {
                    port = new SerialPort(cmbComPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                    port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                    // set read time out to 2 seconds
                    // port.ReadTimeout = 2000;
                    // port.WriteTimeout = 500;
                    // open serial port
                    if (!port.IsOpen)
                    {
                        port.Open();
                        btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\greenconnect.jpg");
                        btnConnect.Text = "Connected";
                        IsConnected = 1;
                    }
                }
                else if (IsConnected == 1)
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                        btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\reddisconnect.jpg");
                        btnConnect.Text = "Connect";
                        IsConnected = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            pbProcessing.Value = 0;
            progressValue = 0;
            if (IsConnected == 0)
            {
                MessageBox.Show("No port is connected.", "Warning");
                return;
            }
            upload.Add(getUploadStringForIPSett());
            upload.Add(getUploadStringForConnection());
            upload.Add(getUploadStringForDevice());
            upload.Add(getUploadStringForMQTT());
            upload.Add(getUploadStringForModbusCnf());
            List<string> tmpLst = getUploadStringForModbusReg();
            for (int index = 0; index < tmpLst.Count; index++)
            {
                upload.Add(tmpLst[index]);
            }
            IsReadyToSend = true;
            uploadSettings();
        }
        private void uploadSettings()
        {
            try
            {
                if (IsReadyToSend)
                {
                    if (upload.Count > pushedItem)
                    {
                        if (port.IsOpen)
                        {
                            port.WriteLine(upload[pushedItem]);
                        }
                        progressValue += 100 / upload.Count();
                        pbProcessing.Value = progressValue > 100 ? 100 : progressValue;
                        pushedItem += 1;
                        //IsReadyToSend = false;
                    }
                    else
                    {
                        pbProcessing.Value = 100;
                        pushedItem = 0;
                        IsReadyToSend = false;
                        MessageBox.Show("All the data uploaded successfully.", "Information");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
            }
        }
        private void timerUploadDownload_Tick(object sender, EventArgs e)
        {



        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbModbus.SelectedIndex > -1)
            {
                if (cmbModbus.SelectedItem.ToString() == "CFG File")
                {
                    OpenFileDialog ofg = new OpenFileDialog();
                    ofg.Title = "Select File";
                    ofg.InitialDirectory = Application.StartupPath + "Config\\";
                    ofg.Filter = "*.cfg*|*.CFG*";
                    ofg.FilterIndex = 2;
                    ofg.RestoreDirectory = true;
                    if (ofg.ShowDialog() == DialogResult.OK)
                    {
                        string cfgFileLoc = ofg.FileName;
                        LoadAllDetails(cfgFileLoc);
                    }
                }
                else if (cmbModbus.SelectedItem.ToString() == "Modbus DB File")
                {
                    OpenFileDialog ofg = new OpenFileDialog();
                    ofg.Title = "Select File";
                    ofg.InitialDirectory = Application.StartupPath + "DB\\";
                    ofg.Filter = "*.accdb*|*.ACCDB*";
                    ofg.FilterIndex = 2;
                    ofg.RestoreDirectory = true;
                    if (ofg.ShowDialog() == DialogResult.OK)
                    {
                        DBFilePath = ofg.FileName;
                        LoadModbusReg();
                        LoadModbusCfg();
                        //Config name population
                        DataTable dtModbusRegConfig = GetConfigDetails(string.Empty);
                        if (dtModbusRegConfig.Rows.Count > 0)
                        {
                            txtConfigName.Text = Convert.ToString(dtModbusRegConfig.Rows[0][0]);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select file from top panel.", "Information");
            }

        }
        private void LoadAllDetails(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    StreamReader reader = new StreamReader(filePath);
                    string line = string.Empty;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("Cfg.IPSett"))
                        {
                            string tmpLine = line.Split(":")[1].Trim().Replace("\"", "");
                            Dictionary<string, string> kvp = tmpLine.Substring(0, tmpLine.Length - 1).Split(',')
                                                                 .Select(value => value.Split('='))
                                                                 .ToDictionary(pair => pair[0], pair => pair[1]);
                            loadIPSettDetails(kvp);
                        }
                        else if (line.Contains("Cfg.Connection"))
                        {
                            string tmpLine = line.Split(":")[1].Trim().Replace("\"", "");
                            Dictionary<string, string> kvp = tmpLine.Substring(0, tmpLine.Length - 1).Split(',')
                                                                 .Select(value => value.Split('='))
                                                                 .ToDictionary(pair => pair[0], pair => pair[1]);
                            loadConnDetails(kvp);
                        }
                        else if (line.Contains("Cfg.Device"))
                        {
                            string tmpLine = line.Split(":")[1].Trim().Replace("\"", "");
                            Dictionary<string, string> kvp = tmpLine.Substring(0, tmpLine.Length - 1).Split(',')
                                                                 .Select(value => value.Split('='))
                                                                 .ToDictionary(pair => pair[0], pair => pair[1]);
                            loadDeviceDetails(kvp);
                        }
                        else if (line.Contains("Cfg.MQTT"))
                        {
                            string tmpLine = line.Split(":")[1].Trim().Replace("\"", "");
                            Dictionary<string, string> kvp = tmpLine.Substring(0, tmpLine.Length - 1).Split(',')
                                                                 .Select(value => value.Split('='))
                                                                 .ToDictionary(pair => pair[0], pair => pair[1]);
                            loadMQTTDetails(kvp);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error");
            }
        }
        #endregion
        #region Modbus
        private void setModbusRegData(string details)
        {
            try
            {
                ModbusRegArray mreg = JsonConvert.DeserializeObject<ModbusRegArray>(details);
                if (mreg.MREG.Length > 0)
                {
                    for (int i = 0; i < mreg.MREG.Length; i++)
                    {
                        AddEditModbusRegWithBlock(mreg.MREG[i]);
                    }
                }
                MessageBox.Show("Modbus data loaded.", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
            }
        }
        private List<string> getUploadStringForModbusReg()
        {

            List<string> lstModbus = new List<string>();
            try
            {
                string strSQL = "SELECT * FROM ModbusReg";
                // Create a connection    
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                DataTable dtModbusRegLoad = new DataTable();
                DataTable dtModbusRegBlock = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusRegLoad);
                    connection.Close();
                }
                if (dtModbusRegLoad.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int index = 0; index < dtModbusRegLoad.Rows.Count; index++)
                    {
                        lstModbus.Add(getModbusRegParentString(index, dtModbusRegLoad));
                        strSQL = "SELECT SLNo,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor FROM ModbusRegBlockConfig c where c.BlockID=" + Convert.ToString(dtModbusRegLoad.Rows[index]["BlockID"]);
                        command = new OleDbCommand(strSQL, connection);
                        dtModbusRegBlock = new DataTable();
                        // Execute command    
                        using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                        {
                            connection.Open();
                            da.Fill(dtModbusRegBlock);
                            connection.Close();
                        }
                        if (dtModbusRegBlock.Rows.Count > 0)
                        {
                            for (int blockIndex = 0; blockIndex < dtModbusRegBlock.Rows.Count; blockIndex++)
                            {
                                lstModbus.Add(getModbusRegChildString(blockIndex, dtModbusRegBlock));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return lstModbus;

        }
        private void setFieldsModbusCnf(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                cmbPort.SelectedItem = fields[1];
                cmbBaudRate.SelectedItem = fields[2];
                cmbConnectionType.SelectedItem = fields[3];
                txtReplyTimeOut.Text = fields[4];
                txtInterPollDelay.Text = fields[5];
                cmbRetryCount.SelectedItem = fields[6];
                txtInterCharDelay.Text = fields[7];
                cmbMode.SelectedItem = fields[8];
                cmbDataFormat.SelectedItem = fields[9];
                cmbLogEvent.SelectedItem = fields[10];
                txtPollInterval.Text = fields[11];
                cmbOnBoardIOEvent.SelectedItem = fields[12];
                txtLogInterval1.Text = fields[13];
                if (!string.IsNullOrEmpty(DBFilePath))
                    SaveModBusCfg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private string getModbusRegParentString(int index, DataTable dtModbusReg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*MODP,");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["BlockID"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["BlockID"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["SlaveID"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["SlaveID"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["FunCode"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["FunCode"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["StartAddress"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["StartAddress"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["WordCount"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["WordCount"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["PollDelay"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["PollDelay"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["GroupID"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["GroupID"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["Comport"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["Comport"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["IP"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["IP"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["Port"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["Port"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusReg.Rows[index]["DevID"])))
                sb.Append(Convert.ToString(dtModbusReg.Rows[index]["DevID"]));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private string getModbusRegChildString(int index, DataTable dtModbusRegBlock)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*MODC,");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["SLNo"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["SLNo"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["Address"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["Address"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["FieldName"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["FieldName"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["Endian"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["Endian"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["FieldType"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["FieldType"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["ChangeField"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["ChangeField"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["Words"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["Words"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["Resolution"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["Resolution"]));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(Convert.ToString(dtModbusRegBlock.Rows[index]["ScaleFactor"])))
                sb.Append(Convert.ToString(dtModbusRegBlock.Rows[index]["ScaleFactor"]));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private string getUploadStringForModbusCnf()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*MODBUSCFG,");
            if (cmbPort.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbPort.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbBaudRate.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbBaudRate.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbConnectionType.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbConnectionType.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtReplyTimeOut.Text))
                sb.Append(Convert.ToString(txtReplyTimeOut.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtInterPollDelay.Text))
                sb.Append(Convert.ToString(txtInterPollDelay.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbRetryCount.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbRetryCount.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtInterCharDelay.Text))
                sb.Append(Convert.ToString(txtInterCharDelay.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbMode.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbMode.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbDataFormat.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbDataFormat.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbLogEvent.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbLogEvent.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPollInterval.Text))
                sb.Append(Convert.ToString(txtPollInterval.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbOnBoardIOEvent.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbOnBoardIOEvent.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtLogInterval1.Text))
                sb.Append(Convert.ToString(txtLogInterval1.Text));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private void txtLogInterval1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadModbusReg()
        {
            try
            {
                string strSQL = "SELECT * FROM ModbusReg";
                // Create a connection    
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                DataTable dtModbusReg = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusReg);
                    connection.Close();
                }
                DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
                dgv.DataSource = dtModbusReg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void LoadModbusCfg()
        {
            try
            {
                cmbConnectionType.SelectedIndex = 3;
                cmbPort.SelectedIndex = 0;
                cmbMode.SelectedIndex = 0;
                cmbDataFormat.SelectedIndex = 0;
                cmbLogEvent.SelectedIndex = 0;
                cmbOnBoardIOEvent.SelectedIndex = 0;
                string strSQL = "SELECT * FROM ModbusCfg";
                // Create a connection    
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                DataTable dtModbusCfg = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusCfg);
                    connection.Close();
                }
                if (dtModbusCfg.Rows.Count > 0)
                {
                    cmbPort.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["Port"]);
                    cmbBaudRate.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["BaudRate"]);
                    cmbConnectionType.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["ConnectionType"]);
                    txtReplyTimeOut.Text = Convert.ToString(dtModbusCfg.Rows[0]["ReplyTimeout"]);
                    txtInterPollDelay.Text = Convert.ToString(dtModbusCfg.Rows[0]["InterPollDelay"]);
                    cmbRetryCount.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["RetryCount"]);
                    txtInterCharDelay.Text = Convert.ToString(dtModbusCfg.Rows[0]["InterCharDelay"]);
                    cmbMode.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["Mode"]);
                    cmbDataFormat.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["DataFormatTx"]);
                    cmbLogEvent.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["LogEventTx"]);
                    txtPollInterval.Text = Convert.ToString(dtModbusCfg.Rows[0]["PollInterval"]);
                    cmbOnBoardIOEvent.SelectedItem = Convert.ToString(dtModbusCfg.Rows[0]["OnBoardIO"]);
                    txtLogInterval1.Text = Convert.ToString(dtModbusCfg.Rows[0]["LogInterval"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ModbusRegisterBlock mrg = new ModbusRegisterBlock(0, this);
            mrg.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
                if (dgv.CurrentRow != null)
                {
                    int blockID = Convert.ToInt32(dgv.CurrentRow.Cells["Index"].Value);
                    OleDbConnection connection = GetConnection();
                    if (connection == null)
                        throw new Exception("No database found");
                    StringBuilder sb = new StringBuilder("Delete from ModbusReg where BlockID='");
                    sb.Append(blockID);
                    sb.Append("'");
                    // Create a command and set its connection    
                    OleDbCommand command = new OleDbCommand(sb.ToString(), connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    sb = new StringBuilder("Delete from ModbusRegBlockConfig where BlockID=");
                    sb.Append(blockID);
                    command.CommandText = sb.ToString();
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    dgv.Rows.Remove(dgv.CurrentRow);
                    if (port.IsOpen)
                    {
                        port.WriteLine("*MODP," + blockID + ",0,0,0,0,0,0,0,0,0,0#");
                    }
                }
                else
                    MessageBox.Show("Please select a row first", "Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
            }

        }
        private void btnClone_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
                if (dgv.CurrentRow != null)
                {
                    int blockID = Convert.ToInt32(dgv.CurrentRow.Cells["Index"].Value);

                    string strSQL = "SELECT MAX(BlockID) as BlockID FROM ModbusReg ";
                    // Create a connection    
                    OleDbConnection connection = GetConnection();
                    if (connection == null)
                        throw new Exception("No database found");
                    // Create a command and set its connection    
                    OleDbCommand command = new OleDbCommand(strSQL, connection);
                    DataTable dtBlockId = new DataTable();
                    // Execute command    
                    using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                    {
                        connection.Open();
                        da.Fill(dtBlockId);
                        connection.Close();
                    }
                    int newBlockID = 0;
                    if (dtBlockId.Rows.Count > 0)
                    {
                        newBlockID = Convert.ToInt32(dtBlockId.Rows[0][0]) + 1;
                    }

                    StringBuilder sb = new StringBuilder("Insert into ModbusReg(BlockID,SlaveID,FunCode,StartAddress,WordCount,PollDelay,GroupID,Comport,IP,Port,DevID) select * from (");
                    sb.Append("select ");
                    sb.Append(newBlockID);
                    sb.Append(" as BlockID,SlaveID,FunCode,StartAddress,WordCount,PollDelay,GroupID,Comport,IP,Port,DevID FROM ModbusReg where BlockID=");
                    sb.Append(blockID);
                    sb.Append(")");

                    command.CommandText = sb.ToString();
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    sb = new StringBuilder("Insert into ModbusRegBlockConfig(SLNo,BlockID,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor) select * from (");
                    sb.Append("select SLNo,");
                    sb.Append(newBlockID);
                    sb.Append(" as BlockID,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor from ModbusRegBlockConfig where BlockID=");
                    sb.Append(blockID);
                    sb.Append(")");
                    command.CommandText = sb.ToString();
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Data cloned successfully", "Information");
                    LoadModbusReg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
            if (dgv.Rows.Count > 0)
            {
                int iRow = dgv.CurrentRow.Index;
                dgv.Rows.Insert(iRow + 1, 1);
                DataGridViewRow dgvRow = dgv.Rows[iRow + 1];
                dgvRow.Cells["Index"].Value = Convert.ToInt32(dgv.Rows[iRow].Cells[0].Value) + 1;
                if (iRow + 1 < dgv.Rows.Count)
                {
                    for (int next = iRow + 2; next < dgv.Rows.Count; next++)
                    {
                        dgv.Rows[next].Cells["Index"].Value = Convert.ToInt32(dgv.Rows[next - 1].Cells[0].Value) + 1;
                    }
                }
            }
            else
            {
                int iRow = dgv.Rows.Add();
                DataGridViewRow dgvRow = dgv.Rows[iRow];
                dgvRow.Cells["Index"].Value = iRow > 0 ? Convert.ToInt32(dgv.Rows[iRow - 1].Cells[0].Value) + 1 : 1;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                ModbusRegisterBlock mrg = new ModbusRegisterBlock(Convert.ToInt32(dgv.CurrentRow.Cells["Index"].Value), this);
                mrg.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first", "Information");
            }
        }
        private void SaveModBusRegConfig()
        {
            try
            {
                DataGridView dgv = (DataGridView)tabModbusReg.Controls["dtConfig"];
                if (string.IsNullOrEmpty(txtConfigName.Text))
                {
                    MessageBox.Show("Please enter Config Name first", "Information");
                    return;
                }
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("There is no row to save", "Warning");
                    return;
                }
                DataTable dtModbusRegConfig = GetConfigDetails(txtConfigName.Text);
                // Create a connection
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                if (dtModbusRegConfig.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder("Delete from ModbusRegConfig where ConfigName='");
                    sb.Append(txtConfigName.Text);
                    sb.Append("'");
                    // Create a command and set its connection    
                    OleDbCommand command = new OleDbCommand(sb.ToString(), connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                for (int iRow = 0; iRow < dgv.Rows.Count; iRow++)
                {
                    StringBuilder sb = new StringBuilder("Insert into ModbusRegConfig(ConfigName,ModbusRegID) values ( '");
                    sb.Append(txtConfigName.Text);
                    sb.Append("',");
                    sb.Append(dgv.Rows[iRow].Cells["Index"].Value);
                    sb.Append(")");
                    OleDbCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sb.ToString();
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void SaveModBusCfg()
        {
            try
            {
                OleDbConnection con = GetConnection();
                if (con == null)
                    throw new Exception("No database found");
                OleDbCommand cmd = con.CreateCommand();

                //Delete prev data
                StringBuilder sb = new StringBuilder("delete from ModbusCfg");
                cmd.CommandText = sb.ToString();
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //Save new data
                sb = new StringBuilder("Insert into ModbusCfg(Port,BaudRate,ConnectionType,ReplyTimeout,InterPollDelay,RetryCount,InterCharDelay,Mode,DataFormatTx,LogEventTx,PollInterval,OnBoardIO,LogInterval)");
                sb.Append(" Values ('");
                sb.Append(cmbPort.SelectedItem);
                sb.Append("',");
                sb.Append(string.IsNullOrEmpty(Convert.ToString(cmbBaudRate.SelectedItem)) == true ? "0" : Convert.ToString(cmbBaudRate.SelectedItem));
                sb.Append(",'");
                sb.Append(string.IsNullOrEmpty(Convert.ToString(cmbConnectionType.SelectedItem)) == true ? "0" : Convert.ToString(cmbConnectionType.SelectedItem));
                sb.Append("',");
                sb.Append(string.IsNullOrEmpty(txtReplyTimeOut.Text) == true ? "0" : txtReplyTimeOut.Text);
                sb.Append(",");
                sb.Append(string.IsNullOrEmpty(txtInterPollDelay.Text) == true ? "0" : txtInterPollDelay.Text);
                sb.Append(",");
                sb.Append(string.IsNullOrEmpty(Convert.ToString(cmbRetryCount.SelectedItem)) == true ? "0" : Convert.ToString(cmbRetryCount.SelectedItem));
                sb.Append(",");
                sb.Append(string.IsNullOrEmpty(txtInterCharDelay.Text) == true ? "0" : txtInterCharDelay.Text);
                sb.Append(",'");
                sb.Append(cmbMode.SelectedItem);
                sb.Append("','");
                sb.Append(cmbDataFormat.SelectedItem);
                sb.Append("','");
                sb.Append(cmbLogEvent.SelectedItem);
                sb.Append("',");
                sb.Append(string.IsNullOrEmpty(txtPollInterval.Text) == true ? "0" : txtPollInterval.Text);
                sb.Append(",'");
                sb.Append(cmbOnBoardIOEvent.SelectedItem);
                sb.Append("',");
                sb.Append(string.IsNullOrEmpty(txtLogInterval1.Text) == true ? "0" : txtLogInterval1.Text);
                sb.Append(")");
                cmd.CommandText = sb.ToString();

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private DataTable GetConfigDetails(string configName)
        {
            DataTable dtModbusRegConfig = new DataTable();
            try
            {
                StringBuilder sb = new StringBuilder("SELECT ConfigName FROM ModbusRegConfig");
                if (!string.IsNullOrEmpty(configName))
                {
                    sb.Append(" where ConfigName='");
                    sb.Append(configName);
                    sb.Append("'");
                }
                sb.Append(" order by CreatedOn desc");
                // Create a connection    
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(sb.ToString(), connection);
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusRegConfig);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return dtModbusRegConfig;
        }
        private void AddEditModbusRegWithBlock(ModbusReg mreg)
        {
            try
            {
                string strSQL = "SELECT * FROM ModbusReg where BlockID=" + mreg.BLK;
                // Create a connection    
                OleDbConnection connection = GetConnection();
                if (connection == null)
                    throw new Exception("No database found");
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                DataTable dtModbusReg = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusReg);
                    connection.Close();
                }
                if (dtModbusReg.Rows.Count > 0)
                {
                    UpdateModbusReg(mreg, connection);
                }
                else
                {
                    InsertModbusReg(mreg, connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }
        private void UpdateModbusReg(ModbusReg mreg, OleDbConnection con)
        {
            StringBuilder sb = new StringBuilder("Update ModbusReg set ");
            sb.Append("SlaveID = '");
            sb.Append(mreg.SLV);
            sb.Append("',FunCode = '");
            sb.Append(mreg.FC);
            sb.Append("',StartAddress = ");
            sb.Append(mreg.SADD);
            sb.Append(",WordCount = ");
            sb.Append(mreg.WRDC);
            sb.Append(",PollDelay = ");
            sb.Append(mreg.PDLY);
            sb.Append(",GroupID = ");
            sb.Append(mreg.GRP);
            sb.Append(",Comport = '");
            sb.Append(mreg.COM);
            sb.Append("',IP = '");
            sb.Append(mreg.IP);
            sb.Append("',Port = ");
            sb.Append(mreg.PORT);
            sb.Append(",DevID = ");
            sb.Append(mreg.DEV);
            sb.Append(" where BlockID = ");
            sb.Append(mreg.BLK);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sb.ToString();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //Update Modbus Block
            sb = new StringBuilder("Delete from ModbusRegBlockConfig where BlockID=");
            sb.Append(mreg.BLK);
            cmd.CommandText = sb.ToString();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            InsertModbusRegBlockConfig(mreg.MBLK, mreg.BLK, con);
        }
        private void InsertModbusRegBlockConfig(ModbusRegBlock[] arrBlocks, int blockID, OleDbConnection conn)
        {
            for (int iRow = 0; iRow < arrBlocks.Length; iRow++)
            {
                StringBuilder sb = new StringBuilder("Insert into ModbusRegBlockConfig(SLNo,BlockID,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor) values ( ");
                sb.Append(arrBlocks[iRow].SLNo);
                sb.Append(",");
                sb.Append(blockID);
                sb.Append(",'");
                sb.Append(arrBlocks[iRow].ADD);
                sb.Append("','");
                sb.Append(arrBlocks[iRow].FLDN);
                sb.Append("',");
                sb.Append(arrBlocks[iRow].END);
                sb.Append(",'");
                sb.Append(arrBlocks[iRow].FLDT);
                sb.Append("',");
                sb.Append(arrBlocks[iRow].CFLD);
                sb.Append(",");
                sb.Append(arrBlocks[iRow].WORD);
                sb.Append(",'");
                sb.Append(arrBlocks[iRow].RES);
                sb.Append("','");
                sb.Append(arrBlocks[iRow].SFAC);
                sb.Append("')");
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sb.ToString();
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        private void InsertModbusReg(ModbusReg mreg, OleDbConnection conn)
        {
            if (string.IsNullOrEmpty(Convert.ToString(mreg.BLK)))
                mreg.BLK = GetNewBlockID(conn);
            OleDbCommand cmd = conn.CreateCommand();
            StringBuilder sb = new StringBuilder("Insert into ModbusReg(BlockID,SlaveID,FunCode,StartAddress,WordCount,PollDelay,GroupID,Comport,IP,Port,DevID) Values (");
            sb.Append(mreg.BLK);
            sb.Append(",'");
            sb.Append(mreg.SLV);
            sb.Append("','");
            sb.Append(mreg.SLV);
            sb.Append("',");
            sb.Append(mreg.SLV);
            sb.Append(",");
            sb.Append(mreg.SLV);
            sb.Append(",");
            sb.Append(mreg.SLV);
            sb.Append(",");
            sb.Append(mreg.SLV);
            sb.Append(",'");
            sb.Append(mreg.SLV);
            sb.Append("','");
            sb.Append(mreg.SLV);
            sb.Append("',");
            sb.Append(mreg.SLV);
            sb.Append(",");
            sb.Append(mreg.SLV);
            sb.Append(")");
            cmd.CommandText = sb.ToString();
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            sb = new StringBuilder("Delete from ModbusRegBlockConfig where BlockID=");
            sb.Append(mreg.BLK);
            cmd.CommandText = sb.ToString();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            InsertModbusRegBlockConfig(mreg.MBLK, mreg.BLK, conn);
        }
        private int GetNewBlockID(OleDbConnection connection)
        {
            int newBlockID = 1;
            try
            {
                string strSQL = "SELECT MAX(BlockID) BlockID FROM ModbusReg";
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                DataTable dtBlockIds = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtBlockIds);
                    connection.Close();
                }
                if (dtBlockIds.Rows.Count > 0)
                {
                    newBlockID = Convert.ToInt32(dtBlockIds.Rows[0]["BlockID"]) + 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace, "Error");
            }
            return newBlockID;
        }
        #endregion
        #region IPSett
        private void setFieldsIpSett(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                cmbConnectProtocol.SelectedItem = fields[1];
                txtServerIPURL.Text = fields[2];
                txtServerPort.Text = fields[3];
                chkSSLSecurityEnable.Checked = Convert.ToBoolean(fields[4]);
                cmbSSLSecurityEnabled.SelectedItem = fields[5];
                cmbEventTransmission.SelectedItem = fields[6];
                txtAPN.Text = fields[7];
                txtIPSettUserName.Text = fields[8];
                txtIPSettPassword.Text = fields[9];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private string getUploadStringForIPSett()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*IPSETT,");
            if (cmbConnectProtocol.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbConnectProtocol.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtServerIPURL.Text))
                sb.Append(Convert.ToString(txtServerIPURL.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtServerPort.Text))
                sb.Append(Convert.ToString(txtServerPort.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            sb.Append(chkSSLSecurityEnable.Checked.ToString());
            sb.Append(",");
            if (cmbSSLSecurityEnabled.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbSSLSecurityEnabled.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbEventTransmission.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbEventTransmission.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtServerPort.Text))
                sb.Append(Convert.ToString(txtServerPort.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtIPSettUserName.Text))
                sb.Append(Convert.ToString(txtIPSettUserName.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtIPSettUserName.Text))
                sb.Append(Convert.ToString(txtIPSettUserName.Text));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private void loadIPSettDetails(Dictionary<string, string> kvp)
        {
            if (cmbConnectProtocol.Items.Contains(kvp["ConnectProtocol"]))
                cmbConnectProtocol.SelectedItem = kvp["ConnectProtocol"];
            txtServerIPURL.Text = kvp["ServerIP"];
            txtServerPort.Text = kvp["ServerPort"];
            chkSSLSecurityEnable.Checked = Convert.ToBoolean(kvp["SSLSecurityCheck"]);
            if (cmbSSLSecurityEnabled.Items.Contains(kvp["SSLSecurityEnabled"]))
                cmbSSLSecurityEnabled.SelectedItem = kvp["SSLSecurityEnabled"];
            if (cmbEventTransmission.Items.Contains(kvp["EventTransmission"]))
                cmbEventTransmission.SelectedItem = kvp["EventTransmission"];
            txtAPN.Text = kvp["APN"];
            txtIPSettUserName.Text = kvp["UserName"];
            txtIPSettPassword.Text = kvp["Password"];
        }
        private void txtServerPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void populateIPSettDropdown()
        {
            cmbEventTransmission.SelectedIndex = 0;
        }
        private string GetIPSettSaveString()
        {
            StringBuilder sb = new StringBuilder();
            //"<Cfg.device: ID=\"1\",NAME=\"ST51 - 2G\",UPSWD=\"2222\",SMS=\"1, 0\",PH1=\"\",PH2=\"\",PH3=\"\">"
            sb.Append("<Cfg.IPSett: ConnectProtocol=\"");
            sb.Append(cmbConnectProtocol.SelectedItem);
            sb.Append("\",");
            sb.Append("ServerIP=\"");
            sb.Append(txtServerIPURL.Text);
            sb.Append("\",");
            sb.Append("ServerPort=\"");
            sb.Append(txtServerPort.Text);
            sb.Append("\",");
            sb.Append("SSLSecurityCheck=\"");
            sb.Append(chkSSLSecurityEnable.Checked);
            sb.Append("\",");
            sb.Append("SSLSecurityEnabled=\"");
            sb.Append(cmbSSLSecurityEnabled.SelectedItem);
            sb.Append("\",");
            sb.Append("EventTransmission=\"");
            sb.Append(cmbEventTransmission.SelectedItem);
            sb.Append("\",");
            sb.Append("APN=\"");
            sb.Append(txtAPN.Text);
            sb.Append("\",");
            sb.Append("UserName=\"");
            sb.Append(txtIPSettUserName.Text);
            sb.Append("\",");
            sb.Append("Password=\"");
            sb.Append(txtIPSettPassword.Text);
            sb.Append("\"");
            sb.Append(">");
            return sb.ToString();
        }
        private void btnIPSettPassView_Click(object sender, EventArgs e)
        {
            if (txtIPSettPassword.UseSystemPasswordChar)
            {
                txtIPSettPassword.UseSystemPasswordChar = false;
                btnIPSettPassView.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passhide.png");
            }
            else
            {
                txtIPSettPassword.UseSystemPasswordChar = true;
                btnIPSettPassView.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passshow.png");
            }

        }
        #endregion
        #region Connection
        private string getUploadStringForConnection()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*CONN,");
            if (cmbIPConnectMode.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbIPConnectMode.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbMaxRetries.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbMaxRetries.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtConnectFail.Text))
                sb.Append(Convert.ToString(txtConnectFail.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtDeviceToServer.Text))
                sb.Append(Convert.ToString(txtDeviceToServer.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            sb.Append(chkKeepAlive.Checked.ToString());
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtDuration.Text))
                sb.Append(Convert.ToString(txtDuration.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtMessage.Text))
                sb.Append(Convert.ToString(txtMessage.Text));
            else
                sb.Append(" ");
            sb.Append(",");

            if (cmbSelectHttpMethod.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbSelectHttpMethod.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbSelectEventFormat.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbSelectEventFormat.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtAPIAccessKey.Text))
                sb.Append(Convert.ToString(txtAPIAccessKey.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbSelectAPIKeyAddIn.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbSelectAPIKeyAddIn.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbFlashDataLogging.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbFlashDataLogging.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsConn(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                cmbIPConnectMode.SelectedItem = fields[1];
                cmbMaxRetries.SelectedItem = fields[2];
                txtConnectFail.Text = fields[3];
                txtDeviceToServer.Text = fields[4];
                chkKeepAlive.Checked = Convert.ToBoolean(fields[5]);
                txtDuration.Text = fields[6];
                txtMessage.Text = fields[7];
                cmbSelectHttpMethod.SelectedItem = fields[8];
                cmbSelectEventFormat.SelectedItem = fields[9];
                txtAPIAccessKey.Text = fields[10];
                cmbSelectAPIKeyAddIn.SelectedItem = fields[11];
                cmbFlashDataLogging.SelectedItem = fields[12];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void loadConnDetails(Dictionary<string, string> kvp)
        {
            if (cmbIPConnectMode.Items.Contains(kvp["IPConnectMode"]))
                cmbIPConnectMode.SelectedItem = kvp["IPConnectMode"];
            if (cmbMaxRetries.Items.Contains(kvp["MaxRetries"]))
                cmbMaxRetries.SelectedItem = kvp["MaxRetries"];
            txtConnectFail.Text = kvp["ConnectFail"];
            txtDeviceToServer.Text = kvp["DeviceToServer"];
            chkKeepAlive.Checked = Convert.ToBoolean(kvp["KeepAlive"]);
            txtDuration.Text = kvp["KeepAliveDuration"];
            txtMessage.Text = kvp["Message"];
            if (cmbSelectHttpMethod.Items.Contains(kvp["HttpMethod"]))
                cmbSelectHttpMethod.SelectedItem = kvp["HttpMethod"];
            if (cmbSelectEventFormat.Items.Contains(kvp["SelectEventFormat"]))
                cmbSelectEventFormat.SelectedItem = kvp["SelectEventFormat"];
            txtAPIAccessKey.Text = kvp["APIAccessKey"];
            //cmbSelectAPIKeyAddIn.SelectedItem = kvp["APIKeyAddIn"];
            if (cmbFlashDataLogging.Items.Contains(kvp["FlashDataLogging"]))
                cmbFlashDataLogging.SelectedItem = kvp["FlashDataLogging"];
        }
        private string GetConnectionSaveString()
        {
            StringBuilder sb = new StringBuilder();
            //"<Cfg.device: ID=\"1\",NAME=\"ST51 - 2G\",UPSWD=\"2222\",SMS=\"1, 0\",PH1=\"\",PH2=\"\",PH3=\"\">"
            sb.Append("<Cfg.Connection: IPConnectMode=\"");
            sb.Append(cmbIPConnectMode.SelectedItem);
            sb.Append("\",");
            sb.Append("MaxRetries=\"");
            sb.Append(cmbMaxRetries.SelectedItem);
            sb.Append("\",");
            sb.Append("ConnectFail=\"");
            sb.Append(txtConnectFail.Text);
            sb.Append("\",");
            sb.Append("DeviceToServer=\"");
            sb.Append(txtDeviceToServer.Text);
            sb.Append("\",");
            sb.Append("KeepAlive=\"");
            sb.Append(chkKeepAlive.Checked);
            sb.Append("\",");
            sb.Append("KeepAliveDuration=\"");
            sb.Append(txtDuration.Text);
            sb.Append("\",");
            sb.Append("Message=\"");
            sb.Append(txtMessage.Text);
            sb.Append("\",");
            sb.Append("HttpMethod=\"");
            sb.Append(cmbSelectHttpMethod.SelectedItem);
            sb.Append("\",");
            sb.Append("SelectEventFormat=\"");
            sb.Append(cmbSelectEventFormat.SelectedItem);
            sb.Append("\",");
            sb.Append("APIAccessKey=\"");
            sb.Append(txtAPIAccessKey.Text);
            sb.Append("\",");
            sb.Append("APIKeyAddIn=\"");
            sb.Append(cmbSelectAPIKeyAddIn.SelectedItem);
            sb.Append("\",");
            sb.Append("FlashDataLogging=\"");
            sb.Append(cmbFlashDataLogging.SelectedItem);
            sb.Append("\"");
            sb.Append(">");
            return sb.ToString();
        }
        private void txtConnectFail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDeviceToServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Device
        private string getUploadStringForDevice()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DEVICE,");
            if (!string.IsNullOrEmpty(txtDeviceID.Text))
                sb.Append(Convert.ToString(txtDeviceID.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            //if (!string.IsNullOrEmpty(txtDeviceName.Text))
            //    sb.Append(Convert.ToString(txtDeviceName.Text));
            //else
            //    sb.Append(" ");
            //sb.Append(",");
            //if (!string.IsNullOrEmpty(txtDevicePassword.Text))
            //    sb.Append(Convert.ToString(txtDevicePassword.Text));
            //else
            //    sb.Append(" ");
            //sb.Append(",");
            sb.Append(chkSMSEnable.Checked.ToString());
            sb.Append(",");
            sb.Append(chkRemoteConfigSecuredPhNos.Checked.ToString());
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPhoneNo1.Text))
                sb.Append(Convert.ToString(txtPhoneNo1.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPhoneNo2.Text))
                sb.Append(Convert.ToString(txtPhoneNo2.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPhoneNo3.Text))
                sb.Append(Convert.ToString(txtPhoneNo3.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbGMTPlusMinus.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbGMTPlusMinus.SelectedItem));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbGMTHour.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbGMTHour.SelectedItem));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbGMTMin.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbGMTMin.SelectedItem));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtEventHeaderFirst.Text))
                sb.Append(Convert.ToString(txtEventHeaderFirst.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtEventHeaderSecond.Text))
                sb.Append(Convert.ToString(txtEventHeaderSecond.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtEventHeaderThird.Text))
                sb.Append(Convert.ToString(txtEventHeaderThird.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbTimeSyncFrom.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbTimeSyncFrom.SelectedItem));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtTimeSyncFrom.Text))
                sb.Append(Convert.ToString(txtTimeSyncFrom.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbEventTimeFormat.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbEventTimeFormat.SelectedItem));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsDevice(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                txtDeviceID.Text = fields[1];
                txtDeviceName.Text = fields[2];
                txtDevicePassword.Text = fields[3];
                chkSMSEnable.Checked = Convert.ToBoolean(fields[4]);
                chkRemoteConfigSecuredPhNos.Checked = Convert.ToBoolean(fields[5]);
                txtPhoneNo1.Text = fields[6];
                txtPhoneNo2.Text = fields[7];
                txtPhoneNo3.Text = fields[8];
                cmbGMTPlusMinus.SelectedItem = fields[9];
                cmbGMTHour.SelectedItem = fields[10];
                cmbGMTMin.SelectedItem = fields[11];
                txtEventHeaderFirst.Text = fields[12];
                txtEventHeaderSecond.Text = fields[13];
                txtEventHeaderThird.Text = fields[14];
                cmbTimeSyncFrom.SelectedItem = fields[15];
                txtTimeSyncFrom.Text = fields[16];
                cmbEventTimeFormat.SelectedItem = fields[17];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void btnDevicePassShow_Click(object sender, EventArgs e)
        {
            if (txtDevicePassword.UseSystemPasswordChar)
            {
                txtDevicePassword.UseSystemPasswordChar = false;
                btnDevicePassShow.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passhide.png");
            }
            else
            {
                txtDevicePassword.UseSystemPasswordChar = true;
                btnDevicePassShow.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passshow.png");
            }
        }
        private void loadDeviceDetails(Dictionary<string, string> kvp)
        {
            txtDeviceID.Text = kvp["DeviceID"];
            txtDeviceName.Text = kvp["DeviceName"];
            txtDevicePassword.Text = kvp["DevicePassword"];
            chkSMSEnable.Checked = Convert.ToBoolean(kvp["SMSEnable"]);
            chkRemoteConfigSecuredPhNos.Checked = Convert.ToBoolean(kvp["RemoteConfig"]);
            txtPhoneNo1.Text = kvp["Phone1"];
            txtPhoneNo2.Text = kvp["Phone2"];
            txtPhoneNo3.Text = kvp["Phone3"];
            if (cmbGMTPlusMinus.Items.Contains(kvp["GMT"]))
                cmbGMTPlusMinus.SelectedItem = kvp["GMT"];
            if (cmbGMTHour.Items.Contains(kvp["GMTHour"]))
                cmbGMTHour.SelectedItem = kvp["GMTHour"];
            if (cmbGMTMin.Items.Contains(kvp["GMTMin"]))
                cmbGMTMin.SelectedItem = kvp["GMTMin"];
            txtEventHeaderFirst.Text = kvp["EventHeaderModbus"];
            txtEventHeaderSecond.Text = kvp["EventHeaderIO"];
            txtEventHeaderThird.Text = kvp["EventHeaderSystem"];
            if (cmbTimeSyncFrom.Items.Contains(kvp["TimeSyncFrom"]))
                cmbTimeSyncFrom.SelectedItem = kvp["TimeSyncFrom"];
            txtTimeSyncFrom.Text = kvp["TimeSyncSec"];
            if (cmbEventTimeFormat.Items.Contains(kvp["EventTimeFormat"]))
                cmbEventTimeFormat.SelectedItem = kvp["EventTimeFormat"];
        }
        private string GetDeviceSaveString()
        {
            StringBuilder sb = new StringBuilder();
            //"<Cfg.device: ID=\"1\",NAME=\"ST51 - 2G\",UPSWD=\"2222\",SMS=\"1, 0\",PH1=\"\",PH2=\"\",PH3=\"\">"
            sb.Append("<Cfg.Device: DeviceID=\"");
            sb.Append(txtDeviceID.Text);
            sb.Append("\",");
            sb.Append("DeviceName=\"");
            sb.Append(txtDeviceName.Text);
            sb.Append("\",");
            sb.Append("DevicePassword=\"");
            sb.Append(txtDevicePassword.Text);
            sb.Append("\",");
            sb.Append("SMSEnable=\"");
            sb.Append(chkSMSEnable.Checked);
            sb.Append("\",");
            sb.Append("RemoteConfig=\"");
            sb.Append(chkRemoteConfigSecuredPhNos.Checked);
            sb.Append("\",");
            sb.Append("Phone1=\"");
            sb.Append(txtPhoneNo1.Text);
            sb.Append("\",");
            sb.Append("Phone2=\"");
            sb.Append(txtPhoneNo2.Text);
            sb.Append("\",");
            sb.Append("Phone3=\"");
            sb.Append(txtPhoneNo3.Text);
            sb.Append("\",");
            sb.Append("GMT=\"");
            sb.Append(cmbGMTPlusMinus.SelectedItem);
            sb.Append("\",");
            sb.Append("GMTHour=\"");
            sb.Append(cmbGMTHour.SelectedItem);
            sb.Append("\",");
            sb.Append("GMTMin=\"");
            sb.Append(cmbGMTMin.SelectedItem);
            sb.Append("\",");
            sb.Append("EventHeaderModbus=\"");
            sb.Append(txtEventHeaderFirst.Text);
            sb.Append("\",");
            sb.Append("EventHeaderIO=\"");
            sb.Append(txtEventHeaderSecond.Text);
            sb.Append("\",");
            sb.Append("EventHeaderSystem=\"");
            sb.Append(txtEventHeaderThird.Text);
            sb.Append("\",");
            sb.Append("TimeSyncFrom=\"");
            sb.Append(cmbTimeSyncFrom.SelectedItem);
            sb.Append("\",");
            sb.Append("TimeSyncSec=\"");
            sb.Append(txtTimeSyncFrom.Text);
            sb.Append("\",");
            sb.Append("EventTimeFormat=\"");
            sb.Append(cmbEventTimeFormat.SelectedItem);
            sb.Append("\"");
            sb.Append(">");
            return sb.ToString();
        }
        private void txtPhoneNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimeSyncFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region MQTT
        private string getUploadStringForMQTT()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*MQTT,");
            if (!string.IsNullOrEmpty(txtBrokerIPDomain.Text))
                sb.Append(Convert.ToString(txtBrokerIPDomain.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtBrokerPort.Text))
                sb.Append(Convert.ToString(txtBrokerPort.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtClientId.Text))
                sb.Append(Convert.ToString(txtClientId.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            sb.Append(chkAuthEnable.Checked.ToString());
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtMQTTUserName.Text))
                sb.Append(Convert.ToString(txtMQTTUserName.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtMQTTPassword.Text))
                sb.Append(Convert.ToString(txtMQTTPassword.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPublishEvent.Text))
                sb.Append(Convert.ToString(txtPublishEvent.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtPublishCMDReply.Text))
                sb.Append(Convert.ToString(txtPublishCMDReply.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (!string.IsNullOrEmpty(txtSubscribeCmd.Text))
                sb.Append(Convert.ToString(txtSubscribeCmd.Text));
            else
                sb.Append(" ");
            sb.Append(",");
            if (cmbQosLevel.SelectedIndex >= 0)
                sb.Append(Convert.ToString(cmbQosLevel.SelectedIndex));
            else
                sb.Append(" ");
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsMQTT(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                txtBrokerIPDomain.Text = fields[1];
                txtBrokerPort.Text = fields[2];
                txtClientId.Text = fields[3];
                chkAuthEnable.Checked = Convert.ToBoolean(fields[4]);
                txtMQTTUserName.Text = fields[5];
                txtMQTTPassword.Text = fields[6];
                txtPublishEvent.Text = fields[7];
                txtPublishCMDReply.Text = fields[8];
                txtSubscribeCmd.Text = fields[9];
                cmbQosLevel.SelectedItem = fields[10];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void btnMQTTShowPass_Click(object sender, EventArgs e)
        {
            if (txtMQTTPassword.UseSystemPasswordChar)
            {
                txtMQTTPassword.UseSystemPasswordChar = false;
                btnMQTTShowPass.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passhide.png");
            }
            else
            {
                txtMQTTPassword.UseSystemPasswordChar = true;
                btnMQTTShowPass.BackgroundImage = Image.FromFile(Application.StartupPath + "Images\\passshow.png");
            }
        }
        private void loadMQTTDetails(Dictionary<string, string> kvp)
        {
            txtBrokerIPDomain.Text = kvp["BrokerIP"];
            txtBrokerPort.Text = kvp["BrokerPort"];
            txtClientId.Text = kvp["ClientID"];
            chkAuthEnable.Checked = Convert.ToBoolean(kvp["AuthEnable"]);
            txtMQTTUserName.Text = kvp["UserName"];
            txtMQTTPassword.Text = kvp["Password"];
            if (cmbQosLevel.Items.Contains(kvp["QOSLevel"]))
                cmbQosLevel.SelectedItem = kvp["QOSLevel"];
            txtPublishEvent.Text = kvp["PublishEvent"];
            txtPublishCMDReply.Text = kvp["PublishCMDReply"];
            txtSubscribeCmd.Text = kvp["SubscribeCMD"];
        }
        private string GetMQTTSaveString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Cfg.MQTT: BrokerIP=\"");
            sb.Append(txtBrokerIPDomain.Text);
            sb.Append("\",");
            sb.Append("BrokerPort=\"");
            sb.Append(txtBrokerPort.Text);
            sb.Append("\",");
            sb.Append("ClientID=\"");
            sb.Append(txtClientId.Text);
            sb.Append("\",");
            sb.Append("AuthEnable=\"");
            sb.Append(chkAuthEnable.Checked);
            sb.Append("\",");
            sb.Append("UserName=\"");
            sb.Append(txtMQTTUserName.Text);
            sb.Append("\",");
            sb.Append("Password=\"");
            sb.Append(txtMQTTPassword.Text);
            sb.Append("\",");
            sb.Append("QOSLevel=\"");
            sb.Append(cmbQosLevel.SelectedItem);
            sb.Append("\",");
            sb.Append("PublishEvent=\"");
            sb.Append(txtPublishEvent.Text);
            sb.Append("\",");
            sb.Append("PublishCMDReply=\"");
            sb.Append(txtPublishCMDReply.Text);
            sb.Append("\",");
            sb.Append("SubscribeCMD=\"");
            sb.Append(txtSubscribeCmd.Text);
            sb.Append("\"");
            sb.Append(">");
            return sb.ToString();
        }
        private void txtBrokerPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion

        #region Status
        private void setFieldStatus(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                lblDeviceModel.Text = fields[1];
                lblAppID.Text = fields[2];
                lblHardwareVer.Text = fields[3];
                lblFirmwareVer.Text = fields[4];
                lblClientID.Text = fields[5];
                lblDataFlash.Text = fields[6];
                lblFwFile.Text = fields[7];
                lblCfgFile.Text = fields[8];
                lblMbusDBFile.Text = fields[9];
                lblSSLFile.Text = fields[10];

                int gsmSinganl = Convert.ToInt32(fields[11]);
                if (gsmSinganl == 1)
                {
                    lblSignal1.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 2)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 3)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 4)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                    lblSignal4.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 5)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                    lblSignal4.BackColor = Color.Orange;
                    lblSignal5.BackColor = Color.Orange;
                }
                lblTime.Text = fields[11];
                lblGprsAttach.Text = fields[12];
                lblGprsTech.Text = fields[13];
                lblIMEI.Text = fields[14];
                lblPowerOn.Text = fields[15];
                lblNtpTimeSync.Text = fields[16];

                lblDigitalInput1.Text = fields[17];
                lblDigitalInput2.Text = fields[18];
                lblInput3.Text = fields[19];
                lblOutputState.Text = fields[20];
                lblPulseCounter.Text = fields[21];
                lblSystemVolt.Text = fields[22];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void setGSMStatus(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                int gsmSinganl = Convert.ToInt32(fields[1]);
                if (gsmSinganl == 1)
                {
                    lblSignal1.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 2)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 3)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 4)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                    lblSignal4.BackColor = Color.Orange;
                }
                else if (gsmSinganl == 5)
                {
                    lblSignal1.BackColor = Color.Orange;
                    lblSignal2.BackColor = Color.Orange;
                    lblSignal3.BackColor = Color.Orange;
                    lblSignal4.BackColor = Color.Orange;
                    lblSignal5.BackColor = Color.Orange;
                }
                lblTime.Text = fields[2];
                lblGprsAttach.Text = fields[3];
                lblGprsTech.Text = fields[4];
                lblIMEI.Text = fields[5];
                lblPowerOn.Text = fields[6];
                lblNtpTimeSync.Text = fields[7];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void setIOStatus(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                lblDigitalInput1.Text = fields[1];
                lblDigitalInput2.Text = fields[2];
                lblInput3.Text = fields[3];
                lblOutputState.Text = fields[4];
                lblPulseCounter.Text = fields[5];
                lblSystemVolt.Text = fields[6];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        #endregion

        #region Monitor
        private void setMonitorStatusInfoFields(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                lblBuffLogCount.Text = fields[1];
                lblFlashLogCount.Text = fields[2];
                lblTotalLogCount.Text = fields[3];
                lblGsmTime.Text = fields[4];
                lblRtcTime.Text = fields[5];
                lblLocalTime.Text = fields[6];
                lblHttpTime.Text = fields[7];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        private void setMonitorFields(string details)
        {
            try
            {
                details = details.Substring(1, details.Length - 2);
                string[] fields = details.Split(",");
                lblBuffLogCount.Text = fields[1];
                lblFlashLogCount.Text = fields[2];
                lblTotalLogCount.Text = fields[3];
                lblGsmTime.Text = fields[4];
                lblRtcTime.Text = fields[5];
                lblLocalTime.Text = fields[6];
                lblHttpTime.Text = fields[7];

                lblServer.Text = fields[8];
                lblContState.Text = fields[9];
                lblDataSend.Text = fields[10];
                lblRespTimMs.Text = fields[11];
                lblTxCount.Text = fields[12];
                lblxFailCount.Text = fields[13];
                lblRxCount.Text = fields[14];
                lblCfgRxCount.Text = fields[15];
                lblBuffOVFCount.Text = fields[16];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }
        #endregion

        #region Console
        #endregion
    }
}
