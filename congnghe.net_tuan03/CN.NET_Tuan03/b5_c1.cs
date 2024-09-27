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
    public partial class b5_c1 : Form
    {
        public b5_c1()
        {
            InitializeComponent();
        }

        private void btn_t_p1_Click(object sender, EventArgs e)
        {
            if (lst_t.SelectedIndex>=0)
            {
                lst_p.Items.Add(lst_t.SelectedItem);
                lst_t.Items.Remove(lst_t.SelectedItem);
            }
            else
            {
                MessageBox.Show("Chưa chọn");
            }
            
        }

        private void btn_t_pn_Click(object sender, EventArgs e)
        {
            lst_p.Items.AddRange(lst_t.Items);
            lst_t.Items.Clear();
        }

        private void btn_p_t1_Click(object sender, EventArgs e)
        {
            if (lst_p.SelectedIndex >= 0)
            {
                lst_t.Items.Add(lst_p.SelectedItem);
                lst_p.Items.Remove(lst_p.SelectedItem);
            }
            else
            {
                MessageBox.Show("Chưa chọn");
            }
        }

        private void btn_p_tn_Click(object sender, EventArgs e)
        {
            lst_t.Items.AddRange(lst_p.Items);
            lst_p.Items.Clear();
        }

        private void btn_t_pall_Click(object sender, EventArgs e)
        {
            foreach(var item in lst_t.SelectedItems)
            {
                lst_p.Items.Add(item);
            }
            for(int i = lst_t.SelectedItems.Count - 1; i >= 0; i--)
            {
                lst_t.Items.Remove(lst_t.SelectedItems[i]);
            }
        }
    }
}
