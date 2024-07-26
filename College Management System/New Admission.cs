using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CollegeVideo
{
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
            //Enter/ESC 키 작동하기
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(New_Admission_KeyDown);
        }

        private void New_Admission_KeyDown(object sender, KeyEventArgs e)
        {  //ESC로 창나가기
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   //SAVE 버튼눌렀을때 데이터베이스와 연결해서 데이터베이스에 데이터 저장하기
            String name = txtFullName.Text;
            String mname = txtMotherName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program = txtProgramming.Text;
            String sname = txtSchoolName.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission(fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres) Values ('" + 
                            name + "','" + mname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + 
                            program + "','" + sname + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet(); 
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID","Important!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //저장후 모두 초기화
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.ResetText();
            txtDuration.ResetText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {   //RESET 버튼 눌렸을때 모두 초기화
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.ResetText();
            txtDuration.ResetText();
        }
        
        private void New_Admission_Load(object sender, EventArgs e)
        {   //NEW ADMISSION 창 로드시 데이터 베이스와 연동하여
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission"; //max 는 데이터 베이스에 저장된 NAID 중 가장 큰값 - 가져오기

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label14.Text = (abc+1).ToString();  //max 값에 +1 함으로써 몇번째 등록학생인지 알려줌
        }
    }
}
