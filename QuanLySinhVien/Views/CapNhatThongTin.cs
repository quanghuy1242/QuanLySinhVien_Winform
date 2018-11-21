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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLySinhVien.Views
{
    public partial class CapNhatThongTin : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        CapNhatThongTinController cnttc;
        DaangKyController daangKyController;

        public CapNhatThongTin()
        {
            InitializeComponent();
            cnttc = new CapNhatThongTinController();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string loi = "";

            byte[] picbyte;
            
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

            if (openFileDialog.FileName == "")
            {
                picbyte = GlobalVariable.GVAnh;
            }
            else
            {
                openFileDialog.RestoreDirectory = true;
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
            if(!regex.IsMatch(txtSdt.Text))
            {
                loi += "Số điện thoại không đúng định dạng!";
            }

            if (loi.Length != 0)
            {
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!cnttc.CapNhatInfo(
                        txtTenDangNhap.Text,
                        txtTen.Text,
                        txtTenLot.Text,
                        txtPass.Text,
                        datetimeBirthday.Value.ToString("yyyy-MM-dd"),
                        cbGioiTInh.SelectedItem.ToString() == "Nam" ? 1 : 0,
                        txtSdt.Text,
                        txtQueQuan.Text,
                        picbyte,
                        GlobalVariable.GVTuCach,
                        GlobalVariable.GVMaSo)
                 )
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnttc.loadThongTin(txtTen, txtTenLot, datetimeBirthday, cbGioiTInh, txtSdt, txtQueQuan, txtTenDangNhap, txtPass);
                Button btn = ((ThongTinSinhVien)this.Owner).button1;
                btn.PerformClick();
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
            this.Close();
        }

        private void CapNhatThongTin_Load(object sender, EventArgs e)
        {
            cnttc.loadThongTin(txtTen, txtTenLot, datetimeBirthday, cbGioiTInh, txtSdt, txtQueQuan, txtTenDangNhap, txtPass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
