using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //게스트 입장시
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //로그인 성공시 대시보드 Show
            if(txtUsername.Text=="Admin" && txtPassword.Text == "123")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            if(txtUsername.Text != "Admin")
            {
                MessageBox.Show("Check your ID!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if( txtUsername.Text == "Admin" && txtPassword.Text != "123")
            {
                MessageBox.Show("Check your password!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        private Point mousePoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(Left - (mousePoint.X - e.X), Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
