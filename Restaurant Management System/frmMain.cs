using RM.Model;
using RM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        } 

        static frmMain _obj;

        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        // Methord to add Controls in Main Form
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();  //ControlsPanel을 모두 Clear
            f.Dock = DockStyle.Fill;  //부모 레이아웃을 적용할지말지
            f.TopLevel = false;    //맨윗줄 표시할지말지
            ControlsPanel.Controls.Add(f); //f를 추가해라
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e) //나가기 클릭했을때 종료
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e) //
        {
            lblUser.Text = MainClass.USER;  //lblUser네임을 가진개체를 MainClass에 USER로 바꾸삼
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());     //홈클릭했을때 frmHome으로~
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            AddControls(new frmKitchenView());
        }

        private void ControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AddControls(new frmReports());
        }
    }
}
