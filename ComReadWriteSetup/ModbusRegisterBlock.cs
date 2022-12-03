using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;

namespace ComReadWrite
{
    public partial class ModbusRegisterBlock : Form
    {
        public readonly Main _mainForm;
        private int _blockId = 0;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "DB\\config.accdb;User Id=Admin;Password=;";
        public ModbusRegisterBlock(int blockId, Main main)
        {
            InitializeComponent();
            _blockId = blockId;
            _mainForm = main;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvRegisterMapper;
            int iRow = dgv.Rows.Add();
            DataGridViewRow dgvRow = dgv.Rows[iRow];
            dgvRow.Cells["cIndex"].Value = iRow > 0 ? Convert.ToInt32(dgv.Rows[iRow - 1].Cells[0].Value) + 1 : 1;
            dgvRow.Cells["cAddress"].Value = txtStartAddress.Text;
            dgvRow.Cells["cFieldName"].Value = txtRegName.Text;
            dgvRow.Cells["cEndian"].Value = cmbByteOrder.SelectedItem.ToString();
            dgvRow.Cells["cFieldType"].Value = cmbFieldType.SelectedItem;
            dgvRow.Cells["cChgField"].Value = chkCF.Checked.ToString();
            dgvRow.Cells["cWords"].Value = txtBitsWords.Text;
            dgvRow.Cells["cResolution"].Value = cmbResolution.SelectedItem;
            dgvRow.Cells["cScaleFactor"].Value = txtScaleFactor.Text;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvRegisterMapper;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvRegisterMapper.Rows[Convert.ToInt32(lblSLNO.Text)];
            dgvRow.Cells["cFieldName"].Value = txtRegName.Text;
            dgvRow.Cells["cEndian"].Value = cmbByteOrder.SelectedItem.ToString();
            dgvRow.Cells["cFieldType"].Value = cmbFieldType.SelectedItem;
            dgvRow.Cells["cChgField"].Value = chkCF.Checked.ToString();
            dgvRow.Cells["cWords"].Value = txtBitsWords.Text;
            dgvRow.Cells["cResolution"].Value = cmbResolution.SelectedItem;
            dgvRow.Cells["cScaleFactor"].Value = txtScaleFactor.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvRegisterMapper;
            dgv.Rows.Remove(dgv.CurrentRow);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!AddressCheck(dgvRegisterMapper))
                return;

            string strSQL = "SELECT BlockID FROM ModbusReg where BlockID=" + Convert.ToInt32(cmbBlockID.SelectedValue);
            // Create a connection    
            OleDbConnection connection = new OleDbConnection(connectionString);
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
            if (dtBlockIds.Rows.Count == 0)
                InsertModbusReg();
            else
                UpdateModbusReg(Convert.ToInt32(cmbBlockID.SelectedValue));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure to close the page? All the unsaved data will be Deleted", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void ModbusRegisterBlock_Load(object sender, EventArgs e)
        {
            cmbGroupID.SelectedIndex = 0;
            cmbResolution.SelectedIndex = 0;
            cmbFieldType.SelectedIndex = 0;
            cmbByteOrder.SelectedIndex = 0;
            cmbCommPort.SelectedIndex = 0;
            PopulateBlockID(_blockId);
            if (_blockId > 0)
                PopulateOtherFields(_blockId);
        }

        private void PopulateOtherFields(int blockId)
        {
            try
            {
                string strSQL = "SELECT * FROM ModbusReg c where c.BlockID=" + blockId;
                // Create a connection    
                OleDbConnection connection = new OleDbConnection(connectionString);
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
                if (dtModbusReg != null && dtModbusReg.Rows.Count > 0)
                {
                    txtSlaveID.Text = Convert.ToString(dtModbusReg.Rows[0]["SlaveID"]);
                    cmbFunctionCode.SelectedItem = Convert.ToString(dtModbusReg.Rows[0]["FunCode"]);
                    txtStartAddress.Text = Convert.ToString(dtModbusReg.Rows[0]["StartAddress"]);
                    txtWordCount.Text = Convert.ToString(dtModbusReg.Rows[0]["WordCount"]);
                    txtPollInterval.Text = Convert.ToString(dtModbusReg.Rows[0]["PollDelay"]);
                }
                strSQL = "SELECT SLNo,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor FROM ModbusRegBlockConfig c where c.BlockID=" + blockId;
                command = new OleDbCommand(strSQL, connection);
                DataTable dtModbusRegBlock = new DataTable();
                // Execute command    
                using (OleDbDataAdapter da = new OleDbDataAdapter(command))
                {
                    connection.Open();
                    da.Fill(dtModbusRegBlock);
                    connection.Close();
                }
                if (dtModbusRegBlock.Rows.Count > 0)
                {
                    dgvRegisterMapper.DataSource = dtModbusRegBlock;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateBlockID(int blockId)
        {
            try
            {
                string strSQL = "SELECT BlockID FROM ModbusReg";
                // Create a connection    
                OleDbConnection connection = new OleDbConnection(connectionString);
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

                cmbBlockID.DisplayMember = "BlockID";
                cmbBlockID.ValueMember = "BlockID";

                if (blockId == 0)
                {
                    List<int> levels = dtBlockIds.AsEnumerable().Select(al => al.Field<int>("BlockID")).Distinct().ToList();
                    int max = levels.Max();
                    dtBlockIds.Rows.Add(max + 1);
                    cmbBlockID.DataSource = dtBlockIds;
                    cmbBlockID.SelectedIndex = cmbBlockID.FindStringExact((max + 1).ToString());
                }
                else
                {
                    cmbBlockID.DataSource = dtBlockIds;
                    cmbBlockID.SelectedIndex = cmbBlockID.FindStringExact(blockId.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void InsertModbusReg()
        {
            if (string.IsNullOrEmpty(Convert.ToString(cmbBlockID.SelectedValue)))
                return;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            StringBuilder sb = new StringBuilder("Insert into ModbusReg(BlockID,SlaveID,FunCode,StartAddress,WordCount,PollDelay,GroupID,Comport,IP,Port,DevID) Values (");
            sb.Append(cmbBlockID.SelectedValue);
            sb.Append(",'");
            sb.Append(txtSlaveID.Text);
            sb.Append("','");
            sb.Append(cmbFunctionCode.SelectedItem);
            sb.Append("',");
            sb.Append(string.IsNullOrEmpty(txtStartAddress.Text) == true ? "0" : txtStartAddress.Text);
            sb.Append(",");
            sb.Append(string.IsNullOrEmpty(txtWordCount.Text) == true ? "0" : txtWordCount.Text);
            sb.Append(",");
            sb.Append(string.IsNullOrEmpty(txtPollInterval.Text) == true ? "0" : txtPollInterval.Text);
            sb.Append(",");
            sb.Append(string.IsNullOrEmpty(Convert.ToString(cmbGroupID.SelectedItem)) ? "0" : cmbGroupID.SelectedItem);
            sb.Append(",'");
            sb.Append(cmbCommPort.SelectedItem);
            sb.Append("','");
            sb.Append(txtDeviceTCPIP.Text);
            sb.Append("',");
            sb.Append(txtPort.Text);
            sb.Append(",");
            sb.Append(txtDeviceID.Text);
            sb.Append(")");
            cmd.CommandText = sb.ToString();
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved Successfully", "Information");
        }
        private void InsertModbusRegBlockConfig()
        {
            for (int iRow = 0; iRow < dgvRegisterMapper.Rows.Count; iRow++)
            {
                StringBuilder sb = new StringBuilder("Insert into ModbusRegBlockConfig(SLNo,BlockID,Address,FieldName,Endian,FieldType,ChangeField,Words,Resolution,ScaleFactor) values ( ");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cIndex"].Value);
                sb.Append(",");
                sb.Append(cmbBlockID.SelectedValue);
                sb.Append(",'");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cAddress"].Value);
                sb.Append("','");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cFieldName"].Value);
                sb.Append("',");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cEndian"].Value);
                sb.Append(",'");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cFieldType"].Value);
                sb.Append("',");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cChgField"].Value);
                sb.Append(",");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cWords"].Value);
                sb.Append(",'");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cResolution"].Value);
                sb.Append("','");
                sb.Append(dgvRegisterMapper.Rows[iRow].Cells["cScaleFactor"].Value);
                sb.Append("')");
                OleDbConnection con = new OleDbConnection(connectionString);
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = sb.ToString();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void UpdateModbusReg(int blockId)
        {
            OleDbConnection con = new OleDbConnection(connectionString);
            StringBuilder sb = new StringBuilder("Update ModbusReg set ");
            sb.Append("SlaveID = '");
            sb.Append(txtSlaveID.Text);
            sb.Append("',FunCode = '");
            sb.Append(cmbFunctionCode.SelectedItem);
            sb.Append("',StartAddress = ");
            sb.Append(String.IsNullOrEmpty(txtStartAddress.Text) ? "0" : txtStartAddress.Text);
            sb.Append(",WordCount = ");
            sb.Append(String.IsNullOrEmpty(txtWordCount.Text) ? "0" : txtWordCount.Text);
            sb.Append(",PollDelay = ");
            sb.Append(String.IsNullOrEmpty(txtPollInterval.Text) ? "0" : txtPollInterval.Text);
            sb.Append(",GroupID = ");
            sb.Append(String.IsNullOrEmpty(Convert.ToString(cmbGroupID.SelectedItem)) ? "0" : Convert.ToString(cmbGroupID.SelectedItem));
            sb.Append(",Comport = '");
            sb.Append(cmbCommPort.SelectedItem);
            sb.Append("',IP = '");
            sb.Append(txtDeviceTCPIP.Text);
            sb.Append("',Port = ");
            sb.Append(String.IsNullOrEmpty(txtPort.Text) ? "0" : txtPort.Text);
            sb.Append(",DevID = ");
            sb.Append(String.IsNullOrEmpty(txtDeviceID.Text) ? "0" : txtDeviceID.Text);
            sb.Append(" where BlockID = ");
            sb.Append(blockId);
            OleDbCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sb.ToString();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //Update grid
            sb = new StringBuilder("Delete from ModbusRegBlockConfig where BlockID=");
            sb.Append(blockId);
            cmd.CommandText = sb.ToString();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            InsertModbusRegBlockConfig();
            MessageBox.Show("Record Updated Successfully", "Information");
        }
        private void txtWordCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStartAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPollInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool AddressCheck(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0 && dgv.CurrentRow != null)
            {
                string address = Convert.ToString(dgv.CurrentRow.Cells["cAddress"].Value);
                int isDigit = 0;
                int.TryParse(address, out isDigit);
                if (isDigit <= 0)
                {
                    MessageBox.Show("Address should be number");
                    return false;
                }

                int iAddress = Convert.ToInt32(address);
                if (iAddress < Convert.ToInt32(txtStartAddress.Text))
                {
                    MessageBox.Show("Address value should be greater than equal Start Address: " + txtStartAddress.Text);
                    dgv.CurrentRow.Cells["cAddress"].Value = txtStartAddress.Text;
                    return false;
                }
            }
            return true;
        }

        private void dgvRegisterMapper_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string address = Convert.ToString(e.FormattedValue);
                int isDigit = 0;
                int.TryParse(address, out isDigit);
                if (isDigit <= 0)
                {
                    MessageBox.Show("Address should be number");
                    dgvRegisterMapper.CurrentRow.Cells["cAddress"].Value = txtStartAddress.Text;
                    return;
                }

                int iAddress = Convert.ToInt32(address);
                if (iAddress < Convert.ToInt32(txtStartAddress.Text))
                {
                    MessageBox.Show("Address value should be greater than equal Start Address: " + txtStartAddress.Text);
                    dgvRegisterMapper.CurrentRow.Cells["cAddress"].Value = txtStartAddress.Text;
                    return;
                }
            }
        }

        private void dgvRegisterMapper_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dgvRow = ((DataGridView)sender).CurrentRow;
            txtRegName.Text = Convert.ToString(dgvRow.Cells["cFieldName"].Value);
            txtBitsWords.Text = Convert.ToString(dgvRow.Cells["cWords"].Value);
            chkCF.Checked = Convert.ToBoolean(dgvRow.Cells["cChgField"].Value);
            cmbByteOrder.SelectedItem = Convert.ToString(dgvRow.Cells["cEndian"].Value);
            cmbFieldType.SelectedItem = Convert.ToString(dgvRow.Cells["cFieldType"].Value);
            txtScaleFactor.Text = Convert.ToString(dgvRow.Cells["cScaleFactor"].Value);
            lblSLNO.Text = dgvRow.Index.ToString();
        }
        private void ModbusRegisterBlock_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            DataGridView dgv = (DataGridView)_mainForm.tabModbusReg.Controls["dtConfig"];
            string strSQL = "SELECT * FROM ModbusReg";
            // Create a connection    
            OleDbConnection connection = new OleDbConnection(connectionString);
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
            dgv.DataSource = dtModbusReg;
        }

        private void txtScaleFactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' || (((TextBox)sender).Text.Contains(".") && e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void txtScaleFactor_TextChanged(object sender, EventArgs e)
        {
            //double d = Convert.ToDouble(txtScaleFactor.Text);
            
        }

        private void txtScaleFactor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScaleFactor.Text))
                txtScaleFactor.Text = Convert.ToDouble(txtScaleFactor.Text).ToString("F");
        }
    }
}
