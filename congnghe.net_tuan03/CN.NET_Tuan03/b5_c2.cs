using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CN.NET_Tuan03
{
    public partial class b5_c2 : Form
    {
        public b5_c2()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mông", "Khác" };
            foreach(string s in dt)
            {
                cbo_dt.Items.Add(s);
            }
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            string s = " Dân tộc được chọn là:";
            if (cbo_dt.SelectedIndex >= 0)
            {
                lbl_kq.Text = s + cbo_dt.SelectedItem.ToString();
            }
            else lbl_kq.Text = "Bạn chưa chọn dân tộc";
        }

        private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn :" + cbo_dt.SelectedItem.ToString());
        }
    }
}
