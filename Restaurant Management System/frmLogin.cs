using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if(MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false) //아이디 비밀번호 확인
            {
                guna2MessageDialog1.Show("invalid username or password");  //틀림
                return;
            }
            else  //맞음
            {                
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();  //맞으면 frm을 Show해라
            }

            
        }
    }
}
