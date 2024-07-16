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
    public partial class StudentIndividualDetail : Form
    {
        public StudentIndividualDetail()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(btnShowDetails_KeyDown);
        }
        private void btnShowDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnShowDetails.PerformClick();
            }
        }
        private void StudentIndividualDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0 )
            {
                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelMName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelStandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelSName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found","No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelFullName.Text = "--------------";
                labelMName.Text = "--------------";
                labelGender.Text = "--------------";
                labelDOB.Text = "--------------";
                labelMobile.Text = "--------------";
                labelEmail.Text = "--------------";
                labelStandard.Text = "--------------";
                labelMedium.Text = "--------------";
                labelSName.Text = "--------------";
                labelYear.Text = "--------------";
                labelAddress.Text = "--------------";
                textBox1.Clear();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "--------------";
            labelMName.Text = "--------------";
            labelGender.Text = "--------------";
            labelDOB.Text = "--------------";
            labelMobile.Text = "--------------";
            labelEmail.Text = "--------------";
            labelStandard.Text = "--------------";
            labelMedium.Text = "--------------";
            labelSName.Text = "--------------";
            labelYear.Text = "--------------";
            labelAddress.Text = "--------------";
            textBox1.Clear();
        }
    }
}
