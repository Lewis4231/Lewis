using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeVideo
{
    public partial class UpgradeSemester : Form
    {
        public UpgradeSemester()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(UpgradeSemester_KeyDown);
        }

        private void UpgradeSemester_KeyDown(object sender, KeyEventArgs e)
        {  //Enter / ESC 키 눌렀을때
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                btnUpgrade.PerformClick();
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {   //업그레이드 버튼 눌렀을때 메시지 박스 띄우고 OK시에 데이터베이스 연결하여 업그레이드함
            if(MessageBox.Show("Semester update Warning!","Confirm?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewAdmission set semester = '" + comboBoxTo.Text + "' where semester = '" + comboBoxFrom.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Successfully Upgraded!", "Cogratulation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Upgrade Cancelled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
