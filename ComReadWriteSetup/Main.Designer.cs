
namespace ComReadWrite
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridView dtConfig;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlaveId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PollDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProcessing = new System.Windows.Forms.ProgressBar();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbModbus = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbComPorts = new System.Windows.Forms.ComboBox();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.label96 = new System.Windows.Forms.Label();
            this.txtSystemLog = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnConsoleSend = new System.Windows.Forms.Button();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.btnModbusRead = new System.Windows.Forms.Button();
            this.btnLogMonitorOff = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label149 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblRespErrCode = new System.Windows.Forms.Label();
            this.lblContState = new System.Windows.Forms.Label();
            this.lblDataSend = new System.Windows.Forms.Label();
            this.lblRespTimMs = new System.Windows.Forms.Label();
            this.lblBuffOVFCount = new System.Windows.Forms.Label();
            this.lblCfgRxCount = new System.Windows.Forms.Label();
            this.lblRxCount = new System.Windows.Forms.Label();
            this.lblxFailCount = new System.Windows.Forms.Label();
            this.lblTxCount = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.btnMonitorStatusRead = new System.Windows.Forms.Button();
            this.label132 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.lblGsmTime = new System.Windows.Forms.Label();
            this.lblRtcTime = new System.Windows.Forms.Label();
            this.lblHttpTime = new System.Windows.Forms.Label();
            this.lblLocalTime = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.lblBuffLogCount = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.lblFlashLogCount = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.lblTotalLogCount = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.btnIOStatusRead = new System.Windows.Forms.Button();
            this.btnStatusReset = new System.Windows.Forms.Button();
            this.btnStatusIOOff = new System.Windows.Forms.Button();
            this.btnStatusIOOn = new System.Windows.Forms.Button();
            this.label130 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.lblDigitalInput2 = new System.Windows.Forms.Label();
            this.lblDigitalInput2Volt = new System.Windows.Forms.Label();
            this.lblDigitalInput1 = new System.Windows.Forms.Label();
            this.lblDigitalInput1Volt = new System.Windows.Forms.Label();
            this.lblOutputState = new System.Windows.Forms.Label();
            this.lblInput3Volt = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblPulseCounter = new System.Windows.Forms.Label();
            this.lblSystemVolt = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.btnStatusGSMRead = new System.Windows.Forms.Button();
            this.lblSignal2 = new System.Windows.Forms.Label();
            this.lblSignal3 = new System.Windows.Forms.Label();
            this.lblSignal4 = new System.Windows.Forms.Label();
            this.lblSignal5 = new System.Windows.Forms.Label();
            this.lblSignal1 = new System.Windows.Forms.Label();
            this.lblStatusProvider = new System.Windows.Forms.Label();
            this.lblStatusModule = new System.Windows.Forms.Label();
            this.lblStatusDecimal = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGprsAttach = new System.Windows.Forms.Label();
            this.lblGprs = new System.Windows.Forms.Label();
            this.lblGprsTech = new System.Windows.Forms.Label();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.lblPowerOn = new System.Windows.Forms.Label();
            this.lblNtpTimeSync = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.lblSSLFile = new System.Windows.Forms.Label();
            this.lblCfgFile = new System.Windows.Forms.Label();
            this.lblMbusDBFile = new System.Windows.Forms.Label();
            this.lblDataFlash = new System.Windows.Forms.Label();
            this.lblFwFile = new System.Windows.Forms.Label();
            this.lblFirmwareVer = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblHardwareVer = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblDeviceModel = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.tabModbusReg = new System.Windows.Forms.TabPage();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label98 = new System.Windows.Forms.Label();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.tabModBusCfg = new System.Windows.Forms.TabPage();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.txtLogInterval1 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.txtPollInterval = new System.Windows.Forms.TextBox();
            this.cmbOnBoardIOEvent = new System.Windows.Forms.ComboBox();
            this.cmbLogEvent = new System.Windows.Forms.ComboBox();
            this.cmbDataFormat = new System.Windows.Forms.ComboBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.cmbRetryCount = new System.Windows.Forms.ComboBox();
            this.txtInterCharDelay = new System.Windows.Forms.TextBox();
            this.txtInterPollDelay = new System.Windows.Forms.TextBox();
            this.txtReplyTimeOut = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.tabMQTT = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtSubscribeCmd = new System.Windows.Forms.TextBox();
            this.txtPublishCMDReply = new System.Windows.Forms.TextBox();
            this.txtPublishEvent = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btnMQTTShowPass = new System.Windows.Forms.Button();
            this.cmbQosLevel = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.chkAuthEnable = new System.Windows.Forms.CheckBox();
            this.txtMQTTPassword = new System.Windows.Forms.TextBox();
            this.txtMQTTUserName = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtBrokerPort = new System.Windows.Forms.TextBox();
            this.txtBrokerIPDomain = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtMobLocationCode = new System.Windows.Forms.TextBox();
            this.btnSMSSend = new System.Windows.Forms.Button();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtTestMessage = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cmbEventTimeFormat = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtTimeSyncFrom = new System.Windows.Forms.TextBox();
            this.cmbTimeSyncFrom = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtEventHeaderThird = new System.Windows.Forms.TextBox();
            this.txtEventHeaderSecond = new System.Windows.Forms.TextBox();
            this.txtEventHeaderFirst = new System.Windows.Forms.TextBox();
            this.cmbGMTMin = new System.Windows.Forms.ComboBox();
            this.cmbGMTHour = new System.Windows.Forms.ComboBox();
            this.cmbGMTPlusMinus = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtPhoneNo2 = new System.Windows.Forms.TextBox();
            this.txtPhoneNo3 = new System.Windows.Forms.TextBox();
            this.txtPhoneNo1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnDevicePassShow = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtDevicePassword = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.chkRemoteConfigSecuredPhNos = new System.Windows.Forms.CheckBox();
            this.chkSMSEnable = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnFactoryDefault = new System.Windows.Forms.Button();
            this.btnModbusDBClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRTCTimeSet = new System.Windows.Forms.Button();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbFlashDataLogging = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtAPIAccessKey = new System.Windows.Forms.TextBox();
            this.cmbSelectAPIKeyAddIn = new System.Windows.Forms.ComboBox();
            this.cmbSelectEventFormat = new System.Windows.Forms.ComboBox();
            this.cmbSelectHttpMethod = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtConnectFail = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.chkKeepAlive = new System.Windows.Forms.CheckBox();
            this.txtDeviceToServer = new System.Windows.Forms.TextBox();
            this.cmbMaxRetries = new System.Windows.Forms.ComboBox();
            this.cmbIPConnectMode = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabIpSett = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSSLModuleReupdate = new System.Windows.Forms.Button();
            this.btnClientKey = new System.Windows.Forms.Button();
            this.btnClientCertificate = new System.Windows.Forms.Button();
            this.btnCACertificate = new System.Windows.Forms.Button();
            this.txtClientKey = new System.Windows.Forms.TextBox();
            this.txtClientCertificate = new System.Windows.Forms.TextBox();
            this.txtCAServerCertificate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIPSettPassView = new System.Windows.Forms.Button();
            this.txtIPSettPassword = new System.Windows.Forms.TextBox();
            this.txtIPSettUserName = new System.Windows.Forms.TextBox();
            this.txtAPN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEventTransmission = new System.Windows.Forms.ComboBox();
            this.cmbSSLSecurityEnabled = new System.Windows.Forms.ComboBox();
            this.chkSSLSecurityEnable = new System.Windows.Forms.CheckBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIPURL = new System.Windows.Forms.TextBox();
            this.cmbConnectProtocol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerUploadDownload = new System.Windows.Forms.Timer(this.components);
            this.label46 = new System.Windows.Forms.Label();
            dtConfig = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dtConfig)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.tabModbusReg.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabModBusCfg.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.tabMQTT.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabDevice.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabIpSett.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtConfig
            // 
            dtConfig.AllowUserToAddRows = false;
            dtConfig.AllowUserToDeleteRows = false;
            dtConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.SlaveId,
            this.FunCode,
            this.StartAddress,
            this.WordCount,
            this.PollDelay,
            this.GroupID,
            this.ComPort,
            this.IP,
            this.cPort,
            this.DevID});
            dtConfig.Location = new System.Drawing.Point(8, 99);
            dtConfig.Name = "dtConfig";
            dtConfig.ReadOnly = true;
            dtConfig.RowHeadersWidth = 51;
            dtConfig.RowTemplate.Height = 29;
            dtConfig.Size = new System.Drawing.Size(1417, 564);
            dtConfig.TabIndex = 1;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "BlockID";
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 125;
            // 
            // SlaveId
            // 
            this.SlaveId.DataPropertyName = "SlaveID";
            this.SlaveId.HeaderText = "SlaveId";
            this.SlaveId.MinimumWidth = 6;
            this.SlaveId.Name = "SlaveId";
            this.SlaveId.ReadOnly = true;
            this.SlaveId.Width = 125;
            // 
            // FunCode
            // 
            this.FunCode.DataPropertyName = "FunCode";
            this.FunCode.HeaderText = "Fun.Code";
            this.FunCode.MinimumWidth = 6;
            this.FunCode.Name = "FunCode";
            this.FunCode.ReadOnly = true;
            this.FunCode.Width = 125;
            // 
            // StartAddress
            // 
            this.StartAddress.DataPropertyName = "StartAddress";
            this.StartAddress.HeaderText = "StartAddress";
            this.StartAddress.MinimumWidth = 6;
            this.StartAddress.Name = "StartAddress";
            this.StartAddress.ReadOnly = true;
            this.StartAddress.Width = 125;
            // 
            // WordCount
            // 
            this.WordCount.DataPropertyName = "WordCount";
            this.WordCount.HeaderText = "WordCount";
            this.WordCount.MinimumWidth = 6;
            this.WordCount.Name = "WordCount";
            this.WordCount.ReadOnly = true;
            this.WordCount.Width = 125;
            // 
            // PollDelay
            // 
            this.PollDelay.DataPropertyName = "PollDelay";
            this.PollDelay.HeaderText = "Poll Dly";
            this.PollDelay.MinimumWidth = 6;
            this.PollDelay.Name = "PollDelay";
            this.PollDelay.ReadOnly = true;
            this.PollDelay.Width = 125;
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.HeaderText = "Group ID";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            this.GroupID.ReadOnly = true;
            this.GroupID.Width = 125;
            // 
            // ComPort
            // 
            this.ComPort.DataPropertyName = "Comport";
            this.ComPort.HeaderText = "Com Port";
            this.ComPort.MinimumWidth = 6;
            this.ComPort.Name = "ComPort";
            this.ComPort.ReadOnly = true;
            this.ComPort.Width = 125;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "IP";
            this.IP.MinimumWidth = 6;
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            this.IP.Width = 125;
            // 
            // cPort
            // 
            this.cPort.DataPropertyName = "Port";
            this.cPort.HeaderText = "Port";
            this.cPort.MinimumWidth = 6;
            this.cPort.Name = "cPort";
            this.cPort.ReadOnly = true;
            this.cPort.Width = 125;
            // 
            // DevID
            // 
            this.DevID.DataPropertyName = "DevID";
            this.DevID.HeaderText = "DevID";
            this.DevID.MinimumWidth = 6;
            this.DevID.Name = "DevID";
            this.DevID.ReadOnly = true;
            this.DevID.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.pbProcessing);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cmbModbus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbComPorts);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1436, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pbProcessing
            // 
            this.pbProcessing.Location = new System.Drawing.Point(704, 17);
            this.pbProcessing.Name = "pbProcessing";
            this.pbProcessing.Size = new System.Drawing.Size(248, 56);
            this.pbProcessing.TabIndex = 7;
            // 
            // btnUpload
            // 
            this.btnUpload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpload.BackgroundImage")));
            this.btnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(627, 17);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(59, 56);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.BackgroundImage")));
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(560, 17);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(60, 56);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(494, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 56);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(430, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(58, 56);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbModbus
            // 
            this.cmbModbus.FormattingEnabled = true;
            this.cmbModbus.Items.AddRange(new object[] {
            "CFG File",
            "Modbus DB File"});
            this.cmbModbus.Location = new System.Drawing.Point(269, 29);
            this.cmbModbus.Name = "cmbModbus";
            this.cmbModbus.Size = new System.Drawing.Size(151, 28);
            this.cmbModbus.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.Location = new System.Drawing.Point(165, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 56);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbComPorts
            // 
            this.cmbComPorts.FormattingEnabled = true;
            this.cmbComPorts.Location = new System.Drawing.Point(11, 30);
            this.cmbComPorts.Name = "cmbComPorts";
            this.cmbComPorts.Size = new System.Drawing.Size(151, 28);
            this.cmbComPorts.TabIndex = 0;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.label96);
            this.tabConsole.Controls.Add(this.txtSystemLog);
            this.tabConsole.Controls.Add(this.textBox3);
            this.tabConsole.Controls.Add(this.btnConsoleSend);
            this.tabConsole.Controls.Add(this.groupBox23);
            this.tabConsole.Location = new System.Drawing.Point(4, 29);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(1428, 671);
            this.tabConsole.TabIndex = 9;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(8, 182);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(85, 20);
            this.label96.TabIndex = 4;
            this.label96.Text = "System Log";
            // 
            // txtSystemLog
            // 
            this.txtSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSystemLog.Enabled = false;
            this.txtSystemLog.Location = new System.Drawing.Point(8, 213);
            this.txtSystemLog.Multiline = true;
            this.txtSystemLog.Name = "txtSystemLog";
            this.txtSystemLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSystemLog.Size = new System.Drawing.Size(1414, 450);
            this.txtSystemLog.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 91);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(1313, 76);
            this.textBox3.TabIndex = 1;
            // 
            // btnConsoleSend
            // 
            this.btnConsoleSend.Location = new System.Drawing.Point(1327, 91);
            this.btnConsoleSend.Name = "btnConsoleSend";
            this.btnConsoleSend.Size = new System.Drawing.Size(95, 76);
            this.btnConsoleSend.TabIndex = 2;
            this.btnConsoleSend.Text = "Send";
            this.btnConsoleSend.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox23.Controls.Add(this.btnModbusRead);
            this.groupBox23.Controls.Add(this.btnLogMonitorOff);
            this.groupBox23.Controls.Add(this.btnClear);
            this.groupBox23.Location = new System.Drawing.Point(8, 7);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(1414, 77);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            // 
            // btnModbusRead
            // 
            this.btnModbusRead.Location = new System.Drawing.Point(1152, 26);
            this.btnModbusRead.Name = "btnModbusRead";
            this.btnModbusRead.Size = new System.Drawing.Size(123, 29);
            this.btnModbusRead.TabIndex = 2;
            this.btnModbusRead.Text = "Modbus Read";
            this.btnModbusRead.UseVisualStyleBackColor = true;
            // 
            // btnLogMonitorOff
            // 
            this.btnLogMonitorOff.Location = new System.Drawing.Point(961, 26);
            this.btnLogMonitorOff.Name = "btnLogMonitorOff";
            this.btnLogMonitorOff.Size = new System.Drawing.Size(141, 29);
            this.btnLogMonitorOff.TabIndex = 1;
            this.btnLogMonitorOff.Text = "Log Monitor Off";
            this.btnLogMonitorOff.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(805, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.groupBox29);
            this.tabMonitor.Controls.Add(this.groupBox28);
            this.tabMonitor.Location = new System.Drawing.Point(4, 29);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(1428, 671);
            this.tabMonitor.TabIndex = 8;
            this.tabMonitor.Text = "Monitor";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label149);
            this.groupBox29.Controls.Add(this.label148);
            this.groupBox29.Controls.Add(this.label147);
            this.groupBox29.Controls.Add(this.label146);
            this.groupBox29.Controls.Add(this.label145);
            this.groupBox29.Controls.Add(this.label144);
            this.groupBox29.Controls.Add(this.label143);
            this.groupBox29.Controls.Add(this.label142);
            this.groupBox29.Controls.Add(this.label141);
            this.groupBox29.Controls.Add(this.label140);
            this.groupBox29.Controls.Add(this.lblServer);
            this.groupBox29.Controls.Add(this.lblRespErrCode);
            this.groupBox29.Controls.Add(this.lblContState);
            this.groupBox29.Controls.Add(this.lblDataSend);
            this.groupBox29.Controls.Add(this.lblRespTimMs);
            this.groupBox29.Controls.Add(this.lblBuffOVFCount);
            this.groupBox29.Controls.Add(this.lblCfgRxCount);
            this.groupBox29.Controls.Add(this.lblRxCount);
            this.groupBox29.Controls.Add(this.lblxFailCount);
            this.groupBox29.Controls.Add(this.lblTxCount);
            this.groupBox29.Controls.Add(this.label113);
            this.groupBox29.Location = new System.Drawing.Point(491, 7);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(502, 640);
            this.groupBox29.TabIndex = 1;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Sock Status";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(104, 133);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(53, 20);
            this.label149.TabIndex = 23;
            this.label149.Text = "Server:";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(104, 184);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(104, 20);
            this.label148.TabIndex = 22;
            this.label148.Text = "Resp. ErrCode:";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(104, 235);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(81, 20);
            this.label147.TabIndex = 21;
            this.label147.Text = "Cont State:";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(104, 286);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(81, 20);
            this.label146.TabIndex = 20;
            this.label146.Text = "Data Send:";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(104, 333);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(93, 20);
            this.label145.TabIndex = 19;
            this.label145.Text = "Resp tim ms:";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(104, 381);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(69, 20);
            this.label144.TabIndex = 18;
            this.label144.Text = "Tx Count:";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(104, 432);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(91, 20);
            this.label143.TabIndex = 17;
            this.label143.Text = "TxFail Count:";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(104, 480);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(71, 20);
            this.label142.TabIndex = 16;
            this.label142.Text = "Rx Count:";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(104, 529);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(94, 20);
            this.label141.TabIndex = 15;
            this.label141.Text = "CfgRx Count:";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(104, 571);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(113, 20);
            this.label140.TabIndex = 14;
            this.label140.Text = "Buff OVF Count:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(234, 133);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(66, 20);
            this.lblServer.TabIndex = 13;
            this.lblServer.Text = "label113";
            // 
            // lblRespErrCode
            // 
            this.lblRespErrCode.AutoSize = true;
            this.lblRespErrCode.Location = new System.Drawing.Point(234, 184);
            this.lblRespErrCode.Name = "lblRespErrCode";
            this.lblRespErrCode.Size = new System.Drawing.Size(66, 20);
            this.lblRespErrCode.TabIndex = 12;
            this.lblRespErrCode.Text = "label113";
            // 
            // lblContState
            // 
            this.lblContState.AutoSize = true;
            this.lblContState.Location = new System.Drawing.Point(234, 235);
            this.lblContState.Name = "lblContState";
            this.lblContState.Size = new System.Drawing.Size(66, 20);
            this.lblContState.TabIndex = 11;
            this.lblContState.Text = "label113";
            // 
            // lblDataSend
            // 
            this.lblDataSend.AutoSize = true;
            this.lblDataSend.Location = new System.Drawing.Point(234, 286);
            this.lblDataSend.Name = "lblDataSend";
            this.lblDataSend.Size = new System.Drawing.Size(66, 20);
            this.lblDataSend.TabIndex = 10;
            this.lblDataSend.Text = "label113";
            // 
            // lblRespTimMs
            // 
            this.lblRespTimMs.AutoSize = true;
            this.lblRespTimMs.Location = new System.Drawing.Point(234, 333);
            this.lblRespTimMs.Name = "lblRespTimMs";
            this.lblRespTimMs.Size = new System.Drawing.Size(66, 20);
            this.lblRespTimMs.TabIndex = 9;
            this.lblRespTimMs.Text = "label113";
            // 
            // lblBuffOVFCount
            // 
            this.lblBuffOVFCount.AutoSize = true;
            this.lblBuffOVFCount.Location = new System.Drawing.Point(234, 571);
            this.lblBuffOVFCount.Name = "lblBuffOVFCount";
            this.lblBuffOVFCount.Size = new System.Drawing.Size(66, 20);
            this.lblBuffOVFCount.TabIndex = 8;
            this.lblBuffOVFCount.Text = "label113";
            // 
            // lblCfgRxCount
            // 
            this.lblCfgRxCount.AutoSize = true;
            this.lblCfgRxCount.Location = new System.Drawing.Point(234, 529);
            this.lblCfgRxCount.Name = "lblCfgRxCount";
            this.lblCfgRxCount.Size = new System.Drawing.Size(66, 20);
            this.lblCfgRxCount.TabIndex = 7;
            this.lblCfgRxCount.Text = "label113";
            // 
            // lblRxCount
            // 
            this.lblRxCount.AutoSize = true;
            this.lblRxCount.Location = new System.Drawing.Point(234, 480);
            this.lblRxCount.Name = "lblRxCount";
            this.lblRxCount.Size = new System.Drawing.Size(66, 20);
            this.lblRxCount.TabIndex = 6;
            this.lblRxCount.Text = "label113";
            // 
            // lblxFailCount
            // 
            this.lblxFailCount.AutoSize = true;
            this.lblxFailCount.Location = new System.Drawing.Point(234, 432);
            this.lblxFailCount.Name = "lblxFailCount";
            this.lblxFailCount.Size = new System.Drawing.Size(66, 20);
            this.lblxFailCount.TabIndex = 5;
            this.lblxFailCount.Text = "label113";
            // 
            // lblTxCount
            // 
            this.lblTxCount.AutoSize = true;
            this.lblTxCount.Location = new System.Drawing.Point(234, 381);
            this.lblTxCount.Name = "lblTxCount";
            this.lblTxCount.Size = new System.Drawing.Size(66, 20);
            this.lblTxCount.TabIndex = 4;
            this.lblTxCount.Text = "label113";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label113.Location = new System.Drawing.Point(189, 89);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(118, 28);
            this.label113.TabIndex = 0;
            this.label113.Text = "PRI Sock-IP";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.btnMonitorStatusRead);
            this.groupBox28.Controls.Add(this.label132);
            this.groupBox28.Controls.Add(this.label131);
            this.groupBox28.Controls.Add(this.label124);
            this.groupBox28.Controls.Add(this.lblGsmTime);
            this.groupBox28.Controls.Add(this.lblRtcTime);
            this.groupBox28.Controls.Add(this.lblHttpTime);
            this.groupBox28.Controls.Add(this.lblLocalTime);
            this.groupBox28.Controls.Add(this.label111);
            this.groupBox28.Controls.Add(this.lblBuffLogCount);
            this.groupBox28.Controls.Add(this.label114);
            this.groupBox28.Controls.Add(this.lblFlashLogCount);
            this.groupBox28.Controls.Add(this.label112);
            this.groupBox28.Controls.Add(this.lblTotalLogCount);
            this.groupBox28.Controls.Add(this.label110);
            this.groupBox28.Location = new System.Drawing.Point(7, 7);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(464, 640);
            this.groupBox28.TabIndex = 0;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Status Info.";
            // 
            // btnMonitorStatusRead
            // 
            this.btnMonitorStatusRead.Location = new System.Drawing.Point(293, 529);
            this.btnMonitorStatusRead.Name = "btnMonitorStatusRead";
            this.btnMonitorStatusRead.Size = new System.Drawing.Size(94, 29);
            this.btnMonitorStatusRead.TabIndex = 14;
            this.btnMonitorStatusRead.Text = "Read";
            this.btnMonitorStatusRead.UseVisualStyleBackColor = true;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(36, 342);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(73, 20);
            this.label132.TabIndex = 13;
            this.label132.Text = "RTC Time:";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(36, 393);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(84, 20);
            this.label131.TabIndex = 12;
            this.label131.Text = "Local Time:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(36, 443);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(79, 20);
            this.label124.TabIndex = 11;
            this.label124.Text = "Http Time:";
            // 
            // lblGsmTime
            // 
            this.lblGsmTime.AutoSize = true;
            this.lblGsmTime.Location = new System.Drawing.Point(190, 293);
            this.lblGsmTime.Name = "lblGsmTime";
            this.lblGsmTime.Size = new System.Drawing.Size(66, 20);
            this.lblGsmTime.TabIndex = 10;
            this.lblGsmTime.Text = "label123";
            // 
            // lblRtcTime
            // 
            this.lblRtcTime.AutoSize = true;
            this.lblRtcTime.Location = new System.Drawing.Point(190, 342);
            this.lblRtcTime.Name = "lblRtcTime";
            this.lblRtcTime.Size = new System.Drawing.Size(66, 20);
            this.lblRtcTime.TabIndex = 9;
            this.lblRtcTime.Text = "label116";
            // 
            // lblHttpTime
            // 
            this.lblHttpTime.AutoSize = true;
            this.lblHttpTime.Location = new System.Drawing.Point(190, 443);
            this.lblHttpTime.Name = "lblHttpTime";
            this.lblHttpTime.Size = new System.Drawing.Size(66, 20);
            this.lblHttpTime.TabIndex = 8;
            this.lblHttpTime.Text = "label115";
            // 
            // lblLocalTime
            // 
            this.lblLocalTime.AutoSize = true;
            this.lblLocalTime.Location = new System.Drawing.Point(190, 393);
            this.lblLocalTime.Name = "lblLocalTime";
            this.lblLocalTime.Size = new System.Drawing.Size(66, 20);
            this.lblLocalTime.TabIndex = 7;
            this.lblLocalTime.Text = "label113";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(36, 293);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(80, 20);
            this.label111.TabIndex = 6;
            this.label111.Text = "GSM Time:";
            // 
            // lblBuffLogCount
            // 
            this.lblBuffLogCount.AutoSize = true;
            this.lblBuffLogCount.Location = new System.Drawing.Point(200, 59);
            this.lblBuffLogCount.Name = "lblBuffLogCount";
            this.lblBuffLogCount.Size = new System.Drawing.Size(36, 20);
            this.lblBuffLogCount.TabIndex = 5;
            this.lblBuffLogCount.Text = "buff";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(36, 103);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(117, 20);
            this.label114.TabIndex = 4;
            this.label114.Text = "Flash Log Count:";
            // 
            // lblFlashLogCount
            // 
            this.lblFlashLogCount.AutoSize = true;
            this.lblFlashLogCount.Location = new System.Drawing.Point(200, 103);
            this.lblFlashLogCount.Name = "lblFlashLogCount";
            this.lblFlashLogCount.Size = new System.Drawing.Size(66, 20);
            this.lblFlashLogCount.TabIndex = 3;
            this.lblFlashLogCount.Text = "label113";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(36, 151);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(117, 20);
            this.label112.TabIndex = 2;
            this.label112.Text = "Total Log Count:";
            // 
            // lblTotalLogCount
            // 
            this.lblTotalLogCount.AutoSize = true;
            this.lblTotalLogCount.Location = new System.Drawing.Point(200, 151);
            this.lblTotalLogCount.Name = "lblTotalLogCount";
            this.lblTotalLogCount.Size = new System.Drawing.Size(66, 20);
            this.lblTotalLogCount.TabIndex = 1;
            this.lblTotalLogCount.Text = "label111";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(36, 59);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(114, 20);
            this.label110.TabIndex = 0;
            this.label110.Text = "Buff. Log Count:";
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.groupBox27);
            this.tabStatus.Controls.Add(this.groupBox26);
            this.tabStatus.Controls.Add(this.groupBox25);
            this.tabStatus.Location = new System.Drawing.Point(4, 29);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(1428, 671);
            this.tabStatus.TabIndex = 7;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.btnIOStatusRead);
            this.groupBox27.Controls.Add(this.btnStatusReset);
            this.groupBox27.Controls.Add(this.btnStatusIOOff);
            this.groupBox27.Controls.Add(this.btnStatusIOOn);
            this.groupBox27.Controls.Add(this.label130);
            this.groupBox27.Controls.Add(this.label129);
            this.groupBox27.Controls.Add(this.label128);
            this.groupBox27.Controls.Add(this.label127);
            this.groupBox27.Controls.Add(this.label126);
            this.groupBox27.Controls.Add(this.label125);
            this.groupBox27.Controls.Add(this.lblDigitalInput2);
            this.groupBox27.Controls.Add(this.lblDigitalInput2Volt);
            this.groupBox27.Controls.Add(this.lblDigitalInput1);
            this.groupBox27.Controls.Add(this.lblDigitalInput1Volt);
            this.groupBox27.Controls.Add(this.lblOutputState);
            this.groupBox27.Controls.Add(this.lblInput3Volt);
            this.groupBox27.Controls.Add(this.lblInput3);
            this.groupBox27.Controls.Add(this.lblPulseCounter);
            this.groupBox27.Controls.Add(this.lblSystemVolt);
            this.groupBox27.Location = new System.Drawing.Point(968, 7);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(471, 660);
            this.groupBox27.TabIndex = 2;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "IO Status";
            // 
            // btnIOStatusRead
            // 
            this.btnIOStatusRead.Location = new System.Drawing.Point(339, 619);
            this.btnIOStatusRead.Name = "btnIOStatusRead";
            this.btnIOStatusRead.Size = new System.Drawing.Size(94, 29);
            this.btnIOStatusRead.TabIndex = 26;
            this.btnIOStatusRead.Text = "Read";
            this.btnIOStatusRead.UseVisualStyleBackColor = true;
            // 
            // btnStatusReset
            // 
            this.btnStatusReset.Location = new System.Drawing.Point(339, 231);
            this.btnStatusReset.Name = "btnStatusReset";
            this.btnStatusReset.Size = new System.Drawing.Size(94, 29);
            this.btnStatusReset.TabIndex = 25;
            this.btnStatusReset.Text = "Reset";
            this.btnStatusReset.UseVisualStyleBackColor = true;
            // 
            // btnStatusIOOff
            // 
            this.btnStatusIOOff.Location = new System.Drawing.Point(372, 186);
            this.btnStatusIOOff.Name = "btnStatusIOOff";
            this.btnStatusIOOff.Size = new System.Drawing.Size(61, 29);
            this.btnStatusIOOff.TabIndex = 24;
            this.btnStatusIOOff.Text = "Off";
            this.btnStatusIOOff.UseVisualStyleBackColor = true;
            // 
            // btnStatusIOOn
            // 
            this.btnStatusIOOn.Location = new System.Drawing.Point(296, 186);
            this.btnStatusIOOn.Name = "btnStatusIOOn";
            this.btnStatusIOOn.Size = new System.Drawing.Size(61, 29);
            this.btnStatusIOOn.TabIndex = 23;
            this.btnStatusIOOn.Text = "ON";
            this.btnStatusIOOn.UseVisualStyleBackColor = true;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(19, 32);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(109, 20);
            this.label130.TabIndex = 22;
            this.label130.Text = "Digital Input-1:";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(19, 82);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(109, 20);
            this.label129.TabIndex = 21;
            this.label129.Text = "Digital Input-2:";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(19, 131);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(125, 20);
            this.label128.TabIndex = 20;
            this.label128.Text = "Input-3 (4-20ma):";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(19, 186);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(96, 20);
            this.label127.TabIndex = 19;
            this.label127.Text = "Output State:";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(19, 235);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(102, 20);
            this.label126.TabIndex = 18;
            this.label126.Text = "Pulse Counter:";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(19, 288);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(89, 20);
            this.label125.TabIndex = 17;
            this.label125.Text = "System Volt:";
            // 
            // lblDigitalInput2
            // 
            this.lblDigitalInput2.AutoSize = true;
            this.lblDigitalInput2.Location = new System.Drawing.Point(163, 82);
            this.lblDigitalInput2.Name = "lblDigitalInput2";
            this.lblDigitalInput2.Size = new System.Drawing.Size(66, 20);
            this.lblDigitalInput2.TabIndex = 16;
            this.lblDigitalInput2.Text = "label116";
            // 
            // lblDigitalInput2Volt
            // 
            this.lblDigitalInput2Volt.AutoSize = true;
            this.lblDigitalInput2Volt.Location = new System.Drawing.Point(307, 82);
            this.lblDigitalInput2Volt.Name = "lblDigitalInput2Volt";
            this.lblDigitalInput2Volt.Size = new System.Drawing.Size(66, 20);
            this.lblDigitalInput2Volt.TabIndex = 15;
            this.lblDigitalInput2Volt.Text = "label116";
            // 
            // lblDigitalInput1
            // 
            this.lblDigitalInput1.AutoSize = true;
            this.lblDigitalInput1.Location = new System.Drawing.Point(163, 32);
            this.lblDigitalInput1.Name = "lblDigitalInput1";
            this.lblDigitalInput1.Size = new System.Drawing.Size(90, 20);
            this.lblDigitalInput1.TabIndex = 14;
            this.lblDigitalInput1.Text = "digital input";
            // 
            // lblDigitalInput1Volt
            // 
            this.lblDigitalInput1Volt.AutoSize = true;
            this.lblDigitalInput1Volt.Location = new System.Drawing.Point(307, 32);
            this.lblDigitalInput1Volt.Name = "lblDigitalInput1Volt";
            this.lblDigitalInput1Volt.Size = new System.Drawing.Size(66, 20);
            this.lblDigitalInput1Volt.TabIndex = 13;
            this.lblDigitalInput1Volt.Text = "label116";
            // 
            // lblOutputState
            // 
            this.lblOutputState.AutoSize = true;
            this.lblOutputState.Location = new System.Drawing.Point(163, 186);
            this.lblOutputState.Name = "lblOutputState";
            this.lblOutputState.Size = new System.Drawing.Size(66, 20);
            this.lblOutputState.TabIndex = 12;
            this.lblOutputState.Text = "label116";
            // 
            // lblInput3Volt
            // 
            this.lblInput3Volt.AutoSize = true;
            this.lblInput3Volt.Location = new System.Drawing.Point(307, 131);
            this.lblInput3Volt.Name = "lblInput3Volt";
            this.lblInput3Volt.Size = new System.Drawing.Size(66, 20);
            this.lblInput3Volt.TabIndex = 11;
            this.lblInput3Volt.Text = "label116";
            // 
            // lblInput3
            // 
            this.lblInput3.AutoSize = true;
            this.lblInput3.Location = new System.Drawing.Point(163, 131);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.Size = new System.Drawing.Size(66, 20);
            this.lblInput3.TabIndex = 10;
            this.lblInput3.Text = "label116";
            // 
            // lblPulseCounter
            // 
            this.lblPulseCounter.AutoSize = true;
            this.lblPulseCounter.Location = new System.Drawing.Point(163, 235);
            this.lblPulseCounter.Name = "lblPulseCounter";
            this.lblPulseCounter.Size = new System.Drawing.Size(66, 20);
            this.lblPulseCounter.TabIndex = 9;
            this.lblPulseCounter.Text = "label116";
            // 
            // lblSystemVolt
            // 
            this.lblSystemVolt.AutoSize = true;
            this.lblSystemVolt.Location = new System.Drawing.Point(163, 288);
            this.lblSystemVolt.Name = "lblSystemVolt";
            this.lblSystemVolt.Size = new System.Drawing.Size(66, 20);
            this.lblSystemVolt.TabIndex = 8;
            this.lblSystemVolt.Text = "label116";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.btnStatusGSMRead);
            this.groupBox26.Controls.Add(this.lblSignal2);
            this.groupBox26.Controls.Add(this.lblSignal3);
            this.groupBox26.Controls.Add(this.lblSignal4);
            this.groupBox26.Controls.Add(this.lblSignal5);
            this.groupBox26.Controls.Add(this.lblSignal1);
            this.groupBox26.Controls.Add(this.lblStatusProvider);
            this.groupBox26.Controls.Add(this.lblStatusModule);
            this.groupBox26.Controls.Add(this.lblStatusDecimal);
            this.groupBox26.Controls.Add(this.label122);
            this.groupBox26.Controls.Add(this.label121);
            this.groupBox26.Controls.Add(this.label120);
            this.groupBox26.Controls.Add(this.label119);
            this.groupBox26.Controls.Add(this.label118);
            this.groupBox26.Controls.Add(this.label117);
            this.groupBox26.Controls.Add(this.lblTime);
            this.groupBox26.Controls.Add(this.lblGprsAttach);
            this.groupBox26.Controls.Add(this.lblGprs);
            this.groupBox26.Controls.Add(this.lblGprsTech);
            this.groupBox26.Controls.Add(this.lblIMEI);
            this.groupBox26.Controls.Add(this.lblPowerOn);
            this.groupBox26.Controls.Add(this.lblNtpTimeSync);
            this.groupBox26.Controls.Add(this.label109);
            this.groupBox26.Location = new System.Drawing.Point(470, 7);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(491, 660);
            this.groupBox26.TabIndex = 1;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "GSM Status";
            // 
            // btnStatusGSMRead
            // 
            this.btnStatusGSMRead.Location = new System.Drawing.Point(364, 619);
            this.btnStatusGSMRead.Name = "btnStatusGSMRead";
            this.btnStatusGSMRead.Size = new System.Drawing.Size(94, 29);
            this.btnStatusGSMRead.TabIndex = 22;
            this.btnStatusGSMRead.Text = "Read";
            this.btnStatusGSMRead.UseVisualStyleBackColor = true;
            // 
            // lblSignal2
            // 
            this.lblSignal2.BackColor = System.Drawing.Color.White;
            this.lblSignal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSignal2.Location = new System.Drawing.Point(41, 103);
            this.lblSignal2.Name = "lblSignal2";
            this.lblSignal2.Size = new System.Drawing.Size(10, 20);
            this.lblSignal2.TabIndex = 21;
            // 
            // lblSignal3
            // 
            this.lblSignal3.BackColor = System.Drawing.Color.White;
            this.lblSignal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSignal3.Location = new System.Drawing.Point(57, 96);
            this.lblSignal3.Name = "lblSignal3";
            this.lblSignal3.Size = new System.Drawing.Size(10, 27);
            this.lblSignal3.TabIndex = 20;
            // 
            // lblSignal4
            // 
            this.lblSignal4.BackColor = System.Drawing.Color.White;
            this.lblSignal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSignal4.Location = new System.Drawing.Point(73, 89);
            this.lblSignal4.Name = "lblSignal4";
            this.lblSignal4.Size = new System.Drawing.Size(10, 34);
            this.lblSignal4.TabIndex = 19;
            // 
            // lblSignal5
            // 
            this.lblSignal5.BackColor = System.Drawing.Color.White;
            this.lblSignal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSignal5.Location = new System.Drawing.Point(89, 82);
            this.lblSignal5.Name = "lblSignal5";
            this.lblSignal5.Size = new System.Drawing.Size(10, 41);
            this.lblSignal5.TabIndex = 18;
            // 
            // lblSignal1
            // 
            this.lblSignal1.BackColor = System.Drawing.Color.White;
            this.lblSignal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSignal1.Location = new System.Drawing.Point(25, 110);
            this.lblSignal1.Name = "lblSignal1";
            this.lblSignal1.Size = new System.Drawing.Size(10, 13);
            this.lblSignal1.TabIndex = 17;
            // 
            // lblStatusProvider
            // 
            this.lblStatusProvider.AutoSize = true;
            this.lblStatusProvider.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusProvider.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusProvider.Location = new System.Drawing.Point(332, 41);
            this.lblStatusProvider.Name = "lblStatusProvider";
            this.lblStatusProvider.Size = new System.Drawing.Size(56, 28);
            this.lblStatusProvider.TabIndex = 16;
            this.lblStatusProvider.Text = "airtel";
            // 
            // lblStatusModule
            // 
            this.lblStatusModule.AutoSize = true;
            this.lblStatusModule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusModule.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusModule.Location = new System.Drawing.Point(332, 103);
            this.lblStatusModule.Name = "lblStatusModule";
            this.lblStatusModule.Size = new System.Drawing.Size(65, 28);
            this.lblStatusModule.TabIndex = 15;
            this.lblStatusModule.Text = "Home";
            // 
            // lblStatusDecimal
            // 
            this.lblStatusDecimal.AutoSize = true;
            this.lblStatusDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusDecimal.ForeColor = System.Drawing.Color.Blue;
            this.lblStatusDecimal.Location = new System.Drawing.Point(146, 103);
            this.lblStatusDecimal.Name = "lblStatusDecimal";
            this.lblStatusDecimal.Size = new System.Drawing.Size(58, 28);
            this.lblStatusDecimal.TabIndex = 14;
            this.lblStatusDecimal.Text = "15db";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(16, 235);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(94, 20);
            this.label122.TabIndex = 13;
            this.label122.Text = "GPRS Attach:";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(16, 288);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(47, 20);
            this.label121.TabIndex = 12;
            this.label121.Text = "GPRS:";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(16, 346);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(81, 20);
            this.label120.TabIndex = 11;
            this.label120.Text = "GPRS Tech:";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(16, 408);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(41, 20);
            this.label119.TabIndex = 10;
            this.label119.Text = "IMEI:";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(16, 463);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(78, 20);
            this.label118.TabIndex = 9;
            this.label118.Text = "Power ON:";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(16, 509);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(106, 20);
            this.label117.TabIndex = 8;
            this.label117.Text = "NTP TimeSync:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(156, 175);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "label116";
            // 
            // lblGprsAttach
            // 
            this.lblGprsAttach.AutoSize = true;
            this.lblGprsAttach.Location = new System.Drawing.Point(156, 235);
            this.lblGprsAttach.Name = "lblGprsAttach";
            this.lblGprsAttach.Size = new System.Drawing.Size(66, 20);
            this.lblGprsAttach.TabIndex = 6;
            this.lblGprsAttach.Text = "label115";
            // 
            // lblGprs
            // 
            this.lblGprs.AutoSize = true;
            this.lblGprs.Location = new System.Drawing.Point(156, 288);
            this.lblGprs.Name = "lblGprs";
            this.lblGprs.Size = new System.Drawing.Size(66, 20);
            this.lblGprs.TabIndex = 5;
            this.lblGprs.Text = "label114";
            // 
            // lblGprsTech
            // 
            this.lblGprsTech.AutoSize = true;
            this.lblGprsTech.Location = new System.Drawing.Point(156, 346);
            this.lblGprsTech.Name = "lblGprsTech";
            this.lblGprsTech.Size = new System.Drawing.Size(66, 20);
            this.lblGprsTech.TabIndex = 4;
            this.lblGprsTech.Text = "label113";
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(156, 408);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(66, 20);
            this.lblIMEI.TabIndex = 3;
            this.lblIMEI.Text = "label112";
            // 
            // lblPowerOn
            // 
            this.lblPowerOn.AutoSize = true;
            this.lblPowerOn.Location = new System.Drawing.Point(156, 463);
            this.lblPowerOn.Name = "lblPowerOn";
            this.lblPowerOn.Size = new System.Drawing.Size(66, 20);
            this.lblPowerOn.TabIndex = 2;
            this.lblPowerOn.Text = "label111";
            // 
            // lblNtpTimeSync
            // 
            this.lblNtpTimeSync.AutoSize = true;
            this.lblNtpTimeSync.Location = new System.Drawing.Point(156, 509);
            this.lblNtpTimeSync.Name = "lblNtpTimeSync";
            this.lblNtpTimeSync.Size = new System.Drawing.Size(66, 20);
            this.lblNtpTimeSync.TabIndex = 1;
            this.lblNtpTimeSync.Text = "label110";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(16, 175);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(45, 20);
            this.label109.TabIndex = 0;
            this.label109.Text = "TIME:";
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.lblSSLFile);
            this.groupBox25.Controls.Add(this.lblCfgFile);
            this.groupBox25.Controls.Add(this.lblMbusDBFile);
            this.groupBox25.Controls.Add(this.lblDataFlash);
            this.groupBox25.Controls.Add(this.lblFwFile);
            this.groupBox25.Controls.Add(this.lblFirmwareVer);
            this.groupBox25.Controls.Add(this.lblClientID);
            this.groupBox25.Controls.Add(this.lblHardwareVer);
            this.groupBox25.Controls.Add(this.lblAppID);
            this.groupBox25.Controls.Add(this.lblDeviceModel);
            this.groupBox25.Controls.Add(this.label108);
            this.groupBox25.Controls.Add(this.label107);
            this.groupBox25.Controls.Add(this.label106);
            this.groupBox25.Controls.Add(this.label105);
            this.groupBox25.Controls.Add(this.label104);
            this.groupBox25.Controls.Add(this.label103);
            this.groupBox25.Controls.Add(this.label102);
            this.groupBox25.Controls.Add(this.label101);
            this.groupBox25.Controls.Add(this.label100);
            this.groupBox25.Controls.Add(this.label99);
            this.groupBox25.Location = new System.Drawing.Point(8, 7);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(455, 660);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Device Info.";
            // 
            // lblSSLFile
            // 
            this.lblSSLFile.AutoSize = true;
            this.lblSSLFile.Location = new System.Drawing.Point(164, 480);
            this.lblSSLFile.Name = "lblSSLFile";
            this.lblSSLFile.Size = new System.Drawing.Size(59, 20);
            this.lblSSLFile.TabIndex = 19;
            this.lblSSLFile.Text = "SSL File";
            // 
            // lblCfgFile
            // 
            this.lblCfgFile.AutoSize = true;
            this.lblCfgFile.Location = new System.Drawing.Point(164, 386);
            this.lblCfgFile.Name = "lblCfgFile";
            this.lblCfgFile.Size = new System.Drawing.Size(59, 20);
            this.lblCfgFile.TabIndex = 18;
            this.lblCfgFile.Text = "Cfg File";
            // 
            // lblMbusDBFile
            // 
            this.lblMbusDBFile.AutoSize = true;
            this.lblMbusDBFile.Location = new System.Drawing.Point(164, 435);
            this.lblMbusDBFile.Name = "lblMbusDBFile";
            this.lblMbusDBFile.Size = new System.Drawing.Size(96, 20);
            this.lblMbusDBFile.TabIndex = 17;
            this.lblMbusDBFile.Text = "Mbus DB File";
            // 
            // lblDataFlash
            // 
            this.lblDataFlash.AutoSize = true;
            this.lblDataFlash.Location = new System.Drawing.Point(164, 266);
            this.lblDataFlash.Name = "lblDataFlash";
            this.lblDataFlash.Size = new System.Drawing.Size(78, 20);
            this.lblDataFlash.TabIndex = 16;
            this.lblDataFlash.Text = "Data Flash";
            // 
            // lblFwFile
            // 
            this.lblFwFile.AutoSize = true;
            this.lblFwFile.Location = new System.Drawing.Point(164, 336);
            this.lblFwFile.Name = "lblFwFile";
            this.lblFwFile.Size = new System.Drawing.Size(54, 20);
            this.lblFwFile.TabIndex = 15;
            this.lblFwFile.Text = "Fw File";
            // 
            // lblFirmwareVer
            // 
            this.lblFirmwareVer.AutoSize = true;
            this.lblFirmwareVer.Location = new System.Drawing.Point(164, 175);
            this.lblFirmwareVer.Name = "lblFirmwareVer";
            this.lblFirmwareVer.Size = new System.Drawing.Size(95, 20);
            this.lblFirmwareVer.TabIndex = 14;
            this.lblFirmwareVer.Text = "Firmware Ver";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(164, 221);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(66, 20);
            this.lblClientID.TabIndex = 13;
            this.lblClientID.Text = "Client ID";
            // 
            // lblHardwareVer
            // 
            this.lblHardwareVer.AutoSize = true;
            this.lblHardwareVer.Location = new System.Drawing.Point(164, 131);
            this.lblHardwareVer.Name = "lblHardwareVer";
            this.lblHardwareVer.Size = new System.Drawing.Size(99, 20);
            this.lblHardwareVer.TabIndex = 12;
            this.lblHardwareVer.Text = "Hardware Ver";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Location = new System.Drawing.Point(164, 85);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(56, 20);
            this.lblAppID.TabIndex = 11;
            this.lblAppID.Text = "App ID";
            // 
            // lblDeviceModel
            // 
            this.lblDeviceModel.AutoSize = true;
            this.lblDeviceModel.Location = new System.Drawing.Point(164, 41);
            this.lblDeviceModel.Name = "lblDeviceModel";
            this.lblDeviceModel.Size = new System.Drawing.Size(101, 20);
            this.lblDeviceModel.TabIndex = 10;
            this.lblDeviceModel.Text = "Device Model";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(19, 480);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(62, 20);
            this.label108.TabIndex = 9;
            this.label108.Text = "SSL File:";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(19, 435);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(99, 20);
            this.label107.TabIndex = 8;
            this.label107.Text = "Mbus DB File:";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(19, 386);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(65, 20);
            this.label106.TabIndex = 7;
            this.label106.Text = "Cfg. File:";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(19, 336);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(60, 20);
            this.label105.TabIndex = 6;
            this.label105.Text = "Fw. File:";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(19, 266);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(81, 20);
            this.label104.TabIndex = 5;
            this.label104.Text = "Data Flash:";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(19, 175);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(98, 20);
            this.label103.TabIndex = 4;
            this.label103.Text = "Firmware Ver:";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(19, 221);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(69, 20);
            this.label102.TabIndex = 3;
            this.label102.Text = "Client ID:";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(19, 131);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(102, 20);
            this.label101.TabIndex = 2;
            this.label101.Text = "Hardware Ver:";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(19, 85);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(62, 20);
            this.label100.TabIndex = 1;
            this.label100.Text = "App. ID:";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(19, 41);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(104, 20);
            this.label99.TabIndex = 0;
            this.label99.Text = "Device Model:";
            // 
            // tabModbusReg
            // 
            this.tabModbusReg.Controls.Add(dtConfig);
            this.tabModbusReg.Controls.Add(this.groupBox24);
            this.tabModbusReg.Location = new System.Drawing.Point(4, 29);
            this.tabModbusReg.Name = "tabModbusReg";
            this.tabModbusReg.Padding = new System.Windows.Forms.Padding(3);
            this.tabModbusReg.Size = new System.Drawing.Size(1428, 671);
            this.tabModbusReg.TabIndex = 6;
            this.tabModbusReg.Text = "Modbus Reg.";
            this.tabModbusReg.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox24.Controls.Add(this.btnClone);
            this.groupBox24.Controls.Add(this.btnDelete);
            this.groupBox24.Controls.Add(this.btnInsert);
            this.groupBox24.Controls.Add(this.btnEdit);
            this.groupBox24.Controls.Add(this.btnAdd);
            this.groupBox24.Controls.Add(this.label98);
            this.groupBox24.Controls.Add(this.txtConfigName);
            this.groupBox24.Controls.Add(this.label97);
            this.groupBox24.Location = new System.Drawing.Point(8, 7);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(1414, 85);
            this.groupBox24.TabIndex = 0;
            this.groupBox24.TabStop = false;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(1291, 28);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(94, 29);
            this.btnClone.TabIndex = 7;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1169, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1049, 28);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(920, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(795, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(397, 27);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(84, 20);
            this.label98.TabIndex = 2;
            this.label98.Text = "DB Ver : 1.0";
            // 
            // txtConfigName
            // 
            this.txtConfigName.Location = new System.Drawing.Point(117, 27);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.Size = new System.Drawing.Size(264, 27);
            this.txtConfigName.TabIndex = 1;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(17, 27);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(93, 20);
            this.label97.TabIndex = 0;
            this.label97.Text = "ConfigName";
            // 
            // tabModBusCfg
            // 
            this.tabModBusCfg.Controls.Add(this.groupBox21);
            this.tabModBusCfg.Controls.Add(this.groupBox20);
            this.tabModBusCfg.Controls.Add(this.groupBox19);
            this.tabModBusCfg.Location = new System.Drawing.Point(4, 29);
            this.tabModBusCfg.Name = "tabModBusCfg";
            this.tabModBusCfg.Padding = new System.Windows.Forms.Padding(3);
            this.tabModBusCfg.Size = new System.Drawing.Size(1428, 671);
            this.tabModBusCfg.TabIndex = 5;
            this.tabModBusCfg.Text = "ModbusCfg";
            this.tabModBusCfg.UseVisualStyleBackColor = true;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.groupBox22);
            this.groupBox21.Controls.Add(this.label87);
            this.groupBox21.Controls.Add(this.label86);
            this.groupBox21.Controls.Add(this.txtPollInterval);
            this.groupBox21.Controls.Add(this.cmbOnBoardIOEvent);
            this.groupBox21.Controls.Add(this.cmbLogEvent);
            this.groupBox21.Controls.Add(this.cmbDataFormat);
            this.groupBox21.Controls.Add(this.cmbMode);
            this.groupBox21.Controls.Add(this.label85);
            this.groupBox21.Controls.Add(this.label84);
            this.groupBox21.Controls.Add(this.label83);
            this.groupBox21.Controls.Add(this.label82);
            this.groupBox21.Controls.Add(this.label81);
            this.groupBox21.Location = new System.Drawing.Point(613, 7);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(819, 456);
            this.groupBox21.TabIndex = 2;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Modbus";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.txtLogInterval1);
            this.groupBox22.Location = new System.Drawing.Point(10, 252);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(792, 125);
            this.groupBox22.TabIndex = 13;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Log Interval (Sec)";
            // 
            // txtLogInterval1
            // 
            this.txtLogInterval1.Location = new System.Drawing.Point(243, 42);
            this.txtLogInterval1.Name = "txtLogInterval1";
            this.txtLogInterval1.Size = new System.Drawing.Size(250, 27);
            this.txtLogInterval1.TabIndex = 0;
            this.txtLogInterval1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogInterval1_KeyPress);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(515, 214);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(235, 20);
            this.label87.TabIndex = 12;
            this.label87.Text = "(IO Event Send in Modbus Packet) ";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(515, 168);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(63, 20);
            this.label86.TabIndex = 11;
            this.label86.Text = "x 100ms";
            // 
            // txtPollInterval
            // 
            this.txtPollInterval.Enabled = false;
            this.txtPollInterval.Location = new System.Drawing.Point(253, 165);
            this.txtPollInterval.Name = "txtPollInterval";
            this.txtPollInterval.Size = new System.Drawing.Size(246, 27);
            this.txtPollInterval.TabIndex = 10;
            // 
            // cmbOnBoardIOEvent
            // 
            this.cmbOnBoardIOEvent.FormattingEnabled = true;
            this.cmbOnBoardIOEvent.Items.AddRange(new object[] {
            "Disable"});
            this.cmbOnBoardIOEvent.Location = new System.Drawing.Point(253, 211);
            this.cmbOnBoardIOEvent.Name = "cmbOnBoardIOEvent";
            this.cmbOnBoardIOEvent.Size = new System.Drawing.Size(246, 28);
            this.cmbOnBoardIOEvent.TabIndex = 9;
            // 
            // cmbLogEvent
            // 
            this.cmbLogEvent.FormattingEnabled = true;
            this.cmbLogEvent.Items.AddRange(new object[] {
            "Slave ID based Event"});
            this.cmbLogEvent.Location = new System.Drawing.Point(253, 120);
            this.cmbLogEvent.Name = "cmbLogEvent";
            this.cmbLogEvent.Size = new System.Drawing.Size(246, 28);
            this.cmbLogEvent.TabIndex = 8;
            // 
            // cmbDataFormat
            // 
            this.cmbDataFormat.FormattingEnabled = true;
            this.cmbDataFormat.Items.AddRange(new object[] {
            "Formatted ASCII Data"});
            this.cmbDataFormat.Location = new System.Drawing.Point(253, 71);
            this.cmbDataFormat.Name = "cmbDataFormat";
            this.cmbDataFormat.Size = new System.Drawing.Size(246, 28);
            this.cmbDataFormat.TabIndex = 7;
            // 
            // cmbMode
            // 
            this.cmbMode.Enabled = false;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Modbus Polling"});
            this.cmbMode.Location = new System.Drawing.Point(253, 24);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(246, 28);
            this.cmbMode.TabIndex = 5;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(10, 214);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(221, 20);
            this.label85.TabIndex = 4;
            this.label85.Text = "On board IO Event Send Interval";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(7, 74);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(113, 20);
            this.label84.TabIndex = 3;
            this.label84.Text = "Data Format Tx.";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(10, 123);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(95, 20);
            this.label83.TabIndex = 2;
            this.label83.Text = "Log Event Tx.";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(10, 168);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(86, 20);
            this.label82.TabIndex = 1;
            this.label82.Text = "Poll Interval";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(7, 27);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(48, 20);
            this.label81.TabIndex = 0;
            this.label81.Text = "Mode";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.cmbRetryCount);
            this.groupBox20.Controls.Add(this.txtInterCharDelay);
            this.groupBox20.Controls.Add(this.txtInterPollDelay);
            this.groupBox20.Controls.Add(this.txtReplyTimeOut);
            this.groupBox20.Controls.Add(this.label80);
            this.groupBox20.Controls.Add(this.label79);
            this.groupBox20.Controls.Add(this.label78);
            this.groupBox20.Controls.Add(this.label77);
            this.groupBox20.Location = new System.Drawing.Point(8, 218);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(599, 245);
            this.groupBox20.TabIndex = 1;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Poll Timing";
            // 
            // cmbRetryCount
            // 
            this.cmbRetryCount.FormattingEnabled = true;
            this.cmbRetryCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRetryCount.Location = new System.Drawing.Point(164, 138);
            this.cmbRetryCount.Name = "cmbRetryCount";
            this.cmbRetryCount.Size = new System.Drawing.Size(307, 28);
            this.cmbRetryCount.TabIndex = 8;
            // 
            // txtInterCharDelay
            // 
            this.txtInterCharDelay.Location = new System.Drawing.Point(164, 190);
            this.txtInterCharDelay.Name = "txtInterCharDelay";
            this.txtInterCharDelay.Size = new System.Drawing.Size(307, 27);
            this.txtInterCharDelay.TabIndex = 7;
            // 
            // txtInterPollDelay
            // 
            this.txtInterPollDelay.Location = new System.Drawing.Point(164, 80);
            this.txtInterPollDelay.Name = "txtInterPollDelay";
            this.txtInterPollDelay.Size = new System.Drawing.Size(307, 27);
            this.txtInterPollDelay.TabIndex = 6;
            // 
            // txtReplyTimeOut
            // 
            this.txtReplyTimeOut.Location = new System.Drawing.Point(164, 26);
            this.txtReplyTimeOut.Name = "txtReplyTimeOut";
            this.txtReplyTimeOut.Size = new System.Drawing.Size(307, 27);
            this.txtReplyTimeOut.TabIndex = 5;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(7, 193);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(115, 20);
            this.label80.TabIndex = 4;
            this.label80.Text = "Inter Char Delay";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(6, 141);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(86, 20);
            this.label79.TabIndex = 3;
            this.label79.Text = "Retry Count";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(7, 83);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(109, 20);
            this.label78.TabIndex = 2;
            this.label78.Text = "Inter Poll Delay";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(7, 39);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(105, 20);
            this.label77.TabIndex = 1;
            this.label77.Text = "Reply Timeout";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.cmbConnectionType);
            this.groupBox19.Controls.Add(this.cmbBaudRate);
            this.groupBox19.Controls.Add(this.cmbPort);
            this.groupBox19.Controls.Add(this.label74);
            this.groupBox19.Controls.Add(this.label73);
            this.groupBox19.Controls.Add(this.label72);
            this.groupBox19.Location = new System.Drawing.Point(8, 7);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(599, 205);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "RS485 Com";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "SERIAL_5N1",
            "SERIAL_6N1",
            "SERIAL_7N1",
            "SERIAL_8N1",
            "SERIAL_5N2",
            "SERIAL_6N2",
            "SERIAL_7N2",
            "SERIAL_8N2",
            "SERIAL_5E1",
            "SERIAL_6E1",
            "SERIAL_7E1",
            "SERIAL_8E1",
            "SERIAL_5E2",
            "SERIAL_6E2",
            "SERIAL_7E2",
            "SERIAL_8E2",
            "SERIAL_5O1",
            "SERIAL_6O1",
            "SERIAL_7O1",
            "SERIAL_8O1",
            "SERIAL_5O2",
            "SERIAL_6O2",
            "SERIAL_7O2",
            "SERIAL_8O2"});
            this.cmbConnectionType.Location = new System.Drawing.Point(164, 123);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(307, 28);
            this.cmbConnectionType.TabIndex = 7;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(164, 74);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(307, 28);
            this.cmbBaudRate.TabIndex = 6;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "RS485"});
            this.cmbPort.Location = new System.Drawing.Point(164, 26);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(307, 28);
            this.cmbPort.TabIndex = 5;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(7, 131);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(119, 20);
            this.label74.TabIndex = 2;
            this.label74.Text = "Connection Type";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(7, 74);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(77, 20);
            this.label73.TabIndex = 1;
            this.label73.Text = "Baud Rate";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(7, 35);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(35, 20);
            this.label72.TabIndex = 0;
            this.label72.Text = "Port";
            // 
            // tabMQTT
            // 
            this.tabMQTT.Controls.Add(this.groupBox18);
            this.tabMQTT.Controls.Add(this.groupBox17);
            this.tabMQTT.Location = new System.Drawing.Point(4, 29);
            this.tabMQTT.Name = "tabMQTT";
            this.tabMQTT.Padding = new System.Windows.Forms.Padding(3);
            this.tabMQTT.Size = new System.Drawing.Size(1428, 671);
            this.tabMQTT.TabIndex = 4;
            this.tabMQTT.Text = "MQTT";
            this.tabMQTT.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtSubscribeCmd);
            this.groupBox18.Controls.Add(this.txtPublishCMDReply);
            this.groupBox18.Controls.Add(this.txtPublishEvent);
            this.groupBox18.Controls.Add(this.label71);
            this.groupBox18.Controls.Add(this.label70);
            this.groupBox18.Controls.Add(this.label69);
            this.groupBox18.Location = new System.Drawing.Point(8, 366);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1428, 210);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Topics";
            // 
            // txtSubscribeCmd
            // 
            this.txtSubscribeCmd.Location = new System.Drawing.Point(182, 138);
            this.txtSubscribeCmd.Name = "txtSubscribeCmd";
            this.txtSubscribeCmd.Size = new System.Drawing.Size(685, 27);
            this.txtSubscribeCmd.TabIndex = 5;
            // 
            // txtPublishCMDReply
            // 
            this.txtPublishCMDReply.Location = new System.Drawing.Point(182, 90);
            this.txtPublishCMDReply.Name = "txtPublishCMDReply";
            this.txtPublishCMDReply.Size = new System.Drawing.Size(685, 27);
            this.txtPublishCMDReply.TabIndex = 4;
            // 
            // txtPublishEvent
            // 
            this.txtPublishEvent.Location = new System.Drawing.Point(182, 39);
            this.txtPublishEvent.Name = "txtPublishEvent";
            this.txtPublishEvent.Size = new System.Drawing.Size(685, 27);
            this.txtPublishEvent.TabIndex = 3;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(17, 141);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(108, 20);
            this.label71.TabIndex = 2;
            this.label71.Text = "Subscribe Cmd";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(17, 93);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(134, 20);
            this.label70.TabIndex = 1;
            this.label70.Text = "Publish CMD Reply";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(17, 42);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(96, 20);
            this.label69.TabIndex = 0;
            this.label69.Text = "Publish Event";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btnMQTTShowPass);
            this.groupBox17.Controls.Add(this.cmbQosLevel);
            this.groupBox17.Controls.Add(this.label62);
            this.groupBox17.Controls.Add(this.chkAuthEnable);
            this.groupBox17.Controls.Add(this.txtMQTTPassword);
            this.groupBox17.Controls.Add(this.txtMQTTUserName);
            this.groupBox17.Controls.Add(this.txtClientId);
            this.groupBox17.Controls.Add(this.txtBrokerPort);
            this.groupBox17.Controls.Add(this.txtBrokerIPDomain);
            this.groupBox17.Controls.Add(this.label68);
            this.groupBox17.Controls.Add(this.label67);
            this.groupBox17.Controls.Add(this.label66);
            this.groupBox17.Controls.Add(this.label65);
            this.groupBox17.Controls.Add(this.label64);
            this.groupBox17.Controls.Add(this.label63);
            this.groupBox17.Controls.Add(this.label61);
            this.groupBox17.Location = new System.Drawing.Point(8, 7);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1424, 353);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Broker Sett.";
            // 
            // btnMQTTShowPass
            // 
            this.btnMQTTShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMQTTShowPass.BackgroundImage")));
            this.btnMQTTShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMQTTShowPass.Location = new System.Drawing.Point(561, 292);
            this.btnMQTTShowPass.Name = "btnMQTTShowPass";
            this.btnMQTTShowPass.Size = new System.Drawing.Size(28, 27);
            this.btnMQTTShowPass.TabIndex = 16;
            this.btnMQTTShowPass.UseVisualStyleBackColor = true;
            this.btnMQTTShowPass.Click += new System.EventHandler(this.btnMQTTShowPass_Click);
            // 
            // cmbQosLevel
            // 
            this.cmbQosLevel.FormattingEnabled = true;
            this.cmbQosLevel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbQosLevel.Location = new System.Drawing.Point(880, 35);
            this.cmbQosLevel.Name = "cmbQosLevel";
            this.cmbQosLevel.Size = new System.Drawing.Size(113, 28);
            this.cmbQosLevel.TabIndex = 15;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(773, 38);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(77, 20);
            this.label62.TabIndex = 14;
            this.label62.Text = "QOS Level";
            // 
            // chkAuthEnable
            // 
            this.chkAuthEnable.AutoSize = true;
            this.chkAuthEnable.Location = new System.Drawing.Point(182, 187);
            this.chkAuthEnable.Name = "chkAuthEnable";
            this.chkAuthEnable.Size = new System.Drawing.Size(18, 17);
            this.chkAuthEnable.TabIndex = 13;
            this.chkAuthEnable.UseVisualStyleBackColor = true;
            // 
            // txtMQTTPassword
            // 
            this.txtMQTTPassword.Location = new System.Drawing.Point(182, 291);
            this.txtMQTTPassword.Name = "txtMQTTPassword";
            this.txtMQTTPassword.Size = new System.Drawing.Size(373, 27);
            this.txtMQTTPassword.TabIndex = 12;
            this.txtMQTTPassword.UseSystemPasswordChar = true;
            // 
            // txtMQTTUserName
            // 
            this.txtMQTTUserName.Location = new System.Drawing.Point(182, 237);
            this.txtMQTTUserName.Name = "txtMQTTUserName";
            this.txtMQTTUserName.Size = new System.Drawing.Size(373, 27);
            this.txtMQTTUserName.TabIndex = 11;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(182, 132);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(373, 27);
            this.txtClientId.TabIndex = 10;
            // 
            // txtBrokerPort
            // 
            this.txtBrokerPort.Location = new System.Drawing.Point(182, 83);
            this.txtBrokerPort.Name = "txtBrokerPort";
            this.txtBrokerPort.Size = new System.Drawing.Size(373, 27);
            this.txtBrokerPort.TabIndex = 9;
            this.txtBrokerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrokerPort_KeyPress);
            // 
            // txtBrokerIPDomain
            // 
            this.txtBrokerIPDomain.Location = new System.Drawing.Point(182, 35);
            this.txtBrokerIPDomain.Name = "txtBrokerIPDomain";
            this.txtBrokerIPDomain.Size = new System.Drawing.Size(566, 27);
            this.txtBrokerIPDomain.TabIndex = 8;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(773, 86);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(149, 20);
            this.label68.TabIndex = 7;
            this.label68.Text = "do Sett. in IP Sett Tab";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(17, 294);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(70, 20);
            this.label67.TabIndex = 6;
            this.label67.Text = "Password";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(17, 244);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(82, 20);
            this.label66.TabIndex = 5;
            this.label66.Text = "User Name";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(17, 187);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(92, 20);
            this.label65.TabIndex = 4;
            this.label65.Text = "Auth. Enable";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(17, 135);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(66, 20);
            this.label64.TabIndex = 3;
            this.label64.Text = "Client ID";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(17, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(82, 20);
            this.label63.TabIndex = 2;
            this.label63.Text = "Broker Port";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(17, 38);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(127, 20);
            this.label61.TabIndex = 0;
            this.label61.Text = "Broker IP/Domain";
            // 
            // tabDevice
            // 
            this.tabDevice.Controls.Add(this.groupBox12);
            this.tabDevice.Controls.Add(this.groupBox11);
            this.tabDevice.Controls.Add(this.groupBox10);
            this.tabDevice.Controls.Add(this.groupBox9);
            this.tabDevice.Controls.Add(this.groupBox8);
            this.tabDevice.Location = new System.Drawing.Point(4, 29);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevice.Size = new System.Drawing.Size(1428, 671);
            this.tabDevice.TabIndex = 2;
            this.tabDevice.Text = "Device";
            this.tabDevice.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtMobLocationCode);
            this.groupBox12.Controls.Add(this.btnSMSSend);
            this.groupBox12.Controls.Add(this.txtMobileNo);
            this.groupBox12.Controls.Add(this.label45);
            this.groupBox12.Controls.Add(this.txtTestMessage);
            this.groupBox12.Controls.Add(this.label44);
            this.groupBox12.Location = new System.Drawing.Point(727, 385);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(698, 200);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "SMS Test";
            // 
            // txtMobLocationCode
            // 
            this.txtMobLocationCode.Enabled = false;
            this.txtMobLocationCode.Location = new System.Drawing.Point(124, 158);
            this.txtMobLocationCode.Name = "txtMobLocationCode";
            this.txtMobLocationCode.Size = new System.Drawing.Size(46, 27);
            this.txtMobLocationCode.TabIndex = 5;
            this.txtMobLocationCode.Text = "+91";
            // 
            // btnSMSSend
            // 
            this.btnSMSSend.Location = new System.Drawing.Point(484, 156);
            this.btnSMSSend.Name = "btnSMSSend";
            this.btnSMSSend.Size = new System.Drawing.Size(94, 29);
            this.btnSMSSend.TabIndex = 4;
            this.btnSMSSend.Text = "SMS Send";
            this.btnSMSSend.UseVisualStyleBackColor = true;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(187, 158);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(283, 27);
            this.txtMobileNo.TabIndex = 3;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(21, 161);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 20);
            this.label45.TabIndex = 2;
            this.label45.Text = "Mobile No.";
            // 
            // txtTestMessage
            // 
            this.txtTestMessage.Location = new System.Drawing.Point(21, 45);
            this.txtTestMessage.Multiline = true;
            this.txtTestMessage.Name = "txtTestMessage";
            this.txtTestMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTestMessage.Size = new System.Drawing.Size(665, 91);
            this.txtTestMessage.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(21, 23);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(97, 20);
            this.label44.TabIndex = 0;
            this.label44.Text = "Test Message";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cmbEventTimeFormat);
            this.groupBox11.Controls.Add(this.label43);
            this.groupBox11.Controls.Add(this.txtTimeSyncFrom);
            this.groupBox11.Controls.Add(this.cmbTimeSyncFrom);
            this.groupBox11.Controls.Add(this.label42);
            this.groupBox11.Controls.Add(this.label41);
            this.groupBox11.Controls.Add(this.label40);
            this.groupBox11.Controls.Add(this.txtEventHeaderThird);
            this.groupBox11.Controls.Add(this.txtEventHeaderSecond);
            this.groupBox11.Controls.Add(this.txtEventHeaderFirst);
            this.groupBox11.Controls.Add(this.cmbGMTMin);
            this.groupBox11.Controls.Add(this.cmbGMTHour);
            this.groupBox11.Controls.Add(this.cmbGMTPlusMinus);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Controls.Add(this.label39);
            this.groupBox11.Location = new System.Drawing.Point(727, 105);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(705, 284);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Custom Sett.";
            // 
            // cmbEventTimeFormat
            // 
            this.cmbEventTimeFormat.Enabled = false;
            this.cmbEventTimeFormat.FormattingEnabled = true;
            this.cmbEventTimeFormat.Location = new System.Drawing.Point(187, 192);
            this.cmbEventTimeFormat.Name = "cmbEventTimeFormat";
            this.cmbEventTimeFormat.Size = new System.Drawing.Size(173, 28);
            this.cmbEventTimeFormat.TabIndex = 22;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(457, 137);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(121, 20);
            this.label43.TabIndex = 21;
            this.label43.Text = "Difference In Sec";
            // 
            // txtTimeSyncFrom
            // 
            this.txtTimeSyncFrom.Enabled = false;
            this.txtTimeSyncFrom.Location = new System.Drawing.Point(379, 134);
            this.txtTimeSyncFrom.Name = "txtTimeSyncFrom";
            this.txtTimeSyncFrom.Size = new System.Drawing.Size(64, 27);
            this.txtTimeSyncFrom.TabIndex = 20;
            this.txtTimeSyncFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeSyncFrom_KeyPress);
            // 
            // cmbTimeSyncFrom
            // 
            this.cmbTimeSyncFrom.Enabled = false;
            this.cmbTimeSyncFrom.FormattingEnabled = true;
            this.cmbTimeSyncFrom.Location = new System.Drawing.Point(187, 134);
            this.cmbTimeSyncFrom.Name = "cmbTimeSyncFrom";
            this.cmbTimeSyncFrom.Size = new System.Drawing.Size(173, 28);
            this.cmbTimeSyncFrom.TabIndex = 19;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(464, 108);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 20);
            this.label42.TabIndex = 18;
            this.label42.Text = "System";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(350, 108);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(24, 20);
            this.label41.TabIndex = 17;
            this.label41.Text = "IO";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(198, 108);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(63, 20);
            this.label40.TabIndex = 16;
            this.label40.Text = "Modbus";
            // 
            // txtEventHeaderThird
            // 
            this.txtEventHeaderThird.Enabled = false;
            this.txtEventHeaderThird.Location = new System.Drawing.Point(449, 75);
            this.txtEventHeaderThird.Name = "txtEventHeaderThird";
            this.txtEventHeaderThird.Size = new System.Drawing.Size(87, 27);
            this.txtEventHeaderThird.TabIndex = 15;
            this.txtEventHeaderThird.Text = "$WTSYS";
            // 
            // txtEventHeaderSecond
            // 
            this.txtEventHeaderSecond.Enabled = false;
            this.txtEventHeaderSecond.Location = new System.Drawing.Point(318, 75);
            this.txtEventHeaderSecond.Name = "txtEventHeaderSecond";
            this.txtEventHeaderSecond.Size = new System.Drawing.Size(85, 27);
            this.txtEventHeaderSecond.TabIndex = 14;
            this.txtEventHeaderSecond.Text = "$WTIO";
            // 
            // txtEventHeaderFirst
            // 
            this.txtEventHeaderFirst.Enabled = false;
            this.txtEventHeaderFirst.Location = new System.Drawing.Point(187, 75);
            this.txtEventHeaderFirst.Name = "txtEventHeaderFirst";
            this.txtEventHeaderFirst.Size = new System.Drawing.Size(87, 27);
            this.txtEventHeaderFirst.TabIndex = 13;
            this.txtEventHeaderFirst.Text = "$WMBUS";
            // 
            // cmbGMTMin
            // 
            this.cmbGMTMin.FormattingEnabled = true;
            this.cmbGMTMin.Items.AddRange(new object[] {
            "00",
            "30",
            "45"});
            this.cmbGMTMin.Location = new System.Drawing.Point(449, 29);
            this.cmbGMTMin.Name = "cmbGMTMin";
            this.cmbGMTMin.Size = new System.Drawing.Size(87, 28);
            this.cmbGMTMin.TabIndex = 12;
            // 
            // cmbGMTHour
            // 
            this.cmbGMTHour.FormattingEnabled = true;
            this.cmbGMTHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.cmbGMTHour.Location = new System.Drawing.Point(316, 29);
            this.cmbGMTHour.Name = "cmbGMTHour";
            this.cmbGMTHour.Size = new System.Drawing.Size(87, 28);
            this.cmbGMTHour.TabIndex = 11;
            // 
            // cmbGMTPlusMinus
            // 
            this.cmbGMTPlusMinus.FormattingEnabled = true;
            this.cmbGMTPlusMinus.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbGMTPlusMinus.Location = new System.Drawing.Point(187, 29);
            this.cmbGMTPlusMinus.Name = "cmbGMTPlusMinus";
            this.cmbGMTPlusMinus.Size = new System.Drawing.Size(87, 28);
            this.cmbGMTPlusMinus.TabIndex = 10;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 235);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(149, 20);
            this.label35.TabIndex = 9;
            this.label35.Text = "SMS Tx Limit per Day";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(21, 195);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(133, 20);
            this.label36.TabIndex = 8;
            this.label36.Text = "Event Time Format";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(21, 134);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 20);
            this.label37.TabIndex = 7;
            this.label37.Text = "Time Sync From";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(21, 82);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(98, 20);
            this.label38.TabIndex = 6;
            this.label38.Text = "Event Header";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(21, 37);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 20);
            this.label39.TabIndex = 5;
            this.label39.Text = "GMT";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtPhoneNo2);
            this.groupBox10.Controls.Add(this.txtPhoneNo3);
            this.groupBox10.Controls.Add(this.txtPhoneNo1);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Location = new System.Drawing.Point(9, 366);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(713, 173);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Config/SMS Alert Phone No\'s";
            // 
            // txtPhoneNo2
            // 
            this.txtPhoneNo2.Location = new System.Drawing.Point(288, 75);
            this.txtPhoneNo2.MaxLength = 10;
            this.txtPhoneNo2.Name = "txtPhoneNo2";
            this.txtPhoneNo2.Size = new System.Drawing.Size(415, 27);
            this.txtPhoneNo2.TabIndex = 15;
            this.txtPhoneNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo2_KeyPress);
            // 
            // txtPhoneNo3
            // 
            this.txtPhoneNo3.Location = new System.Drawing.Point(288, 123);
            this.txtPhoneNo3.MaxLength = 10;
            this.txtPhoneNo3.Name = "txtPhoneNo3";
            this.txtPhoneNo3.Size = new System.Drawing.Size(415, 27);
            this.txtPhoneNo3.TabIndex = 14;
            this.txtPhoneNo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo3_KeyPress);
            // 
            // txtPhoneNo1
            // 
            this.txtPhoneNo1.Location = new System.Drawing.Point(288, 31);
            this.txtPhoneNo1.MaxLength = 10;
            this.txtPhoneNo1.Name = "txtPhoneNo1";
            this.txtPhoneNo1.Size = new System.Drawing.Size(415, 27);
            this.txtPhoneNo1.TabIndex = 13;
            this.txtPhoneNo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo1_KeyPress);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(15, 126);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 20);
            this.label32.TabIndex = 12;
            this.label32.Text = "Phone No. 3";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(15, 78);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 20);
            this.label33.TabIndex = 11;
            this.label33.Text = "Phone No. 2";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 34);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(89, 20);
            this.label34.TabIndex = 10;
            this.label34.Text = "Phone No. 1";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnDevicePassShow);
            this.groupBox9.Controls.Add(this.txtDeviceName);
            this.groupBox9.Controls.Add(this.txtDevicePassword);
            this.groupBox9.Controls.Add(this.txtDeviceID);
            this.groupBox9.Controls.Add(this.chkRemoteConfigSecuredPhNos);
            this.groupBox9.Controls.Add(this.chkSMSEnable);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.label30);
            this.groupBox9.Controls.Add(this.label29);
            this.groupBox9.Controls.Add(this.label28);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Location = new System.Drawing.Point(8, 105);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(713, 255);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Device";
            // 
            // btnDevicePassShow
            // 
            this.btnDevicePassShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevicePassShow.BackgroundImage")));
            this.btnDevicePassShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevicePassShow.Location = new System.Drawing.Point(676, 127);
            this.btnDevicePassShow.Name = "btnDevicePassShow";
            this.btnDevicePassShow.Size = new System.Drawing.Size(28, 27);
            this.btnDevicePassShow.TabIndex = 10;
            this.btnDevicePassShow.UseVisualStyleBackColor = true;
            this.btnDevicePassShow.Click += new System.EventHandler(this.btnDevicePassShow_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(289, 75);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(415, 27);
            this.txtDeviceName.TabIndex = 9;
            // 
            // txtDevicePassword
            // 
            this.txtDevicePassword.Location = new System.Drawing.Point(289, 127);
            this.txtDevicePassword.Name = "txtDevicePassword";
            this.txtDevicePassword.Size = new System.Drawing.Size(381, 27);
            this.txtDevicePassword.TabIndex = 8;
            this.txtDevicePassword.UseSystemPasswordChar = true;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(289, 26);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(415, 27);
            this.txtDeviceID.TabIndex = 7;
            // 
            // chkRemoteConfigSecuredPhNos
            // 
            this.chkRemoteConfigSecuredPhNos.AutoSize = true;
            this.chkRemoteConfigSecuredPhNos.Location = new System.Drawing.Point(285, 217);
            this.chkRemoteConfigSecuredPhNos.Name = "chkRemoteConfigSecuredPhNos";
            this.chkRemoteConfigSecuredPhNos.Size = new System.Drawing.Size(18, 17);
            this.chkRemoteConfigSecuredPhNos.TabIndex = 6;
            this.chkRemoteConfigSecuredPhNos.UseVisualStyleBackColor = true;
            // 
            // chkSMSEnable
            // 
            this.chkSMSEnable.AutoSize = true;
            this.chkSMSEnable.Location = new System.Drawing.Point(285, 175);
            this.chkSMSEnable.Name = "chkSMSEnable";
            this.chkSMSEnable.Size = new System.Drawing.Size(18, 17);
            this.chkSMSEnable.TabIndex = 5;
            this.chkSMSEnable.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 217);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(212, 20);
            this.label31.TabIndex = 4;
            this.label31.Text = "Remote Config Secured PhNos";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 175);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 20);
            this.label30.TabIndex = 3;
            this.label30.Text = "SMS Enable";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 130);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 20);
            this.label29.TabIndex = 2;
            this.label29.Text = "Device Password";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 78);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(98, 20);
            this.label28.TabIndex = 1;
            this.label28.Text = "Device Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(73, 20);
            this.label27.TabIndex = 0;
            this.label27.Text = "Device ID";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox8.Controls.Add(this.btnFactoryDefault);
            this.groupBox8.Controls.Add(this.btnModbusDBClear);
            this.groupBox8.Controls.Add(this.btnReset);
            this.groupBox8.Controls.Add(this.btnRTCTimeSet);
            this.groupBox8.Controls.Add(this.btnLogClear);
            this.groupBox8.Location = new System.Drawing.Point(8, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1417, 91);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "System";
            // 
            // btnFactoryDefault
            // 
            this.btnFactoryDefault.Location = new System.Drawing.Point(740, 36);
            this.btnFactoryDefault.Name = "btnFactoryDefault";
            this.btnFactoryDefault.Size = new System.Drawing.Size(174, 29);
            this.btnFactoryDefault.TabIndex = 4;
            this.btnFactoryDefault.Text = "Factory Default";
            this.btnFactoryDefault.UseVisualStyleBackColor = true;
            // 
            // btnModbusDBClear
            // 
            this.btnModbusDBClear.Location = new System.Drawing.Point(519, 36);
            this.btnModbusDBClear.Name = "btnModbusDBClear";
            this.btnModbusDBClear.Size = new System.Drawing.Size(167, 29);
            this.btnModbusDBClear.TabIndex = 3;
            this.btnModbusDBClear.Text = "Modbus DB. Clear";
            this.btnModbusDBClear.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(349, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnRTCTimeSet
            // 
            this.btnRTCTimeSet.Location = new System.Drawing.Point(178, 36);
            this.btnRTCTimeSet.Name = "btnRTCTimeSet";
            this.btnRTCTimeSet.Size = new System.Drawing.Size(116, 29);
            this.btnRTCTimeSet.TabIndex = 1;
            this.btnRTCTimeSet.Text = "RTC TimeSet";
            this.btnRTCTimeSet.UseVisualStyleBackColor = true;
            // 
            // btnLogClear
            // 
            this.btnLogClear.Location = new System.Drawing.Point(37, 36);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(94, 29);
            this.btnLogClear.TabIndex = 0;
            this.btnLogClear.Text = "Log Clear";
            this.btnLogClear.UseVisualStyleBackColor = true;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.groupBox7);
            this.tabConnection.Controls.Add(this.groupBox6);
            this.tabConnection.Controls.Add(this.groupBox5);
            this.tabConnection.Location = new System.Drawing.Point(4, 29);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(1428, 671);
            this.tabConnection.TabIndex = 1;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbFlashDataLogging);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Location = new System.Drawing.Point(711, 395);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(725, 225);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Logger/Event Tx";
            // 
            // cmbFlashDataLogging
            // 
            this.cmbFlashDataLogging.FormattingEnabled = true;
            this.cmbFlashDataLogging.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.cmbFlashDataLogging.Location = new System.Drawing.Point(214, 79);
            this.cmbFlashDataLogging.Name = "cmbFlashDataLogging";
            this.cmbFlashDataLogging.Size = new System.Drawing.Size(317, 28);
            this.cmbFlashDataLogging.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(27, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 20);
            this.label26.TabIndex = 11;
            this.label26.Text = "Flash Data Logging";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.txtAPIAccessKey);
            this.groupBox6.Controls.Add(this.cmbSelectAPIKeyAddIn);
            this.groupBox6.Controls.Add(this.cmbSelectEventFormat);
            this.groupBox6.Controls.Add(this.cmbSelectHttpMethod);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Location = new System.Drawing.Point(711, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(721, 372);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Event Setting";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(214, 191);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(214, 20);
            this.label25.TabIndex = 16;
            this.label25.Text = "(use \' quote instead of \" quote)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(214, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(364, 20);
            this.label24.TabIndex = 15;
            this.label24.Text = "Post hdr ( Param : Value ) / Json Event ( \'Param\':\'Value\')";
            // 
            // txtAPIAccessKey
            // 
            this.txtAPIAccessKey.Location = new System.Drawing.Point(214, 122);
            this.txtAPIAccessKey.Name = "txtAPIAccessKey";
            this.txtAPIAccessKey.Size = new System.Drawing.Size(459, 27);
            this.txtAPIAccessKey.TabIndex = 14;
            // 
            // cmbSelectAPIKeyAddIn
            // 
            this.cmbSelectAPIKeyAddIn.Enabled = false;
            this.cmbSelectAPIKeyAddIn.FormattingEnabled = true;
            this.cmbSelectAPIKeyAddIn.Location = new System.Drawing.Point(214, 217);
            this.cmbSelectAPIKeyAddIn.Name = "cmbSelectAPIKeyAddIn";
            this.cmbSelectAPIKeyAddIn.Size = new System.Drawing.Size(317, 28);
            this.cmbSelectAPIKeyAddIn.TabIndex = 10;
            // 
            // cmbSelectEventFormat
            // 
            this.cmbSelectEventFormat.FormattingEnabled = true;
            this.cmbSelectEventFormat.Items.AddRange(new object[] {
            "JSON Format std"});
            this.cmbSelectEventFormat.Location = new System.Drawing.Point(214, 74);
            this.cmbSelectEventFormat.Name = "cmbSelectEventFormat";
            this.cmbSelectEventFormat.Size = new System.Drawing.Size(317, 28);
            this.cmbSelectEventFormat.TabIndex = 9;
            // 
            // cmbSelectHttpMethod
            // 
            this.cmbSelectHttpMethod.FormattingEnabled = true;
            this.cmbSelectHttpMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.cmbSelectHttpMethod.Location = new System.Drawing.Point(214, 23);
            this.cmbSelectHttpMethod.Name = "cmbSelectHttpMethod";
            this.cmbSelectHttpMethod.Size = new System.Drawing.Size(317, 28);
            this.cmbSelectHttpMethod.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 220);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "API Key Add in";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(27, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 20);
            this.label22.TabIndex = 2;
            this.label22.Text = "API Access Key";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "Select Event Format";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Select HTTP Method";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtConnectFail);
            this.groupBox5.Controls.Add(this.txtMessage);
            this.groupBox5.Controls.Add(this.txtDuration);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.chkKeepAlive);
            this.groupBox5.Controls.Add(this.txtDeviceToServer);
            this.groupBox5.Controls.Add(this.cmbMaxRetries);
            this.groupBox5.Controls.Add(this.cmbIPConnectMode);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(7, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(697, 614);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connection Control";
            // 
            // txtConnectFail
            // 
            this.txtConnectFail.Location = new System.Drawing.Point(337, 133);
            this.txtConnectFail.Name = "txtConnectFail";
            this.txtConnectFail.Size = new System.Drawing.Size(317, 27);
            this.txtConnectFail.TabIndex = 14;
            this.txtConnectFail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConnectFail_KeyPress);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(337, 280);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(317, 27);
            this.txtMessage.TabIndex = 13;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(462, 228);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(192, 27);
            this.txtDuration.TabIndex = 12;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(389, 234);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "Duration";
            // 
            // chkKeepAlive
            // 
            this.chkKeepAlive.AutoSize = true;
            this.chkKeepAlive.Location = new System.Drawing.Point(337, 234);
            this.chkKeepAlive.Name = "chkKeepAlive";
            this.chkKeepAlive.Size = new System.Drawing.Size(18, 17);
            this.chkKeepAlive.TabIndex = 10;
            this.chkKeepAlive.UseVisualStyleBackColor = true;
            // 
            // txtDeviceToServer
            // 
            this.txtDeviceToServer.Location = new System.Drawing.Point(337, 185);
            this.txtDeviceToServer.Name = "txtDeviceToServer";
            this.txtDeviceToServer.Size = new System.Drawing.Size(317, 27);
            this.txtDeviceToServer.TabIndex = 9;
            this.txtDeviceToServer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeviceToServer_KeyPress);
            // 
            // cmbMaxRetries
            // 
            this.cmbMaxRetries.FormattingEnabled = true;
            this.cmbMaxRetries.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbMaxRetries.Location = new System.Drawing.Point(337, 85);
            this.cmbMaxRetries.Name = "cmbMaxRetries";
            this.cmbMaxRetries.Size = new System.Drawing.Size(317, 28);
            this.cmbMaxRetries.TabIndex = 7;
            // 
            // cmbIPConnectMode
            // 
            this.cmbIPConnectMode.FormattingEnabled = true;
            this.cmbIPConnectMode.Items.AddRange(new object[] {
            "Always Online"});
            this.cmbIPConnectMode.Location = new System.Drawing.Point(337, 42);
            this.cmbIPConnectMode.Name = "cmbIPConnectMode";
            this.cmbIPConnectMode.Size = new System.Drawing.Size(317, 28);
            this.cmbIPConnectMode.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 283);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 20);
            this.label18.TabIndex = 5;
            this.label18.Text = "Message";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 20);
            this.label17.TabIndex = 4;
            this.label17.Text = "Keep Alive (Secs)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(281, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Device to Server Event Push Interval (Sec)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(260, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Connect Fail Reconnect Interval (Mins)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Max Retries";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "IP Connect Mode";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabIpSett);
            this.tab.Controls.Add(this.tabConnection);
            this.tab.Controls.Add(this.tabDevice);
            this.tab.Controls.Add(this.tabMQTT);
            this.tab.Controls.Add(this.tabModBusCfg);
            this.tab.Controls.Add(this.tabModbusReg);
            this.tab.Controls.Add(this.tabStatus);
            this.tab.Controls.Add(this.tabMonitor);
            this.tab.Controls.Add(this.tabConsole);
            this.tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab.Location = new System.Drawing.Point(1, 87);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1436, 704);
            this.tab.TabIndex = 1;
            // 
            // tabIpSett
            // 
            this.tabIpSett.Controls.Add(this.groupBox4);
            this.tabIpSett.Controls.Add(this.groupBox3);
            this.tabIpSett.Controls.Add(this.groupBox2);
            this.tabIpSett.Location = new System.Drawing.Point(4, 29);
            this.tabIpSett.Name = "tabIpSett";
            this.tabIpSett.Padding = new System.Windows.Forms.Padding(3);
            this.tabIpSett.Size = new System.Drawing.Size(1428, 671);
            this.tabIpSett.TabIndex = 0;
            this.tabIpSett.Text = "IP Sett.";
            this.tabIpSett.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSSLModuleReupdate);
            this.groupBox4.Controls.Add(this.btnClientKey);
            this.groupBox4.Controls.Add(this.btnClientCertificate);
            this.groupBox4.Controls.Add(this.btnCACertificate);
            this.groupBox4.Controls.Add(this.txtClientKey);
            this.groupBox4.Controls.Add(this.txtClientCertificate);
            this.groupBox4.Controls.Add(this.txtCAServerCertificate);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(728, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(691, 283);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SSL Settings";
            // 
            // btnSSLModuleReupdate
            // 
            this.btnSSLModuleReupdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnSSLModuleReupdate.Enabled = false;
            this.btnSSLModuleReupdate.Location = new System.Drawing.Point(212, 235);
            this.btnSSLModuleReupdate.Name = "btnSSLModuleReupdate";
            this.btnSSLModuleReupdate.Size = new System.Drawing.Size(288, 29);
            this.btnSSLModuleReupdate.TabIndex = 9;
            this.btnSSLModuleReupdate.Text = "SSL Module Re-Update";
            this.btnSSLModuleReupdate.UseVisualStyleBackColor = false;
            // 
            // btnClientKey
            // 
            this.btnClientKey.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientKey.Enabled = false;
            this.btnClientKey.Location = new System.Drawing.Point(534, 164);
            this.btnClientKey.Name = "btnClientKey";
            this.btnClientKey.Size = new System.Drawing.Size(94, 29);
            this.btnClientKey.TabIndex = 8;
            this.btnClientKey.Text = "Browse";
            this.btnClientKey.UseVisualStyleBackColor = false;
            // 
            // btnClientCertificate
            // 
            this.btnClientCertificate.BackColor = System.Drawing.Color.DarkGray;
            this.btnClientCertificate.Enabled = false;
            this.btnClientCertificate.Location = new System.Drawing.Point(534, 95);
            this.btnClientCertificate.Name = "btnClientCertificate";
            this.btnClientCertificate.Size = new System.Drawing.Size(94, 29);
            this.btnClientCertificate.TabIndex = 7;
            this.btnClientCertificate.Text = "Browse";
            this.btnClientCertificate.UseVisualStyleBackColor = false;
            // 
            // btnCACertificate
            // 
            this.btnCACertificate.BackColor = System.Drawing.Color.DarkGray;
            this.btnCACertificate.Enabled = false;
            this.btnCACertificate.Location = new System.Drawing.Point(534, 29);
            this.btnCACertificate.Name = "btnCACertificate";
            this.btnCACertificate.Size = new System.Drawing.Size(94, 29);
            this.btnCACertificate.TabIndex = 6;
            this.btnCACertificate.Text = "Browse";
            this.btnCACertificate.UseVisualStyleBackColor = false;
            // 
            // txtClientKey
            // 
            this.txtClientKey.Enabled = false;
            this.txtClientKey.Location = new System.Drawing.Point(212, 163);
            this.txtClientKey.Name = "txtClientKey";
            this.txtClientKey.Size = new System.Drawing.Size(273, 27);
            this.txtClientKey.TabIndex = 5;
            // 
            // txtClientCertificate
            // 
            this.txtClientCertificate.Enabled = false;
            this.txtClientCertificate.Location = new System.Drawing.Point(212, 95);
            this.txtClientCertificate.Name = "txtClientCertificate";
            this.txtClientCertificate.Size = new System.Drawing.Size(273, 27);
            this.txtClientCertificate.TabIndex = 4;
            // 
            // txtCAServerCertificate
            // 
            this.txtCAServerCertificate.Enabled = false;
            this.txtCAServerCertificate.Location = new System.Drawing.Point(212, 32);
            this.txtCAServerCertificate.Name = "txtCAServerCertificate";
            this.txtCAServerCertificate.Size = new System.Drawing.Size(273, 27);
            this.txtCAServerCertificate.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Client Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Client Certificate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "CA Server Certificate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIPSettPassView);
            this.groupBox3.Controls.Add(this.txtIPSettPassword);
            this.groupBox3.Controls.Add(this.txtIPSettUserName);
            this.groupBox3.Controls.Add(this.txtAPN);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(18, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 226);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modem Settings";
            // 
            // btnIPSettPassView
            // 
            this.btnIPSettPassView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIPSettPassView.BackgroundImage")));
            this.btnIPSettPassView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIPSettPassView.Location = new System.Drawing.Point(538, 165);
            this.btnIPSettPassView.Name = "btnIPSettPassView";
            this.btnIPSettPassView.Size = new System.Drawing.Size(28, 27);
            this.btnIPSettPassView.TabIndex = 7;
            this.btnIPSettPassView.UseVisualStyleBackColor = true;
            this.btnIPSettPassView.Click += new System.EventHandler(this.btnIPSettPassView_Click);
            // 
            // txtIPSettPassword
            // 
            this.txtIPSettPassword.Location = new System.Drawing.Point(231, 165);
            this.txtIPSettPassword.Name = "txtIPSettPassword";
            this.txtIPSettPassword.Size = new System.Drawing.Size(300, 27);
            this.txtIPSettPassword.TabIndex = 6;
            this.txtIPSettPassword.UseSystemPasswordChar = true;
            // 
            // txtIPSettUserName
            // 
            this.txtIPSettUserName.Location = new System.Drawing.Point(231, 115);
            this.txtIPSettUserName.Name = "txtIPSettUserName";
            this.txtIPSettUserName.Size = new System.Drawing.Size(300, 27);
            this.txtIPSettUserName.TabIndex = 5;
            // 
            // txtAPN
            // 
            this.txtAPN.Location = new System.Drawing.Point(231, 66);
            this.txtAPN.Name = "txtAPN";
            this.txtAPN.Size = new System.Drawing.Size(300, 27);
            this.txtAPN.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "SIM Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "SIM User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "APN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "(Note - Applicable Only For India)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEventTransmission);
            this.groupBox2.Controls.Add(this.cmbSSLSecurityEnabled);
            this.groupBox2.Controls.Add(this.chkSSLSecurityEnable);
            this.groupBox2.Controls.Add(this.txtServerPort);
            this.groupBox2.Controls.Add(this.txtServerIPURL);
            this.groupBox2.Controls.Add(this.cmbConnectProtocol);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP Settings";
            // 
            // cmbEventTransmission
            // 
            this.cmbEventTransmission.Enabled = false;
            this.cmbEventTransmission.FormattingEnabled = true;
            this.cmbEventTransmission.Items.AddRange(new object[] {
            "GSM Only"});
            this.cmbEventTransmission.Location = new System.Drawing.Point(231, 235);
            this.cmbEventTransmission.Name = "cmbEventTransmission";
            this.cmbEventTransmission.Size = new System.Drawing.Size(302, 28);
            this.cmbEventTransmission.TabIndex = 10;
            // 
            // cmbSSLSecurityEnabled
            // 
            this.cmbSSLSecurityEnabled.FormattingEnabled = true;
            this.cmbSSLSecurityEnabled.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbSSLSecurityEnabled.Location = new System.Drawing.Point(267, 186);
            this.cmbSSLSecurityEnabled.Name = "cmbSSLSecurityEnabled";
            this.cmbSSLSecurityEnabled.Size = new System.Drawing.Size(266, 28);
            this.cmbSSLSecurityEnabled.TabIndex = 9;
            // 
            // chkSSLSecurityEnable
            // 
            this.chkSSLSecurityEnable.AutoSize = true;
            this.chkSSLSecurityEnable.Location = new System.Drawing.Point(231, 192);
            this.chkSSLSecurityEnable.Name = "chkSSLSecurityEnable";
            this.chkSSLSecurityEnable.Size = new System.Drawing.Size(18, 17);
            this.chkSSLSecurityEnable.TabIndex = 8;
            this.chkSSLSecurityEnable.UseVisualStyleBackColor = true;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(231, 140);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(228, 27);
            this.txtServerPort.TabIndex = 7;
            this.txtServerPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServerPort_KeyPress);
            // 
            // txtServerIPURL
            // 
            this.txtServerIPURL.Location = new System.Drawing.Point(231, 91);
            this.txtServerIPURL.Name = "txtServerIPURL";
            this.txtServerIPURL.Size = new System.Drawing.Size(302, 27);
            this.txtServerIPURL.TabIndex = 6;
            // 
            // cmbConnectProtocol
            // 
            this.cmbConnectProtocol.FormattingEnabled = true;
            this.cmbConnectProtocol.Items.AddRange(new object[] {
            "MQTT",
            "HTTP",
            "TCP"});
            this.cmbConnectProtocol.Location = new System.Drawing.Point(231, 39);
            this.cmbConnectProtocol.Name = "cmbConnectProtocol";
            this.cmbConnectProtocol.Size = new System.Drawing.Size(302, 28);
            this.cmbConnectProtocol.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Event Transmission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SSL Security Enable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP/URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect Protocol";
            // 
            // timerUploadDownload
            // 
            this.timerUploadDownload.Interval = 10;
            this.timerUploadDownload.Tick += new System.EventHandler(this.timerUploadDownload_Tick);
            // 
            // label46
            // 
            this.label46.Image = ((System.Drawing.Image)(resources.GetObject("label46.Image")));
            this.label46.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label46.Location = new System.Drawing.Point(1096, 11);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(327, 62);
            this.label46.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1439, 791);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1467, 986);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Techavo Systems";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(dtConfig)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            this.tabStatus.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.tabModbusReg.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabModBusCfg.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.tabMQTT.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabDevice.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabIpSett.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbComPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbModbus;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox txtSystemLog;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnConsoleSend;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.Button btnModbusRead;
        private System.Windows.Forms.Button btnLogMonitorOff;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblRespErrCode;
        private System.Windows.Forms.Label lblContState;
        private System.Windows.Forms.Label lblDataSend;
        private System.Windows.Forms.Label lblRespTimMs;
        private System.Windows.Forms.Label lblBuffOVFCount;
        private System.Windows.Forms.Label lblCfgRxCount;
        private System.Windows.Forms.Label lblRxCount;
        private System.Windows.Forms.Label lblxFailCount;
        private System.Windows.Forms.Label lblTxCount;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.Button btnMonitorStatusRead;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label lblGsmTime;
        private System.Windows.Forms.Label lblRtcTime;
        private System.Windows.Forms.Label lblHttpTime;
        private System.Windows.Forms.Label lblLocalTime;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label lblBuffLogCount;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label lblFlashLogCount;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label lblTotalLogCount;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.Button btnIOStatusRead;
        private System.Windows.Forms.Button btnStatusReset;
        private System.Windows.Forms.Button btnStatusIOOff;
        private System.Windows.Forms.Button btnStatusIOOn;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label lblDigitalInput2;
        private System.Windows.Forms.Label lblDigitalInput2Volt;
        private System.Windows.Forms.Label lblDigitalInput1;
        private System.Windows.Forms.Label lblDigitalInput1Volt;
        private System.Windows.Forms.Label lblOutputState;
        private System.Windows.Forms.Label lblInput3Volt;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblPulseCounter;
        private System.Windows.Forms.Label lblSystemVolt;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.Button btnStatusGSMRead;
        private System.Windows.Forms.Label lblSignal2;
        private System.Windows.Forms.Label lblSignal3;
        private System.Windows.Forms.Label lblSignal4;
        private System.Windows.Forms.Label lblSignal5;
        private System.Windows.Forms.Label lblSignal1;
        private System.Windows.Forms.Label lblStatusProvider;
        private System.Windows.Forms.Label lblStatusModule;
        private System.Windows.Forms.Label lblStatusDecimal;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGprsAttach;
        private System.Windows.Forms.Label lblGprs;
        private System.Windows.Forms.Label lblGprsTech;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.Label lblPowerOn;
        private System.Windows.Forms.Label lblNtpTimeSync;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.Label lblSSLFile;
        private System.Windows.Forms.Label lblCfgFile;
        private System.Windows.Forms.Label lblMbusDBFile;
        private System.Windows.Forms.Label lblDataFlash;
        private System.Windows.Forms.Label lblFwFile;
        private System.Windows.Forms.Label lblFirmwareVer;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblHardwareVer;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label lblDeviceModel;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label99;
        public System.Windows.Forms.TabPage tabModbusReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlaveId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PollDelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevID;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.TextBox txtConfigName;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TabPage tabModBusCfg;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox txtLogInterval1;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox txtPollInterval;
        private System.Windows.Forms.ComboBox cmbOnBoardIOEvent;
        private System.Windows.Forms.ComboBox cmbLogEvent;
        private System.Windows.Forms.ComboBox cmbDataFormat;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.ComboBox cmbRetryCount;
        private System.Windows.Forms.TextBox txtInterCharDelay;
        private System.Windows.Forms.TextBox txtInterPollDelay;
        private System.Windows.Forms.TextBox txtReplyTimeOut;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.ComboBox cmbConnectionType;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TabPage tabMQTT;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox txtSubscribeCmd;
        private System.Windows.Forms.TextBox txtPublishCMDReply;
        private System.Windows.Forms.TextBox txtPublishEvent;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btnMQTTShowPass;
        private System.Windows.Forms.ComboBox cmbQosLevel;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.CheckBox chkAuthEnable;
        private System.Windows.Forms.TextBox txtMQTTPassword;
        private System.Windows.Forms.TextBox txtMQTTUserName;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtBrokerPort;
        private System.Windows.Forms.TextBox txtBrokerIPDomain;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TabPage tabDevice;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtMobLocationCode;
        private System.Windows.Forms.Button btnSMSSend;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtTestMessage;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cmbEventTimeFormat;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtTimeSyncFrom;
        private System.Windows.Forms.ComboBox cmbTimeSyncFrom;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtEventHeaderThird;
        private System.Windows.Forms.TextBox txtEventHeaderSecond;
        private System.Windows.Forms.TextBox txtEventHeaderFirst;
        private System.Windows.Forms.ComboBox cmbGMTMin;
        private System.Windows.Forms.ComboBox cmbGMTHour;
        private System.Windows.Forms.ComboBox cmbGMTPlusMinus;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtPhoneNo2;
        private System.Windows.Forms.TextBox txtPhoneNo3;
        private System.Windows.Forms.TextBox txtPhoneNo1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnDevicePassShow;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDevicePassword;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.CheckBox chkRemoteConfigSecuredPhNos;
        private System.Windows.Forms.CheckBox chkSMSEnable;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnFactoryDefault;
        private System.Windows.Forms.Button btnModbusDBClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRTCTimeSet;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbFlashDataLogging;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtAPIAccessKey;
        private System.Windows.Forms.ComboBox cmbSelectAPIKeyAddIn;
        private System.Windows.Forms.ComboBox cmbSelectEventFormat;
        private System.Windows.Forms.ComboBox cmbSelectHttpMethod;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtConnectFail;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkKeepAlive;
        private System.Windows.Forms.TextBox txtDeviceToServer;
        private System.Windows.Forms.ComboBox cmbMaxRetries;
        private System.Windows.Forms.ComboBox cmbIPConnectMode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabIpSett;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSSLModuleReupdate;
        private System.Windows.Forms.Button btnClientKey;
        private System.Windows.Forms.Button btnClientCertificate;
        private System.Windows.Forms.Button btnCACertificate;
        private System.Windows.Forms.TextBox txtClientKey;
        private System.Windows.Forms.TextBox txtClientCertificate;
        private System.Windows.Forms.TextBox txtCAServerCertificate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIPSettPassView;
        private System.Windows.Forms.TextBox txtIPSettPassword;
        private System.Windows.Forms.TextBox txtIPSettUserName;
        private System.Windows.Forms.TextBox txtAPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbEventTransmission;
        private System.Windows.Forms.ComboBox cmbSSLSecurityEnabled;
        private System.Windows.Forms.CheckBox chkSSLSecurityEnable;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIPURL;
        private System.Windows.Forms.ComboBox cmbConnectProtocol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbProcessing;
        private System.Windows.Forms.Timer timerUploadDownload;
        private System.Windows.Forms.Label label46;
    }
}

