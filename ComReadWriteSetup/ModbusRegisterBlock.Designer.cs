
namespace ComReadWrite
{
    partial class ModbusRegisterBlock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModbusRegisterBlock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFunctionCode = new System.Windows.Forms.ComboBox();
            this.txtPollInterval = new System.Windows.Forms.TextBox();
            this.txtSlaveID = new System.Windows.Forms.TextBox();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtDeviceTCPIP = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.cmbGroupID = new System.Windows.Forms.ComboBox();
            this.cmbCommPort = new System.Windows.Forms.ComboBox();
            this.cmbBlockID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSLNO = new System.Windows.Forms.Label();
            this.dgvRegisterMapper = new System.Windows.Forms.DataGridView();
            this.cIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEndian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChgField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cScaleFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkCF = new System.Windows.Forms.CheckBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.txtBitsWords = new System.Windows.Forms.TextBox();
            this.txtScaleFactor = new System.Windows.Forms.TextBox();
            this.cmbFieldType = new System.Windows.Forms.ComboBox();
            this.cmbByteOrder = new System.Windows.Forms.ComboBox();
            this.cmbResolution = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByteOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterMapper)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFunctionCode);
            this.groupBox1.Controls.Add(this.txtPollInterval);
            this.groupBox1.Controls.Add(this.txtSlaveID);
            this.groupBox1.Controls.Add(this.txtDeviceID);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtDeviceTCPIP);
            this.groupBox1.Controls.Add(this.txtWordCount);
            this.groupBox1.Controls.Add(this.txtStartAddress);
            this.groupBox1.Controls.Add(this.cmbGroupID);
            this.groupBox1.Controls.Add(this.cmbCommPort);
            this.groupBox1.Controls.Add(this.cmbBlockID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbFunctionCode
            // 
            this.cmbFunctionCode.DisplayMember = "1";
            this.cmbFunctionCode.FormattingEnabled = true;
            this.cmbFunctionCode.Items.AddRange(new object[] {
            "Read Coil Status",
            "Read Input Status",
            "Read Holding Registers",
            "Read Input Registers"});
            this.cmbFunctionCode.Location = new System.Drawing.Point(142, 73);
            this.cmbFunctionCode.Name = "cmbFunctionCode";
            this.cmbFunctionCode.Size = new System.Drawing.Size(304, 28);
            this.cmbFunctionCode.TabIndex = 25;
            // 
            // txtPollInterval
            // 
            this.txtPollInterval.Location = new System.Drawing.Point(142, 222);
            this.txtPollInterval.Name = "txtPollInterval";
            this.txtPollInterval.Size = new System.Drawing.Size(304, 27);
            this.txtPollInterval.TabIndex = 24;
            this.txtPollInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPollInterval_KeyPress);
            // 
            // txtSlaveID
            // 
            this.txtSlaveID.Location = new System.Drawing.Point(323, 24);
            this.txtSlaveID.Name = "txtSlaveID";
            this.txtSlaveID.Size = new System.Drawing.Size(118, 27);
            this.txtSlaveID.TabIndex = 22;
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Enabled = false;
            this.txtDeviceID.Location = new System.Drawing.Point(142, 500);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(304, 27);
            this.txtDeviceID.TabIndex = 21;
            this.txtDeviceID.Text = "1";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(142, 435);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(304, 27);
            this.txtPort.TabIndex = 20;
            this.txtPort.Text = "0";
            // 
            // txtDeviceTCPIP
            // 
            this.txtDeviceTCPIP.Enabled = false;
            this.txtDeviceTCPIP.Location = new System.Drawing.Point(142, 385);
            this.txtDeviceTCPIP.Name = "txtDeviceTCPIP";
            this.txtDeviceTCPIP.Size = new System.Drawing.Size(304, 27);
            this.txtDeviceTCPIP.TabIndex = 19;
            this.txtDeviceTCPIP.Text = "0.0.0.0";
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(142, 165);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(304, 27);
            this.txtWordCount.TabIndex = 18;
            this.txtWordCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWordCount_KeyPress);
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(142, 120);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(304, 27);
            this.txtStartAddress.TabIndex = 17;
            this.txtStartAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartAddress_KeyPress);
            // 
            // cmbGroupID
            // 
            this.cmbGroupID.DisplayMember = "1";
            this.cmbGroupID.Enabled = false;
            this.cmbGroupID.FormattingEnabled = true;
            this.cmbGroupID.Items.AddRange(new object[] {
            "1"});
            this.cmbGroupID.Location = new System.Drawing.Point(142, 278);
            this.cmbGroupID.Name = "cmbGroupID";
            this.cmbGroupID.Size = new System.Drawing.Size(304, 28);
            this.cmbGroupID.TabIndex = 13;
            // 
            // cmbCommPort
            // 
            this.cmbCommPort.Enabled = false;
            this.cmbCommPort.FormattingEnabled = true;
            this.cmbCommPort.Items.AddRange(new object[] {
            "RS485"});
            this.cmbCommPort.Location = new System.Drawing.Point(142, 328);
            this.cmbCommPort.Name = "cmbCommPort";
            this.cmbCommPort.Size = new System.Drawing.Size(304, 28);
            this.cmbCommPort.TabIndex = 12;
            // 
            // cmbBlockID
            // 
            this.cmbBlockID.Enabled = false;
            this.cmbBlockID.FormattingEnabled = true;
            this.cmbBlockID.Location = new System.Drawing.Point(142, 24);
            this.cmbBlockID.Name = "cmbBlockID";
            this.cmbBlockID.Size = new System.Drawing.Size(110, 28);
            this.cmbBlockID.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "SlaveID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Device TCP/IP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Function Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Start Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Word Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poll/Log Interval";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comm.Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BlockID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSLNO);
            this.groupBox2.Controls.Add(this.dgvRegisterMapper);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.chkCF);
            this.groupBox2.Controls.Add(this.txtRegName);
            this.groupBox2.Controls.Add(this.txtBitsWords);
            this.groupBox2.Controls.Add(this.txtScaleFactor);
            this.groupBox2.Controls.Add(this.cmbFieldType);
            this.groupBox2.Controls.Add(this.cmbByteOrder);
            this.groupBox2.Controls.Add(this.cmbResolution);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(471, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 581);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register Mapping";
            // 
            // lblSLNO
            // 
            this.lblSLNO.AutoSize = true;
            this.lblSLNO.Location = new System.Drawing.Point(301, 70);
            this.lblSLNO.Name = "lblSLNO";
            this.lblSLNO.Size = new System.Drawing.Size(0, 20);
            this.lblSLNO.TabIndex = 28;
            this.lblSLNO.Visible = false;
            // 
            // dgvRegisterMapper
            // 
            this.dgvRegisterMapper.AllowUserToAddRows = false;
            this.dgvRegisterMapper.AllowUserToDeleteRows = false;
            this.dgvRegisterMapper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterMapper.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIndex,
            this.cAddress,
            this.cFieldName,
            this.cEndian,
            this.cFieldType,
            this.cChgField,
            this.cWords,
            this.cResolution,
            this.cScaleFactor});
            this.dgvRegisterMapper.Location = new System.Drawing.Point(7, 165);
            this.dgvRegisterMapper.Name = "dgvRegisterMapper";
            this.dgvRegisterMapper.RowHeadersWidth = 51;
            this.dgvRegisterMapper.RowTemplate.Height = 29;
            this.dgvRegisterMapper.Size = new System.Drawing.Size(924, 410);
            this.dgvRegisterMapper.TabIndex = 27;
            this.dgvRegisterMapper.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvRegisterMapper_CellValidating);
            this.dgvRegisterMapper.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRegisterMapper_RowHeaderMouseClick);
            // 
            // cIndex
            // 
            this.cIndex.DataPropertyName = "SLNo";
            this.cIndex.HeaderText = "Index";
            this.cIndex.MinimumWidth = 6;
            this.cIndex.Name = "cIndex";
            this.cIndex.ReadOnly = true;
            this.cIndex.Width = 125;
            // 
            // cAddress
            // 
            this.cAddress.DataPropertyName = "Address";
            this.cAddress.HeaderText = "Address";
            this.cAddress.MinimumWidth = 6;
            this.cAddress.Name = "cAddress";
            this.cAddress.Width = 125;
            // 
            // cFieldName
            // 
            this.cFieldName.DataPropertyName = "FieldName";
            this.cFieldName.HeaderText = "FieldName";
            this.cFieldName.MinimumWidth = 6;
            this.cFieldName.Name = "cFieldName";
            this.cFieldName.ReadOnly = true;
            this.cFieldName.Width = 125;
            // 
            // cEndian
            // 
            this.cEndian.DataPropertyName = "Endian";
            this.cEndian.HeaderText = "Endian";
            this.cEndian.MinimumWidth = 6;
            this.cEndian.Name = "cEndian";
            this.cEndian.ReadOnly = true;
            this.cEndian.Width = 125;
            // 
            // cFieldType
            // 
            this.cFieldType.DataPropertyName = "FieldType";
            this.cFieldType.HeaderText = "FieldType";
            this.cFieldType.MinimumWidth = 6;
            this.cFieldType.Name = "cFieldType";
            this.cFieldType.ReadOnly = true;
            this.cFieldType.Width = 125;
            // 
            // cChgField
            // 
            this.cChgField.DataPropertyName = "ChangeField";
            this.cChgField.HeaderText = "Chg.Field";
            this.cChgField.MinimumWidth = 6;
            this.cChgField.Name = "cChgField";
            this.cChgField.ReadOnly = true;
            this.cChgField.Width = 125;
            // 
            // cWords
            // 
            this.cWords.DataPropertyName = "Words";
            this.cWords.HeaderText = "Words";
            this.cWords.MinimumWidth = 6;
            this.cWords.Name = "cWords";
            this.cWords.ReadOnly = true;
            this.cWords.Width = 125;
            // 
            // cResolution
            // 
            this.cResolution.DataPropertyName = "Resolution";
            this.cResolution.HeaderText = "Resolution";
            this.cResolution.MinimumWidth = 6;
            this.cResolution.Name = "cResolution";
            this.cResolution.ReadOnly = true;
            this.cResolution.Width = 125;
            // 
            // cScaleFactor
            // 
            this.cScaleFactor.DataPropertyName = "ScaleFactor";
            this.cScaleFactor.HeaderText = "ScaleFactor";
            this.cScaleFactor.MinimumWidth = 6;
            this.cScaleFactor.Name = "cScaleFactor";
            this.cScaleFactor.ReadOnly = true;
            this.cScaleFactor.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(791, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(638, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(482, 117);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkCF
            // 
            this.chkCF.AutoSize = true;
            this.chkCF.Location = new System.Drawing.Point(838, 24);
            this.chkCF.Name = "chkCF";
            this.chkCF.Size = new System.Drawing.Size(47, 24);
            this.chkCF.TabIndex = 22;
            this.chkCF.Text = "CF";
            this.chkCF.UseVisualStyleBackColor = true;
            // 
            // txtRegName
            // 
            this.txtRegName.Location = new System.Drawing.Point(94, 117);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(151, 27);
            this.txtRegName.TabIndex = 21;
            // 
            // txtBitsWords
            // 
            this.txtBitsWords.Enabled = false;
            this.txtBitsWords.Location = new System.Drawing.Point(398, 24);
            this.txtBitsWords.Name = "txtBitsWords";
            this.txtBitsWords.Size = new System.Drawing.Size(118, 27);
            this.txtBitsWords.TabIndex = 20;
            this.txtBitsWords.Text = "0";
            // 
            // txtScaleFactor
            // 
            this.txtScaleFactor.Location = new System.Drawing.Point(94, 70);
            this.txtScaleFactor.Name = "txtScaleFactor";
            this.txtScaleFactor.Size = new System.Drawing.Size(151, 27);
            this.txtScaleFactor.TabIndex = 19;
            this.txtScaleFactor.TextChanged += new System.EventHandler(this.txtScaleFactor_TextChanged);
            this.txtScaleFactor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScaleFactor_KeyPress);
            this.txtScaleFactor.Leave += new System.EventHandler(this.txtScaleFactor_Leave);
            // 
            // cmbFieldType
            // 
            this.cmbFieldType.FormattingEnabled = true;
            this.cmbFieldType.Items.AddRange(new object[] {
            "signed int",
            "unsigned int",
            "signed long",
            "unsigned long",
            "float"});
            this.cmbFieldType.Location = new System.Drawing.Point(94, 24);
            this.cmbFieldType.Name = "cmbFieldType";
            this.cmbFieldType.Size = new System.Drawing.Size(151, 28);
            this.cmbFieldType.TabIndex = 14;
            // 
            // cmbByteOrder
            // 
            this.cmbByteOrder.FormattingEnabled = true;
            this.cmbByteOrder.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbByteOrder.Location = new System.Drawing.Point(633, 24);
            this.cmbByteOrder.Name = "cmbByteOrder";
            this.cmbByteOrder.Size = new System.Drawing.Size(175, 28);
            this.cmbByteOrder.TabIndex = 13;
            // 
            // cmbResolution
            // 
            this.cmbResolution.FormattingEnabled = true;
            this.cmbResolution.Items.AddRange(new object[] {
            "None",
            "0.0",
            "0.00",
            "0.000"});
            this.cmbResolution.Location = new System.Drawing.Point(633, 70);
            this.cmbResolution.Name = "cmbResolution";
            this.cmbResolution.Size = new System.Drawing.Size(175, 28);
            this.cmbResolution.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "FieldType";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 5;
            this.label16.Text = "Bits/Words";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(548, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Endian";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Scale Factor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Resolution";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Reg. Name";
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "FieldName";
            this.FieldName.MinimumWidth = 6;
            this.FieldName.Name = "FieldName";
            this.FieldName.Width = 125;
            // 
            // ByteOrder
            // 
            this.ByteOrder.HeaderText = "ByteOrder";
            this.ByteOrder.MinimumWidth = 6;
            this.ByteOrder.Name = "ByteOrder";
            this.ByteOrder.Width = 125;
            // 
            // FieldType
            // 
            this.FieldType.HeaderText = "FieldType";
            this.FieldType.MinimumWidth = 6;
            this.FieldType.Name = "FieldType";
            this.FieldType.Width = 125;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(622, 617);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(761, 617);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ModbusRegisterBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 668);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1427, 715);
            this.Name = "ModbusRegisterBlock";
            this.Text = "ModbusRegisterBlock";
            this.Load += new System.EventHandler(this.ModbusRegisterBlock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterMapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGroupID;
        private System.Windows.Forms.ComboBox cmbCommPort;
        private System.Windows.Forms.ComboBox cmbBlockID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtDeviceTCPIP;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRegisterMapper;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkCF;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.TextBox txtBitsWords;
        private System.Windows.Forms.TextBox txtScaleFactor;
        private System.Windows.Forms.ComboBox cmbFieldType;
        private System.Windows.Forms.ComboBox cmbByteOrder;
        private System.Windows.Forms.ComboBox cmbResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByteOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldType;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPollInterval;
        private System.Windows.Forms.TextBox txtSlaveID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEndian;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChgField;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn cScaleFactor;
        private System.Windows.Forms.Label lblSLNO;
        private System.Windows.Forms.ComboBox cmbFunctionCode;
    }
}