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
    public partial class ViewOrders : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=교수용PC; database=Inventorydb; Integrated Security=True");
        public ViewOrders()
        {
            InitializeComponent();
        }
        void populateorders()
        {
            try
            {
                Con.Open();
                string Myquery = "Select * from OrdersTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrdersGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateorders();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("주문 내역",new Font("Century", 25,FontStyle.Bold),Brushes.Crimson,new Point(230));
            e.Graphics.DrawString("주문 아이디 : " + OrdersGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("주문자 아이디 : " + OrdersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("주문자 이름 : " + OrdersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("주문 날짜 : " + OrdersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("총 액 : " + OrdersGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            
        }

        private void OrdersGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
