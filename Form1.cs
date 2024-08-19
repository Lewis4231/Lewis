using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=교수용PC; database=Inventorydb; Integrated Security=True");
        public Form1()
        {
            InitializeComponent();

            UnameTb.ForeColor = Color.Gray;
            UnameTb.Text = "Username";
            PasswordTb.ForeColor = Color.Gray;
            PasswordTb.Text = "Password";

            UnameTb.Enter += RemoveTextID;            
            UnameTb.Leave += AddTextID;
            PasswordTb.Enter += RemoveTextPW;
            PasswordTb.Leave += AddTextPW;
        }
        private void AddTextID(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UnameTb.Text))
            {
                UnameTb.Text = "Username";
                UnameTb.ForeColor = Color.Gray;
            }
        }
        private void AddTextPW(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                PasswordTb.Text = "Password";
                PasswordTb.ForeColor = Color.Gray;
            }
        }

        private void RemoveTextID(object sender, EventArgs e)
        {
            if (UnameTb.Text == "Username")
            {
                UnameTb.Text = "";
                UnameTb.ForeColor = Color.Black;
            }
        }
        private void RemoveTextPW(object sender, EventArgs e)
        {
            if (PasswordTb.Text == "Password")
            {
                PasswordTb.Text = "";
                PasswordTb.ForeColor = Color.Black;
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            UnameTb.ForeColor = Color.Gray;
            PasswordTb.ForeColor = Color.Gray;
            UnameTb.Text = "Username";
            PasswordTb.Text = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserTbl Where Uname = '" + UnameTb.Text + "' and Upassword = '" + PasswordTb.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다!");
            }
            Con.Close();
        }
    }
}
