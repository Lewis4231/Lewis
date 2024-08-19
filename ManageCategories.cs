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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=교수용PC; database=Inventorydb; Integrated Security=True");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("Insert into CategoryTbl Values('" + CatIdTb.Text + "','" + CatNameTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다!");
                Con.Close();
                populate();
                CatIdTb.Text = "";
                CatNameTb.Text = "";
            }
            catch
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CatIdTb.Text == "")
            {
                MessageBox.Show("물품 아이디를 입력하세요.");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTbl where CatId = '" + CatIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제되었습니다!");
                Con.Close();
                populate();
                CatIdTb.Text = "";
                CatNameTb.Text = "";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update CategoryTbl set CatName ='" + CatNameTb.Text + "' where CatId = '" + CatIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("변경되었습니다!");
                Con.Close();
                populate();
                CatIdTb.Text = "";
                CatNameTb.Text = "";
            }
            catch
            {

            }
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
