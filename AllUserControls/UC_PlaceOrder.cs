using DGVPrinterHelper;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        public UC_PlaceOrder()
        {
            InitializeComponent();
        }
        

        //데이터베이스에서 데이터 불러오기
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'";
            showItemList(query);
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {//검색창에서 검색하기
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'and name like '"+txtSearch.Text+"%'";
            showItemList(query);
        }
        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //리스트 박스에서 컨텐츠 선택시 Name, Price 나타내기
            txtQuantityUpDown.Value = 0;
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = $"select price from items where name = '{text}'";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }       

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            if (txtPrice.Text != "")
            {
                txtQuantityUpDown.Enabled = true;
                //수량과 가격을 곱해서 Total에 표시하기
                Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
                Int64 price = Int64.Parse(txtPrice.Text);
                txtTotal.Text = (quan * price).ToString();
            }            
                             
        }
        protected int n = 0;
        protected int total = 0;
         
        private void btnAddtoCart_Click(object sender, EventArgs e)
        { //AddtoCart버튼 눌렀을때 그리드뷰에 아이템 추가하기

            bool rowUpdated = false;

            if(txtQuantityUpDown.Text == "" || txtQuantityUpDown.Text == "0")
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {//여기서 중복되는 상품이 더해질경우 행 추가 하지 않고 수량과 총합만 계속 더하기   
                if (txtItemName.Text == guna2DataGridView1.Rows[n].Cells[0].Value.ToString())
                {
                    int currentQuantity = Convert.ToInt32(guna2DataGridView1.Rows[n].Cells[2].Value);
                    int currentTotal = Convert.ToInt32(guna2DataGridView1.Rows[n].Cells[3].Value);
                    guna2DataGridView1.Rows[n].Cells[2].Value = currentQuantity + Convert.ToInt32(txtQuantityUpDown.Value);
                    guna2DataGridView1.Rows[n].Cells[3].Value = currentTotal + Convert.ToInt32(txtTotal.Text);
                    rowUpdated = true;
                    break;
                }
            }
            if (!rowUpdated)
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Rs. " + total;
            }

            txtQuantityUpDown.Text = "0";




        }
        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //총합 
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }
        
        private void btnRemove_Click(object sender, EventArgs e)
        { //Remove버튼 눌렀을때 행지우기
            
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);                
            }
            catch {  }
            total -= amount;
            labelTotalAmount.Text = "Rs. " + total;
            
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  //사용자가 수정할수없게 만듦
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtQuantityUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        { //프린트하기
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount : " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            labelTotalAmount.Text = "Rs. " + total;
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.CurrentCell = null;
        }
    }
}
