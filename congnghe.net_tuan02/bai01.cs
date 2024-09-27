using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congnghe.net_tuan02
{
    public partial class bai01 : Form
    {
        public bai01()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            
            float soa = float.Parse(txtA.Text);
            float sob = float.Parse(txtB.Text);
            tinhtoan_bai01 dt = new tinhtoan_bai01(soa, sob);
            if (rdo_cong.Checked)
            {
                txtKQ.Text = dt.Cong().ToString();
            }
            else if (rdo_tru.Checked) 
            { 
                txtKQ.Text = dt.Tru().ToString(); 
            }
            else if (rdo_nhan.Checked) { txtKQ.Text = dt.nhan().ToString(); }
            else if (sob != 0) { txtKQ.Text = dt.Chia().ToString(); }
            else MessageBox.Show("phép chia bị lỗi!!!");
        
        }

        //private void bai01_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
        //    if (r == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_tt_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
    }
}
