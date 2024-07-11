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
    public partial class UC_UpdateItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        { //그리드 뷰에 아이템 속성 띄우기
            loadData();
        }
        public void loadData()
        {
            query = "select *from items";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        { //검색창에서 검색가능하게 하기
            query = "select * from items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { //구나그리드 셀클릭시 개별값들 String/Int 로 변환해서 아래 텍스트 박스에 표시하기
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        { //업데이트 버튼 클릭시, 텍스트 박스에서 수정된 사항을 데이터 베이스에 저장
            query = "update items set name = '" + txtName.Text + "',category = '" + txtCategory.Text + "',price = " + txtPrice.Text + " where iid = "+id+"";
            fn.setData(query);
            loadData(); //수정된 사항을 실시간으로 확인하기 위해 데이터를 다시 불러옴

            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }

        private void UC_UpdateItems_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
