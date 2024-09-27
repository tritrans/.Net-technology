using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congnghe.net
{
    public partial class bt2 : Form
    {
        public bt2()
        {
            InitializeComponent();
        }

        

        private void btn_cong_Click(object sender, EventArgs e)
        {
            double sa = double.Parse(txt_ba.Text);
            double sb = double.Parse(txt_bb.Text);
            double kq = sa + sb;
            txt_kq.Text = kq.ToString();

        }
    }
}
