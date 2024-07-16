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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(RemoveStudent_KeyDown);
        }
        private void RemoveStudent_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        
    

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewDEIStudent.DataSource = ds.Tables[0];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE your data.", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = 교수용PC; database = college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewAdmission where NAID = " + txtRegID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewDEIStudent.DataSource = ds.Tables[0];
                
                MessageBox.Show("Successfully Deleted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                txtRegID.Clear();
                
            }
            
        }        
    }
}
