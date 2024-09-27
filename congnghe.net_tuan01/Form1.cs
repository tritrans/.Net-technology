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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // show ra tuổi
        private void btn_show_Click(object sender, EventArgs e)
        {
            string ten = txt_your.Text;
            int namsinh = int.Parse(txt_year.Text);
            int tuoi = DateTime.Now.Year - namsinh;
            string chuoi = "My name is : " + ten + "\nAge:" + tuoi;
            MessageBox.Show(chuoi);
        }
        //xóa và có dấu cách
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_your.Clear();
            txt_year.Clear();
            txt_your.Focus();
        }
        // thoát hết
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // đặt câu hỏi khi thoát 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r== DialogResult.No)
            {
                e.Cancel = true;
            }
        
        }
        // buộc nhập thông tin
        private void txt_your_Leave(object sender, EventArgs e)
        {
            if (txt_your.Text == string.Empty)
            {
                errorProvider1.SetError(txt_your, "Bạn cần nhập thông tin cho your name!!");
                txt_your.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        // buộc nhập số 
        private void txt_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            // \b là phím backspace
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
