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
    public partial class bai6_c2_tl : Form
    {
        public bai6_c2_tl()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_msv.Text.Length == 0)
            {
                MessageBox.Show("Mời nhập mã số sinh viên");
                txt_msv.Focus();
                return;
            }
            if (txt_ht.Text.Length == 0)
            {
                MessageBox.Show("Mời nhập mã số sinh viên");
                txt_ht.Focus();
                return;
            }
            lst_ds.Items.Add((lst_ds.Items.Count + 1).ToString()).SubItems.AddRange(new[] { txt_msv.Text, txt_ht.Text });
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem l in lst_ds.Items)
            {
                l.Remove();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(lst_ds.FocusedItem != null&& lst_ds.FocusedItem.Index >= 0)
            {
                ListViewItem item= lst_ds.FocusedItem;
                item.SubItems[1].Text = txt_msv.Text;
                item.SubItems[2].Text = txt_ht.Text;
            }
        }
    }
}
