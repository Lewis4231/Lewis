using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Enter/ESC 키 작동하기
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            menuStrip1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   //로그인 하기
            String username = textBox1.Text;
            String password = textBox2.Text;

            if(username == "student" && password == "student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid userid or password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   //Enter/ESC 키 작동하기

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {   //NEW admission tool strip 눌렀을때 New Admission 윈폼 띄우기
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetail sid = new StudentIndividualDetail();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUS uS = new AboutUS();
            uS.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
