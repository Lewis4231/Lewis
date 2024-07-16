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
    public partial class SearchTeacher : Form
    {
        public SearchTeacher()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(SearchTeacher_KeyDown);
        }
        private void SearchTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void SearchTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from teacher";

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

            cmd.CommandText = "select * from teacher where tID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from teacher";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Clear();
        }


    }
}
