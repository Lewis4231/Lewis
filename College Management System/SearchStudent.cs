using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeVideo
{
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(SearchStudent_KeyDown);
        }
        private void SearchStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {  
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select Newadmission.NAID as Student_ID, NewAdmission.fname as Full_name, NewAdmission.mname as Mother_Name," +
                "NewAdmission.gender as Gender,NewAdmission.dob as Date_Of_Birth,NewAdmission.mobile as Mobile,NewAdmission.email as Email_ID," +
                " NewAdmission.semester,NewAdmission.prog as Programming_Language,NewAdmission.sname as School_Name,NewAdmission.duration as " +
                "Course_Duration,NewAdmission.addres as Address,fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=fees.NAID";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
