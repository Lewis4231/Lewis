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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(AddTeacher_KeyDown);
        }
        private void AddTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radioMale.Checked;
            if ((isChecked))
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher(fname,gender,dob,mobile,email,semester,prog,yer,adr) Values('" + txtFName.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "'," +
                "'" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtSemester.Text + "','" + txtProgramming.Text + "','" + txtDuration.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.","Success",MessageBoxButtons.OK , MessageBoxIcon.Information);

            txtFName.Clear();
            radioFemale.Checked = false;
            radioMale.Checked = false;
            dateTimePickerDOB.Text = "";
            txtMobile.Clear();
            txtEmail.Clear();
            txtSemester.Text = "--select--";
            txtProgramming.Text = "--select--";
            txtDuration.Text = "--select--";
            txtAddress.Clear();
        }

    }
}
