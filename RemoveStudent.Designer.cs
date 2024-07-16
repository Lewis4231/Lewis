namespace CollegeVideo
{
    partial class RemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveStudent));
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegID = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridViewDEIStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDEIStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(190, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(279, 35);
            this.label10.TabIndex = 11;
            this.label10.Text = "Delete Student Record";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registration ID";
            // 
            // txtRegID
            // 
            this.txtRegID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegID.Location = new System.Drawing.Point(261, 128);
            this.txtRegID.Name = "txtRegID";
            this.txtRegID.Size = new System.Drawing.Size(190, 30);
            this.txtRegID.TabIndex = 14;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(376, 164);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 40);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGridViewDEIStudent
            // 
            this.dataGridViewDEIStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDEIStudent.Location = new System.Drawing.Point(12, 210);
            this.dataGridViewDEIStudent.Name = "dataGridViewDEIStudent";
            this.dataGridViewDEIStudent.RowTemplate.Height = 23;
            this.dataGridViewDEIStudent.Size = new System.Drawing.Size(630, 273);
            this.dataGridViewDEIStudent.TabIndex = 16;
            // 
            // RemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 495);
            this.Controls.Add(this.dataGridViewDEIStudent);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtRegID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveStudent";
            this.Load += new System.EventHandler(this.RemoveStudent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveStudent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDEIStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegID;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridViewDEIStudent;
    }
}