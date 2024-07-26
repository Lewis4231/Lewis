using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeManagement.AllUserControls
{
    public partial class UC_Additems : UserControl
    {
        function fn = new function();
        String query;
        public UC_Additems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int s = 0;
            bool a = false;
            a = int.TryParse(txtPrice.Text, out s);
            if (txtCategory.Text == "")
            {
                MessageBox.Show("Select category!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "" || a == false || int.Parse(txtPrice.Text) < 0) MessageBox.Show("Insert price!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else if (txtItemName.Text == "") MessageBox.Show("Insert Name!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else { 
                //쿼리에 데이터 입력
                query = "insert into items (name, category, price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "','"+txtPrice.Text+"')";
            fn.setData(query);            
            clearAll();
            }
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear(); ;
            txtPrice.Clear();
        }

        private void UC_Additems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
