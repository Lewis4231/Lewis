using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=교수용PC; database=Inventorydb; Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "','" + FnameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다!");
                Con.Close();
                populate();
                unameTb.Text = "";
                FnameTb.Text = "";
                PasswordTb.Text = "";
                PhoneTb.Text = "";
            }
            catch
            {

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(PhoneTb.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where UPhone = '" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제되었습니다!");
                Con.Close();    
                populate();
                unameTb.Text = "";
                FnameTb.Text = "";
                PasswordTb.Text = "";
                PhoneTb.Text = "";
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + unameTb.Text + "',Ufullname='" + FnameTb.Text + "',Upassword='" + PasswordTb.Text + "' where UPhone='" + PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("변경되었습니다!");
                Con.Close();
                populate();
                unameTb.Text = "";
                FnameTb.Text = "";
                PasswordTb.Text = "";
                PhoneTb.Text = "";
            }
            catch
            {

            }
        }

    }
}
