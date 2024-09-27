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
    public partial class b5_c3 : Form
    {
        public b5_c3()
        {
            InitializeComponent();
        }

        private void b5_c3_Load(object sender, EventArgs e)
        {
            string[] pb = { "Giám đốc","Tổ chức hành chính","Kế hoạch","Kế toán" };
            foreach(string s in pb)
            {
                tr_p.Nodes.Add(s);// thêm node vào streeview
                cbo_pb.Items.Add(s);//thêm items vào combobox
            }
            cbo_pb.SelectedIndex = 0;// items đầu trên đc chọn
        }

        private bool kiemtra(string s)
        {
            foreach (var item in cbo_pb.Items)
            {
                // So sánh không phân biệt chữ hoa/chữ thường
                if (String.Compare(item.ToString(), s, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return true; // Phòng ban đã tồn tại
                }
            }
            return false; // Phòng ban không bị trùng
        }

        private void btn_themp_Click(object sender, EventArgs e)
        {
            if (kiemtra(txt_pb1.Text)==false)
            {
                tr_p.Nodes.Add(txt_pb1.Text);
                cbo_pb.Items.Add(txt_pb1.Text);
            }
            else
            {
                MessageBox.Show("Phòng ban đã tồn tại");
                txt_pb1.Text = "";
                txt_pb1.Focus();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không????","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                // Một phòng ban trong view được chọn
                if(tr_p.SelectedNode != null)
                {
                    cbo_pb.Items.Remove(tr_p.SelectedNode.Text);
                    tr_p.Nodes.Remove(tr_p.SelectedNode);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // tìm index của node có nội dung là item được chọn trong combobox phòng ban
            int index = -1;
            foreach(TreeNode node in tr_p.Nodes)
            {
                if (node.Text == cbo_pb.Text)
                {
                    index = node.Index;
                    break;
                }
            }

            tr_p.Nodes[index].Nodes.Add(txt_hoten.Text + "(" + txt_maso.Text + ")");
            tr_p.ExpandAll();
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
