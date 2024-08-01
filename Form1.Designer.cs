namespace ComportSerial
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.chBoxDtrEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblDataOutLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_wrtieLineOrwriteText = new System.Windows.Forms.ToolStripComboBox();
            this.saveToMySQLDatabaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxtEndLine = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_TxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxShowDataWith = new System.Windows.Forms.ToolStripComboBox();
            this.dataPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataPosition = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_RxDataFormat = new System.Windows.Forms.ToolStripComboBox();
            this.multiplePortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iN1PORTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBoxRTSEnable);
            this.groupBox1.Controls.Add(this.chBoxDtrEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxRTSEnable.Location = new System.Drawing.Point(106, 158);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(93, 15);
            this.chBoxRTSEnable.TabIndex = 5;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(13, 158);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(93, 15);
            this.chBoxDtrEnable.TabIndex = 4;
            this.chBoxDtrEnable.Text = "DTR ENABLE";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(11, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "38400",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(102, 49);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(86, 20);
            this.cBoxBaudRate.TabIndex = 4;
            this.cBoxBaudRate.Text = "9600";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(102, 127);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(86, 20);
            this.cBoxParityBits.TabIndex = 3;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(102, 101);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(86, 20);
            this.cBoxStopBits.TabIndex = 2;
            this.cBoxStopBits.Text = "One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(102, 75);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(86, 20);
            this.cBoxDataBits.TabIndex = 1;
            this.cBoxDataBits.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMPORT";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(102, 23);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(86, 20);
            this.cBoxCOMPORT.TabIndex = 0;
            this.cBoxCOMPORT.DropDown += new System.EventHandler(this.cBoxCOMPORT_DropDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // btnSendData
            // 
            this.btnSendData.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendData.Location = new System.Drawing.Point(251, 0);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(49, 24);
            this.btnSendData.TabIndex = 2;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxDataOut.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxDataOut.Location = new System.Drawing.Point(0, 0);
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(251, 23);
            this.tBoxDataOut.TabIndex = 3;
            this.tBoxDataOut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxDataOut_KeyDown);
            this.tBoxDataOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDataOut_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblDataOutLength);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Location = new System.Drawing.Point(207, -4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 30);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // lblDataOutLength
            // 
            this.lblDataOutLength.AutoSize = true;
            this.lblDataOutLength.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOutLength.Location = new System.Drawing.Point(126, 11);
            this.lblDataOutLength.Name = "lblDataOutLength";
            this.lblDataOutLength.Size = new System.Drawing.Size(21, 13);
            this.lblDataOutLength.TabIndex = 1;
            this.lblDataOutLength.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data OUT Length : ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblDataInLength);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Location = new System.Drawing.Point(371, -4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(142, 30);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(114, 11);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(21, 13);
            this.lblDataInLength.TabIndex = 1;
            this.lblDataInLength.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data IN Length : ";
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBoxDataIN.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxDataIN.Location = new System.Drawing.Point(3, 50);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxDataIN.Size = new System.Drawing.Size(300, 133);
            this.tBoxDataIN.TabIndex = 4;
            this.tBoxDataIN.WordWrap = false;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cOMControlToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.multiplePortsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTxtFileToolStripMenuItem,
            this.saveToMySQLDatabaeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToTxtFileToolStripMenuItem
            // 
            this.saveToTxtFileToolStripMenuItem.Checked = true;
            this.saveToTxtFileToolStripMenuItem.CheckOnClick = true;
            this.saveToTxtFileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToTxtFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwriteText,
            this.toolStripComboBox_wrtieLineOrwriteText});
            this.saveToTxtFileToolStripMenuItem.Name = "saveToTxtFileToolStripMenuItem";
            this.saveToTxtFileToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveToTxtFileToolStripMenuItem.Text = "Save to Txt File";
            // 
            // toolStripComboBox_appendOrOverwriteText
            // 
            this.toolStripComboBox_appendOrOverwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwriteText.Items.AddRange(new object[] {
            "Append Text",
            "Overwrite Text"});
            this.toolStripComboBox_appendOrOverwriteText.Name = "toolStripComboBox_appendOrOverwriteText";
            this.toolStripComboBox_appendOrOverwriteText.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_appendOrOverwriteText.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwriteText_DropDownClosed);
            // 
            // toolStripComboBox_wrtieLineOrwriteText
            // 
            this.toolStripComboBox_wrtieLineOrwriteText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_wrtieLineOrwriteText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_wrtieLineOrwriteText.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.toolStripComboBox_wrtieLineOrwriteText.Name = "toolStripComboBox_wrtieLineOrwriteText";
            this.toolStripComboBox_wrtieLineOrwriteText.Size = new System.Drawing.Size(121, 23);
            // 
            // saveToMySQLDatabaeToolStripMenuItem
            // 
            this.saveToMySQLDatabaeToolStripMenuItem.Checked = true;
            this.saveToMySQLDatabaeToolStripMenuItem.CheckOnClick = true;
            this.saveToMySQLDatabaeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveToMySQLDatabaeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem1});
            this.saveToMySQLDatabaeToolStripMenuItem.Name = "saveToMySQLDatabaeToolStripMenuItem";
            this.saveToMySQLDatabaeToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.saveToMySQLDatabaeToolStripMenuItem.Text = "Save to MySQL Database";
            // 
            // showDataToolStripMenuItem1
            // 
            this.showDataToolStripMenuItem1.Name = "showDataToolStripMenuItem1";
            this.showDataToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.showDataToolStripMenuItem1.Text = "Show data";
            this.showDataToolStripMenuItem1.Click += new System.EventHandler(this.showDataToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cOMControlToolStripMenuItem
            // 
            this.cOMControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.cOMControlToolStripMenuItem.Name = "cOMControlToolStripMenuItem";
            this.cOMControlToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cOMControlToolStripMenuItem.Text = "COM Control";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.endLineToolStripMenuItem,
            this.dataFormatToolStripMenuItem1});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Checked = true;
            this.clearToolStripMenuItem.CheckOnClick = true;
            this.clearToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear After Send";
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxtEndLine});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.endLineToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox_TxtEndLine
            // 
            this.toolStripComboBox_TxtEndLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxtEndLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxtEndLine.Items.AddRange(new object[] {
            "None",
            "Both (\\r\\n)",
            "New Line (\\n)",
            "Carriage Return (\\r)"});
            this.toolStripComboBox_TxtEndLine.Name = "toolStripComboBox_TxtEndLine";
            this.toolStripComboBox_TxtEndLine.Size = new System.Drawing.Size(130, 23);
            this.toolStripComboBox_TxtEndLine.DropDownClosed += new System.EventHandler(this.toolStripComboBox2_DropDownClosed);
            // 
            // dataFormatToolStripMenuItem1
            // 
            this.dataFormatToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_TxDataFormat});
            this.dataFormatToolStripMenuItem1.Name = "dataFormatToolStripMenuItem1";
            this.dataFormatToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dataFormatToolStripMenuItem1.Text = "Data Format";
            // 
            // toolStripComboBox_TxDataFormat
            // 
            this.toolStripComboBox_TxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_TxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_TxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_TxDataFormat.Name = "toolStripComboBox_TxDataFormat";
            this.toolStripComboBox_TxDataFormat.Size = new System.Drawing.Size(121, 23);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataToolStripMenuItem,
            this.dataPositionToolStripMenuItem,
            this.dataFormatToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxShowDataWith});
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDataToolStripMenuItem.Text = "Show Data With";
            // 
            // toolStripComboBox_RxShowDataWith
            // 
            this.toolStripComboBox_RxShowDataWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxShowDataWith.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxShowDataWith.Items.AddRange(new object[] {
            "Always Update",
            "Add to Old Data"});
            this.toolStripComboBox_RxShowDataWith.Name = "toolStripComboBox_RxShowDataWith";
            this.toolStripComboBox_RxShowDataWith.Size = new System.Drawing.Size(121, 23);
            // 
            // dataPositionToolStripMenuItem
            // 
            this.dataPositionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataPosition});
            this.dataPositionToolStripMenuItem.Name = "dataPositionToolStripMenuItem";
            this.dataPositionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPositionToolStripMenuItem.Text = "Data Position";
            // 
            // toolStripComboBox_RxDataPosition
            // 
            this.toolStripComboBox_RxDataPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataPosition.Items.AddRange(new object[] {
            "TOP",
            "BOTTOM"});
            this.toolStripComboBox_RxDataPosition.Name = "toolStripComboBox_RxDataPosition";
            this.toolStripComboBox_RxDataPosition.Size = new System.Drawing.Size(121, 23);
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_RxDataFormat});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripComboBox_RxDataFormat
            // 
            this.toolStripComboBox_RxDataFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_RxDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_RxDataFormat.Items.AddRange(new object[] {
            "Hex",
            "Decimal",
            "Binary",
            "Char"});
            this.toolStripComboBox_RxDataFormat.Name = "toolStripComboBox_RxDataFormat";
            this.toolStripComboBox_RxDataFormat.Size = new System.Drawing.Size(121, 23);
            // 
            // multiplePortsToolStripMenuItem
            // 
            this.multiplePortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iN1PORTSToolStripMenuItem});
            this.multiplePortsToolStripMenuItem.Name = "multiplePortsToolStripMenuItem";
            this.multiplePortsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.multiplePortsToolStripMenuItem.Text = "Multiple Ports";
            // 
            // iN1PORTSToolStripMenuItem
            // 
            this.iN1PORTSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1});
            this.iN1PORTSToolStripMenuItem.Name = "iN1PORTSToolStripMenuItem";
            this.iN1PORTSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iN1PORTSToolStripMenuItem.Text = "2 IN 1 PORTS";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.panel3);
            this.groupBox12.Controls.Add(this.tBoxDataIN);
            this.groupBox12.Location = new System.Drawing.Point(219, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(306, 186);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "MONITOR";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tBoxDataOut);
            this.panel3.Controls.Add(this.btnSendData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 24);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(530, 228);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 28);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 291);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDtrEnable;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblDataOutLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblDataInLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxShowDataWith;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxtEndLine;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ToolStripMenuItem dataPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem saveToTxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwriteText;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_wrtieLineOrwriteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToMySQLDatabaeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiplePortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iN1PORTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_RxDataFormat;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_TxDataFormat;
    }
}

