using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //쿼리에 데이터 입력
            query = "insert into items (name, category, price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "','"+txtPrice.Text+"')";
            fn.setData(query);
            clearAll();
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
