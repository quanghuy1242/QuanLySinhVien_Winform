using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Controllers;

namespace QuanLySinhVien.Views
{
    public partial class QuanLyNguoiDung : Form
    {
        QuanLyNguoiDungController qlndC;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        bool isCapNhat = true;

        public QuanLyNguoiDung()
        {
            InitializeComponent();
            qlndC = new QuanLyNguoiDungController();
            dtgvDSND.AutoGenerateColumns = false;
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvDSND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(isCapNhat == false)
            {
                DialogResult rs = MessageBox.Show("Đang thêm mới 1 người dùng, có tiếp tục?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    isCapNhat = true;
                }
                else
                {
                    return;
                }
            }

            dtgvDSND.Rows[dtgvDSND.SelectedCells[0].RowIndex].Selected = true;
            if (dtgvDSND.SelectedRows.Count == 1)
            {
                qlndC.bindingThongTin(Convert.ToInt32(dtgvDSND.SelectedRows[0].Cells[0].Value),
                                      Convert.ToInt32(dtgvDSND.SelectedRows[0].Cells[1].Value),
                                      txtTen, txtHo, datetimeSN, cbGioiTinh, txtSdt, txtQueQuan, cbTuCach, pbAnh, txtTenDN, txtPass, txtMa,
                                      0);
            }
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadKiemTra();
            dtgvDSND_CellClick(this.dtgvDSND, new DataGridViewCellEventArgs(0, 0)); // Click vô dòng đầu tiên
        }

        void LoadKiemTra()
        {
            qlndC.LoadThongTin(dtgvDSND, 0); // 0 là những người dùng chưa xoá
            //foreach (DataGridViewRow row in dtgvDSND.Rows)
            //{
            //    if (row.Cells[1].Value.ToString() == "2")
            //    {
            //        dtgvDSND.Rows.Remove(row);
            //    }
            //}
           
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtChonAnh.Text = openFileDialog.FileName;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isCapNhat)
            {
                string loi = "";

                byte[] picbyte;

                if (txtTen.TextLength == 0) { loi = "Tên không để trống\n"; }
                if (txtHo.TextLength == 0) { loi = "Họ và tên lót đăng nhập không để trống\n"; }
                if (txtPass.TextLength == 0) { loi = "Password đăng nhập không để trống\n"; }

                try
                {
                    if (cbGioiTinh.SelectedItem.ToString() == "") { loi = "Vui lòng chọn giới tính\n"; }
                }
                catch
                {
                    loi = "Vui lòng chọn giới tính\n";
                }

                if (txtSdt.TextLength == 0) { loi = "Số điện thoại không để trống\n"; }
                if (txtQueQuan.TextLength == 0) { loi = "Quê quán không để trống\n"; }

                if (openFileDialog.FileName == "")
                {
                    picbyte = GlobalVariable.GVAnh;
                }
                else
                {
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                }
                if (loi.Length != 0)
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!qlndC.CapNhatInfo(
                            txtTenDN.Text,
                            txtTen.Text,
                            txtHo.Text,
                            txtPass.Text,
                            datetimeSN.Value.ToString("yyyy-MM-dd"),
                            cbGioiTinh.SelectedItem.ToString() == "Nam" ? 1 : 0,
                            txtSdt.Text,
                            txtQueQuan.Text,
                            picbyte,
                            cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1,
                            Convert.ToInt32(txtMa.Text))
                     )
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKiemTra();
                }
                isCapNhat = true;
            }

            else
            {

                string loi = "";

                byte[] picbyte;

                if (txtTen.TextLength == 0) { loi = "Tên không để trống\n"; }
                if (txtHo.TextLength == 0) { loi = "Họ và tên lót đăng nhập không để trống\n"; }
                if (txtPass.TextLength == 0) { loi = "Password đăng nhập không để trống\n"; }

                try
                {
                    if (cbGioiTinh.SelectedItem.ToString() == "") { loi = "Vui lòng chọn giới tính\n"; }
                }
                catch
                {
                    loi = "Vui lòng chọn giới tính\n";
                }

                if (txtSdt.TextLength == 0) { loi = "Số điện thoại không để trống\n"; }
                if (txtQueQuan.TextLength == 0) { loi = "Quê quán không để trống\n"; }

                if (openFileDialog.FileName == "")
                {
                    picbyte = GlobalVariable.GVAnh;
                }
                else
                {
                    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
                    fs.Close();
                }
                if (loi.Length != 0)
                {
                    MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!qlndC.insertNewSinhVien(txtTenDN.Text, txtTen.Text, txtHo.Text, txtPass.Text,
                            datetimeSN.Value.ToString("yyyy-MM-dd"),
                            cbGioiTinh.SelectedItem.ToString() == "Nam" ? 1 : 0,
                            txtSdt.Text, txtQueQuan.Text, picbyte,
                            cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1)
                     )
                {
                    MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Đã thêm thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKiemTra();
                }
                isCapNhat = true;
                btnXoa.Text = "Xoá";
                btnCapNhat.Text = "Cập nhật";
                dtgvDSND.Enabled = true;
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(TextBox tb in this.groupBox1.Controls.OfType<TextBox>())
            {
                tb.Text = "";
            }

            // tắt dtgv
            dtgvDSND.Enabled = false;
            isCapNhat = false;
            btnXoa.Text = "Huỷ";
            btnCapNhat.Text = "Thêm";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isCapNhat)
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {


                    qlndC.DeleteUser(Convert.ToInt32(txtMa.Text), cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1);
                }
                LoadKiemTra();
            }
            else
            {
                // tắt dtgv
                dtgvDSND.Enabled = true;
                isCapNhat = true;
                btnXoa.Text = "Xoá";
                btnCapNhat.Text = "Cập nhật";
                dtgvDSND_CellClick(this.dtgvDSND, new DataGridViewCellEventArgs(0, 0)); // Click vô dòng đầu tiên
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int ltk = cbTK.SelectedItem.ToString() == "Mã Số" ? 0 : 1;
                int ltc = cbLoaiTC.SelectedItem.ToString() == "Tất Cả" ? -1 : cbLoaiTC.SelectedItem.ToString() == "Sinh viên" ? 0 : 1;
                qlndC.Search(ltk, txtTk.Text, ltc, dtgvDSND);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadKiemTra();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            (new KhoiPhucNguoiDung()).ShowDialog(this);
        }

        private void btnClassofPerson_Click(object sender, EventArgs e)
        {
            ThongTinLopHoc thongTinLopHoc = new ThongTinLopHoc();
            thongTinLopHoc.ShowDialog(this);
        }
    }
}
