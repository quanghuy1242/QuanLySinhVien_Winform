using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Controllers;

namespace QuanLySinhVien.Views
{
    public partial class DangKi : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        DaangKyController daangKyController;

        public DangKi()
        {
            InitializeComponent();
            daangKyController = new DaangKyController();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            openFileDialog.FilterIndex = 2;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtChonAnh.Text = openFileDialog.FileName;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string loi = "";

            byte[] picbyte;
            if (!daangKyController.checkTenDangNhap(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTenDangNhap.TextLength == 0) { loi += "Tên đăng nhập không để trống\n"; }
            if (txtTen.TextLength == 0) { loi += "Tên không để trống\n"; }
            if (txtTenLot.TextLength == 0) { loi += "Họ và tên lót đăng nhập không để trống\n"; }
            if (txtPass.TextLength < 5) { loi += "Password phải lớn hơn hoặc bằng 5 kí tự\n"; }

            try
            {
                if (cbGioiTInh.SelectedItem.ToString() == "") { loi += "Vui lòng chọn giới tính\n"; }
            }
            catch
            {
                loi += "Vui lòng chọn giới tính\n";
            }

            if (txtSdt.TextLength == 0) { loi += "Số điện thoại không để trống\n"; }
            if (txtQueQuan.TextLength == 0) { loi += "Quê quán không để trống\n"; }

            if (txtChonAnh.TextLength == 0)
            {
                picbyte = null;
            }
            else
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }

            if (DateTime.Now.Year - datetimeBirthday.Value.Year < 17)
            {
                loi += "Sinh viên phải có tuổi lớn hơn hoặc bằng 17";
            }

            Regex regex = new Regex(@"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$");
            if (!regex.IsMatch(txtSdt.Text))
            {
                loi += "Số điện thoại không đúng định dạng!";
            }

            if (loi.Length != 0)
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!checkBoxDieuKhoan.Checked)
            {
                MessageBox.Show("Bạn chưa chấp nhận điều khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!daangKyController.insertNewSinhVien(
                txtTenDangNhap.Text,
                txtTen.Text,
                txtTenLot.Text,
                txtPass.Text,
                datetimeBirthday.Value.ToString("yyyy-MM-dd"),
                cbGioiTInh.SelectedItem.ToString() == "Nam" ? 1 : 0,
                txtSdt.Text,
                txtQueQuan.Text,
                picbyte))
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Đăng kí thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DangNhap dn = new DangNhap();
                dn.Show();
                this.Hide();
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
