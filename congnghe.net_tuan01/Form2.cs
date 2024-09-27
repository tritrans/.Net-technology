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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           

                // Đặt TextBox txtKQ thành ReadOnly để khóa không cho nhập kết quả
                txtKQ.ReadOnly = true;
            

        }



        private void btnC_Click(object sender, EventArgs e)
        {
            double soa = double.Parse(txtA.Text);
            double sob = double.Parse(txtB.Text);
            double kq = soa + sob;
            txtKQ.Text = kq.ToString();

        }

        private void btnT_Click(object sender, EventArgs e)
        {
            double soa = double.Parse(txtA.Text);
            double sob = double.Parse(txtB.Text);
            double kq = soa - sob;
            txtKQ.Text = kq.ToString();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            double soa = double.Parse(txtA.Text);
            double sob = double.Parse(txtB.Text);
            double kq = soa * sob;
            txtKQ.Text = kq.ToString();
        }

        private void btnCh_Click(object sender, EventArgs e)
        {
            double soa = double.Parse(txtA.Text);
            double sob = double.Parse(txtB.Text);
            double kq = soa /sob;
            if (sob==0)
            {
                errorProvider1.SetError(txtB, "Bạn cần nhập B khác 0!!");
                txtB.Focus();
            }
            else
            {
                txtKQ.Text = kq.ToString();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
