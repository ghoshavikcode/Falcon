using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComReadWrite
{
    public partial class Login : Form
    {
        private Main mainClass;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "DB\\config.accdb;User Id=Admin;Password=;";
        public Login()
        {
            InitializeComponent();
        }

        private void btnModelVerify_Click(object sender, EventArgs e)
        {

            lblMessage.Text = "Verfied";
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM Login where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";
            // Create a connection    
            OleDbConnection connection = new OleDbConnection(connectionString);
            // Create a command and set its connection    
            OleDbCommand command = new OleDbCommand(strSQL, connection);
            DataTable dtLogin = new DataTable();
            // Execute command    
            using (OleDbDataAdapter da = new OleDbDataAdapter(command))
            {
                connection.Open();
                da.Fill(dtLogin);
                connection.Close();
            }
            if(dtLogin.Rows.Count > 0)
            {
                mainClass = new Main();
                mainClass.login = this;
                mainClass.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong user name and password");
                txtPassword.Text = string.Empty;
                txtUserName.Text = string.Empty;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbModelNo.SelectedIndex = 0;
        }
        private void Login_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //mainClass.Visible = true;
        }
    }
}
