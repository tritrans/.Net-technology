using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai06
{
    public partial class nhaphocvienmoi : Form
    {
        string _hoten;
        string _lop;

        public nhaphocvienmoi()
        {
            InitializeComponent();
            hoten=string .Empty;    
            lop=string .Empty;  
        }
        public string hoten { get => _hoten; set => _hoten = value; }
        public string lop { get => _lop; set => _lop = value; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cn_Click(object sender, EventArgs e)
        {
            hoten=txt_ht.Text;
            lop=cbo_lop.SelectedItem.ToString();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
            bai3 b= new bai3();
            b.Show();
        }
    }
}
