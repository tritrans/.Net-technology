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
    public partial class btnc1 : Form
    {
        public btnc1()
        {
            InitializeComponent();
            txt_tt.ReadOnly = true;
        }
        List<Button> lst_ds_btnchon = new List<Button>();
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn=  (Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    lst_ds_btnchon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    lst_ds_btnchon.Remove(btn);
                }
            }
            else
                MessageBox.Show("Ghế đã được chọn!");
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            int thanhtien = 0;
            foreach (Button btn in lst_ds_btnchon)
            {
                btn.BackColor = Color.Yellow;
                if (btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5") 
                {
                    thanhtien += 1000;
                } else if(btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "10")
                {
                    thanhtien += 1500;
                }
                else
                {
                    thanhtien += 2000;
                }
            }
            txt_tt.Text=thanhtien.ToString();
            lst_ds_btnchon= new List<Button>(); 
        }

        private void btn_kt_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            foreach (Button btn in lst_ds_btnchon)
            {
                if (btn.BackColor == Color.Yellow)
                {
                    
                }
            }
        }
    }
}
