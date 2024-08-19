using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
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
                string Myquery = "Select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void populateproducts()
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
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        void updateproduct()
        {
            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0) MessageBox.Show("실패하였습니다!");
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProdQty = '" + newQty + "' where ProdId='" + id + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
        }

        int num = 0;
        int uprice, totprice, qty;
        int flag = 0;
        int stock;
        string product;
        DataTable table = new DataTable();

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillcategory();
            table.Columns.Add("순서", typeof(int));
            table.Columns.Add("상품명", typeof(string));
            table.Columns.Add("수량", typeof(int));
            table.Columns.Add("상품 가격", typeof(int));
            table.Columns.Add("총 가격", typeof(int));
        }

        private void ProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            //qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            //totprice = qty * uprice;
            flag = 1;
        }


        //private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
        //    //qty = Convert.ToInt32(QtyTb.Text);
        //    stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
        //    uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
        //    //totprice = qty * uprice;
        //    flag = 1;
        //}
        int sum = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "") MessageBox.Show("수량을 입력하세요!");
            else if (flag == 0) MessageBox.Show("상품을 선택하세요!");
            else if (Convert.ToInt32(QtyTb.Text) > stock) 
            { 
                MessageBox.Show("재고가 부족합니다!");

                QtyTb.Text = "";
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;

                table.Rows.Add(num, product, qty, uprice, totprice);

                updateproduct();

                OrderGv.DataSource = table;
                flag = 0;
                QtyTb.Text = "";
            }
            sum += totprice;
            TotAmount.Text = sum.ToString()+" 원";


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == "" || CustId.Text == "" || CustName.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("빈칸을 채우세요");
            }
            else
            {
                string dt = orderdate.Value.ToString("yyyy-MM-dd");
                //string dt = orderdate.Value.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into OrdersTbl Values('" + OrderIdTb.Text + "','" + CustId.Text + "','" + CustName.Text + "','" + dt + "'," + sum + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다!");
                Con.Close();
                OrderGv.DataSource = null;
                //populate();
                try
                {

                }
                catch
                {

                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
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
    }

    
}
