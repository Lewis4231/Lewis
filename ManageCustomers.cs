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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
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
                string MyQuery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + Customerid.Text + "','" + CustomernameTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("저장되었습니다!");
                Con.Close();
                populate();
                Customerid.Text = "";
                CustomernameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
            catch
            {

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Customerid.Text == "")
            {
                MessageBox.Show("아이디를 입력하세요.");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where CustId = '" + Customerid.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("삭제되었습니다!");
                Con.Close();
                populate();
                Customerid.Text = "";
                CustomernameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customerid.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomernameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from OrdersTbl where CustId = " + Customerid.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();
            
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Sum(TotalAmt) from OrdersTbl where CustId = " + Customerid.Text + "", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();
            Con.Close();

            SqlDataAdapter sda2 = new SqlDataAdapter("Select Max(OrderDate) from OrdersTbl where CustId = " + Customerid.Text + "", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update CustomerTbl set CustName ='" + CustomernameTb.Text + "',CustPhone='" + CustomerPhoneTb.Text + "' where CustId = '"+Customerid.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("변경되었습니다!");
                Con.Close();
                populate();
                Customerid.Text = "";
                CustomernameTb.Text = "";
                CustomerPhoneTb.Text = "";
            }
            catch
            {

            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
