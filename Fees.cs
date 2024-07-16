using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeVideo
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            //Enter/ESC 키 작동하기
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Fees_KeyDown);
        }

        private void Fees_KeyDown(object sender, KeyEventArgs e)
        {
            //Enter/ESC 키 작동하기

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
               btnSubmit.PerformClick();
            }
        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            //txtRegNumber 에 숫자(NAID)가 들어오면 즉시 데이터베이스에 연결해서 해당 데이터를 가져와서 띄어줌
            if (txtRegNumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegNumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS); 
                //DS 데이터에 행이 0이 아니면(하나이상이면) if 문
                if (DS.Tables[0].Rows.Count != 0) 
                {
                    fnameLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    MnameLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationLabel.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else  //데이터가 없으면 else
                {
                    fnameLabel.Text = "___________";
                    MnameLabel.Text = "___________";
                    durationLabel.Text = "___________";
                }
            }
            else  //데이터가 없으면 else
            {
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "___________";
                MnameLabel.Text = "___________";
                durationLabel.Text = "___________";
            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = " + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count == 0)
            {
                //Submit 버튼 클릭시 데이터베이스에 저장하기
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;

                cmd1.CommandText = "insert into fees (NAID,fees) Values (" + txtRegNumber.Text + "," + txtFees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Submition Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {  //데이터 저장하고 다시 초기화 하기
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "___________";
                    MnameLabel.Text = "___________";
                    durationLabel.Text = "___________";
                }
            }
            else
            {
                MessageBox.Show("Fees is AllReady Submitted.");
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "___________";
                MnameLabel.Text = "___________";
                durationLabel.Text = "___________";
            }
        }
    }
}
