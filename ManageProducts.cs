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

namespace InventoryManagement
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }        
        SqlConnection Con = new SqlConnection(@"Data Source=교수용PC; database=Inventorydb; Integrated Security=True");

        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }       
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into ProductTbl Values('" + ProdIdTb.Text + "','" + ProdNameTb.Text + "','" + QtyTb.Text + "','" + PriceTb.Text + "','" + DescriptionTb.Text + "','"+CatCombo.SelectedValue.ToString()+"')", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("저장되었습니다!");
            Con.Close();
            populate();
            ProdIdTb.Text = "";
            ProdNameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            DescriptionTb.Text = "";
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from ProductTbl Where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(ProdIdTb.Text == "")
            {
                MessageBox.Show("상품 아이디를 입력하세요.");
            }
            else
            {
                Con.Open();
                string Myquery = "Delete from ProductTbl Where ProdId='" + ProdIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제되었습니다!");
                Con.Close();
                populate();
                ProdIdTb.Text = "";
                ProdNameTb.Text = "";
                QtyTb.Text = "";
                PriceTb.Text = "";
                DescriptionTb.Text = "";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTbl set ProdName='" + ProdNameTb.Text + "',ProdQty='" + QtyTb.Text + "',ProdPrice='" + PriceTb.Text + "',ProdDesc='" + DescriptionTb.Text + "',ProdCat='" + CatCombo.SelectedValue.ToString() + "' Where ProdId='"+ProdIdTb.Text+"'", Con);
                cmd.ExecuteNonQuery( );
                MessageBox.Show("변경되었습니다!");
                Con.Close();
                populate();
                ProdIdTb.Text = "";
                ProdNameTb.Text = "";
                QtyTb.Text = "";
                PriceTb.Text = "";
                DescriptionTb.Text = "";
            }
            catch
            {

            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            QtyTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            DescriptionTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
