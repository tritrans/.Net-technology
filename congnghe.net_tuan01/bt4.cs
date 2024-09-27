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
    public partial class bt4 : Form
    {
        public bt4()
        {
            InitializeComponent();
            txt_d.ReadOnly = true;
            txt_tong.ReadOnly = true;
            txt_tongl.ReadOnly = true;
            txt_tongc.ReadOnly = true;  
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            string currenttext = txt_d.Text;
            string newnumber = txt_ns.Text.Trim();
            if (!string.IsNullOrEmpty(currenttext) && !string.IsNullOrEmpty(newnumber))
            {
                currenttext += ",";
            }
            txt_d.Text = currenttext + newnumber;
            txt_ns.Clear();
            txt_ns.Focus();

        }



        private void btn_tt_Click(object sender, EventArgs e)
        {
            txt_ns.Clear();
            txt_ns.Focus();
            txt_d.Clear();
            txt_tong.Clear();
            txt_tongc.Clear();
            txt_tongl.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát không???", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (r == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btn_tong_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var numbers=txt_d.Text.Split(new[] { ',' },StringSplitOptions.RemoveEmptyEntries)
                .Select(n=>n.Trim())
                .Where (n=> int. TryParse(n,out _))
                .Select(int.Parse)
                .ToArray();

            if(numbers.Length==0)
            {
                MessageBox.Show("vui lòng nhập dãy số hợp lệ.","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }    
            int sum=numbers.Sum();
            int sumeven = numbers.Where (n=>n%2==0).Sum();
            int sumodd=numbers.Where (n=>n%2!=0).Sum(); 
            txt_tong.Text = sum.ToString();
            txt_tongc.Text = sumeven.ToString();
            txt_tongl.Text = sumodd.ToString(); 

        }
    }
    
}
