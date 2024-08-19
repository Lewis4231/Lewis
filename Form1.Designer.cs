namespace InventoryManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.UnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblClear);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.PasswordTb);
            this.panel1.Controls.Add(this.UnameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(143, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 332);
            this.panel1.TabIndex = 0;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Location = new System.Drawing.Point(214, 0);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(28, 28);
            this.guna2CircleButton1.TabIndex = 1;
            this.guna2CircleButton1.Text = "x";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagement.Properties.Resources.Ex;
            this.pictureBox1.Location = new System.Drawing.Point(62, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.Crimson;
            this.lblClear.Location = new System.Drawing.Point(27, 298);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(43, 16);
            this.lblClear.TabIndex = 3;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(26, 235);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.White;
            this.PasswordTb.Location = new System.Drawing.Point(26, 192);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(190, 22);
            this.PasswordTb.TabIndex = 3;
            // 
            // UnameTb
            // 
            this.UnameTb.BackColor = System.Drawing.Color.DodgerBlue;
            this.UnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameTb.ForeColor = System.Drawing.Color.White;
            this.UnameTb.Location = new System.Drawing.Point(26, 154);
            this.UnameTb.Name = "UnameTb";
            this.UnameTb.Size = new System.Drawing.Size(190, 22);
            this.UnameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox UnameTb;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}

