namespace InventoryManagement
{
    partial class ManageOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.OrderIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CustId = new Guna.UI2.WinForms.Guna2TextBox();
            this.orderdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.QtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CustName = new Guna.UI2.WinForms.Guna2TextBox();
            this.OrderGv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TotAmount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 15);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(828, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "재고 관리 시스템";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문 관리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(166, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "고객 목록";
            // 
            // CustomersGV
            // 
            this.CustomersGV.AllowUserToAddRows = false;
            this.CustomersGV.AllowUserToDeleteRows = false;
            this.CustomersGV.AllowUserToResizeColumns = false;
            this.CustomersGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.Location = new System.Drawing.Point(25, 138);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.ReadOnly = true;
            this.CustomersGV.RowHeadersVisible = false;
            this.CustomersGV.RowTemplate.Height = 23;
            this.CustomersGV.Size = new System.Drawing.Size(360, 206);
            this.CustomersGV.TabIndex = 25;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.CustomersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomersGV.ThemeStyle.HeaderStyle.Height = 25;
            this.CustomersGV.ThemeStyle.ReadOnly = true;
            this.CustomersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustomersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersGV.ThemeStyle.RowsStyle.Height = 23;
            this.CustomersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellClick);
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OrderIdTb.DefaultText = "";
            this.OrderIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OrderIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OrderIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OrderIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OrderIdTb.FillColor = System.Drawing.SystemColors.Control;
            this.OrderIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OrderIdTb.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTb.ForeColor = System.Drawing.Color.Crimson;
            this.OrderIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OrderIdTb.Location = new System.Drawing.Point(12, 356);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.PasswordChar = '\0';
            this.OrderIdTb.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.OrderIdTb.PlaceholderText = "주문 아이디";
            this.OrderIdTb.SelectedText = "";
            this.OrderIdTb.Size = new System.Drawing.Size(149, 38);
            this.OrderIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.OrderIdTb.TabIndex = 26;
            // 
            // CustId
            // 
            this.CustId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustId.DefaultText = "";
            this.CustId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustId.Enabled = false;
            this.CustId.FillColor = System.Drawing.SystemColors.Control;
            this.CustId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustId.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustId.ForeColor = System.Drawing.Color.Crimson;
            this.CustId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustId.Location = new System.Drawing.Point(12, 400);
            this.CustId.Name = "CustId";
            this.CustId.PasswordChar = '\0';
            this.CustId.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.CustId.PlaceholderText = "고객 아이디";
            this.CustId.SelectedText = "";
            this.CustId.Size = new System.Drawing.Size(149, 38);
            this.CustId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustId.TabIndex = 27;
            // 
            // orderdate
            // 
            this.orderdate.Checked = true;
            this.orderdate.FillColor = System.Drawing.Color.Crimson;
            this.orderdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.ForeColor = System.Drawing.Color.White;
            this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.orderdate.Location = new System.Drawing.Point(12, 516);
            this.orderdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(200, 30);
            this.orderdate.TabIndex = 28;
            this.orderdate.Value = new System.DateTime(2024, 8, 16, 15, 20, 53, 818);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(66, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "주문 일자";
            // 
            // SearchCombo
            // 
            this.SearchCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCombo.ForeColor = System.Drawing.Color.Crimson;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(560, 106);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(149, 25);
            this.SearchCombo.TabIndex = 33;
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            this.ProductsGV.AllowUserToAddRows = false;
            this.ProductsGV.AllowUserToDeleteRows = false;
            this.ProductsGV.AllowUserToResizeColumns = false;
            this.ProductsGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProductsGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.Location = new System.Drawing.Point(391, 138);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.ReadOnly = true;
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowTemplate.Height = 23;
            this.ProductsGV.Size = new System.Drawing.Size(453, 206);
            this.ProductsGV.TabIndex = 34;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductsGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ProductsGV.ThemeStyle.ReadOnly = true;
            this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.ThemeStyle.RowsStyle.Height = 23;
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellClick);
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(447, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "카테고리 선택";
            // 
            // QtyTb
            // 
            this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyTb.DefaultText = "";
            this.QtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QtyTb.FillColor = System.Drawing.SystemColors.Control;
            this.QtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Crimson;
            this.QtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QtyTb.Location = new System.Drawing.Point(466, 349);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PasswordChar = '\0';
            this.QtyTb.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.QtyTb.PlaceholderText = "";
            this.QtyTb.SelectedText = "";
            this.QtyTb.Size = new System.Drawing.Size(149, 25);
            this.QtyTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.QtyTb.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(422, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "수량";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(619, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 25);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustName
            // 
            this.CustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustName.DefaultText = "";
            this.CustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustName.Enabled = false;
            this.CustName.FillColor = System.Drawing.SystemColors.Control;
            this.CustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustName.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.ForeColor = System.Drawing.Color.Crimson;
            this.CustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustName.Location = new System.Drawing.Point(12, 444);
            this.CustName.Name = "CustName";
            this.CustName.PasswordChar = '\0';
            this.CustName.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.CustName.PlaceholderText = "고객 이름";
            this.CustName.SelectedText = "";
            this.CustName.Size = new System.Drawing.Size(149, 38);
            this.CustName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustName.TabIndex = 40;
            // 
            // OrderGv
            // 
            this.OrderGv.AllowUserToAddRows = false;
            this.OrderGv.AllowUserToDeleteRows = false;
            this.OrderGv.AllowUserToResizeColumns = false;
            this.OrderGv.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.OrderGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderGv.ColumnHeadersHeight = 25;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGv.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.Location = new System.Drawing.Point(303, 381);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.ReadOnly = true;
            this.OrderGv.RowHeadersVisible = false;
            this.OrderGv.RowTemplate.Height = 23;
            this.OrderGv.Size = new System.Drawing.Size(541, 206);
            this.OrderGv.TabIndex = 41;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderGv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.OrderGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderGv.ThemeStyle.HeaderStyle.Height = 25;
            this.OrderGv.ThemeStyle.ReadOnly = true;
            this.OrderGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OrderGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderGv.ThemeStyle.RowsStyle.Height = 23;
            this.OrderGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.Color.Green;
            this.TotAmount.Location = new System.Drawing.Point(539, 590);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(42, 22);
            this.TotAmount.TabIndex = 42;
            this.TotAmount.Text = "0 원";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(454, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "총 액 : ";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Crimson;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(12, 562);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 25);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "주문 입력";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Crimson;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(112, 562);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(94, 25);
            this.btnView.TabIndex = 46;
            this.btnView.Text = "주문 보기";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Crimson;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(212, 562);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(85, 25);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "메인";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 630);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderdate);
            this.Controls.Add(this.CustId);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
        private Guna.UI2.WinForms.Guna2TextBox OrderIdTb;
        private Guna.UI2.WinForms.Guna2TextBox CustId;
        private Guna.UI2.WinForms.Guna2DateTimePicker orderdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SearchCombo;
        private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox QtyTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox CustName;
        private Guna.UI2.WinForms.Guna2DataGridView OrderGv;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnHome;
    }
}