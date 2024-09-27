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
    public partial class bai6_cau01_tl : Form
    {
        public bai6_cau01_tl()
        {
            InitializeComponent();
        }
        List<sinhvien> danhSachSinhVien = new List<sinhvien>();
        private void bai6_cau01_tl_Load(object sender, EventArgs e)
        {
            List<string> danTocList = new List<string>()
            {
                "Kinh", "Tày", "Thái", "Hoa", "Khơ-me", "Mường", "Nùng", "H'mông", "Dao", "Gia Rai",
                "Ê Đê", "Ba Na", "Xơ Đăng", "Sán Chay", "Cơ Ho", "Chăm", "Sán Dìu", "Hrê", "Ra Glai",
                "M'Nông", "Xtiêng", "Bru - Vân Kiều", "Thổ", "Giẻ-Triêng", "Chơ Ro", "Cơ Tu", "Giáy",
                "Tà Ôi", "Mạ", "Khơ Mú", "Co", "La Chí", "Phù Lá", "La Hủ", "Chứt", "Lự", "Lào",
                "La Ha", "Pà Thẻn", "Ngái", "Cống", "Si La", "Pu Péo", "Rơ Măm", "Brâu", "Ơ Đu"
            };
            foreach (string danToc in danTocList)
            {
                cmb_dantoc.Items.Add(danToc);
            }
            cmb_dantoc.SelectedIndex = 0;
            rdio_nam.Checked = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string hoTen = txt_ht.Text;
            string maSinhVien = txt_sv.Text;
            string gioiTinh = rdio_nam.Checked ? "Nam" : "Nữ";

            string ngoaiNgu = "";
            if (chk_anh.Checked) ngoaiNgu += "Anh ";
            if (chk_phap.Checked) ngoaiNgu += "Pháp ";
            if (chk_hoa.Checked) ngoaiNgu += "Hoa ";
            string danToc = cmb_dantoc.SelectedItem.ToString();
            if (danhSachSinhVien.Any(SinhVien => SinhVien.masinhvien == maSinhVien))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.");
                return;
            }
            sinhvien sv = new sinhvien(hoTen, maSinhVien, gioiTinh, ngoaiNgu, danToc);
            danhSachSinhVien.Add(sv);
            ListViewItem item = new ListViewItem(new[] { hoTen, maSinhVien, gioiTinh, ngoaiNgu, danToc });
            lst_ds.Items.Add(item);
            ResetForm();
        }
        private void ResetForm()
        {
            txt_ht.Clear();
            txt_sv.Clear();
            rdio_nam.Checked = true;
            chk_anh.Checked = false;
            chk_phap.Checked = false;
            chk_hoa.Checked = false;
            cmb_dantoc.SelectedIndex = 0;
            txt_sv.Enabled = true; // Bật lại mã sinh viên khi thêm mới
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (lst_ds.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_ds.SelectedItems[0];
                string maSinhVien = selectedItem.SubItems[1].Text;

                // Tìm sinh viên trong danh sách sinh viên
                sinhvien sv = danhSachSinhVien.FirstOrDefault(SinhVien => SinhVien.masinhvien == maSinhVien);
                if (sv != null)
                {
                    // Cập nhật thông tin (không cho sửa mã sinh viên)
                    sv.hoVaTen = txt_ht.Text;

                    // Cập nhật giới tính
                    sv.gioitinh = rdio_nam.Checked ? "Nam" : "Nữ";

                    sv.ngoaingu = (chk_anh.Checked ? "Anh " : "") + (chk_phap.Checked ? "Pháp " : "") + (chk_hoa.Checked ? "Hoa " : "");
                    sv.dantoc = cmb_dantoc.SelectedItem.ToString();

                    // Cập nhật thông tin trên ListView
                    selectedItem.SubItems[0].Text = sv.hoVaTen;
                    selectedItem.SubItems[2].Text = sv.gioitinh;
                    selectedItem.SubItems[3].Text = sv.ngoaingu;
                    selectedItem.SubItems[4].Text = sv.dantoc;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
            }
            ResetForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lst_ds.SelectedItems.Count > 0)
            {
                // Hỏi xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ListViewItem selectedItem = lst_ds.SelectedItems[0];
                    string maSinhVien = selectedItem.SubItems[1].Text;

                    // Xóa sinh viên khỏi danh sách danhSachSinhVien
                    sinhvien sv = danhSachSinhVien.FirstOrDefault(SinhVien => SinhVien.masinhvien == maSinhVien);
                    if (sv != null)
                    {
                        danhSachSinhVien.Remove(sv);
                    }

                    // Xóa dòng khỏi ListView
                    lst_ds.Items.Remove(selectedItem);

                    // Đặt lại form sau khi xóa
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
            }
        }

        private void lst_ds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ds.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lst_ds.SelectedItems[0];
                txt_ht.Text = selectedItem.SubItems[0].Text;
                txt_sv.Text = selectedItem.SubItems[1].Text;
                txt_sv.Enabled = false; // Không cho sửa mã sinh viên

                // Hiển thị giới tính dựa trên giá trị trong ListView
                string gioiTinh = selectedItem.SubItems[2].Text;
                if (gioiTinh == "Nam")
                {
                    rdio_nam.Checked = true;
                }
                else
                {
                    rdo_nu.Checked = true;
                }

                // Hiển thị thông tin ngoại ngữ
                string ngoaiNgu = selectedItem.SubItems[3].Text;
                chk_anh.Checked = ngoaiNgu.Contains("Anh");
                chk_phap.Checked = ngoaiNgu.Contains("Pháp");
                chk_hoa.Checked = ngoaiNgu.Contains("Hoa");

                // Hiển thị dân tộc
                cmb_dantoc.SelectedItem = selectedItem.SubItems[4].Text;
            }
        }

        private void txt_sv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Nếu không phải số hoặc phím điều khiển (như backspace), hủy ký tự
                e.Handled = true;
                MessageBox.Show("Mã sinh viên chỉ được nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
