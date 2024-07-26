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
    public partial class SampleView : Form
    {
        public SampleView()
        {
            InitializeComponent();
        }

        public virtual void btnAdd_Click(object sender, EventArgs e)
        //상속할때 부모는 Virtual 자식은 Override
        {

        }

        public virtual void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
