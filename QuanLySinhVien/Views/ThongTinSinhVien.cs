using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Controllers;

namespace QuanLySinhVien.Views
{
    public partial class ThongTinSinhVien : Form
    {
        ThongTinSinhVienController thongTinSinhVienController;

        public ThongTinSinhVien()
        {
            InitializeComponent();
            thongTinSinhVienController = new ThongTinSinhVienController();
            if(GlobalVariable.GVTuCach == 0)
            {
                btnUserManagement.Enabled = false;
                btnQLMH.Enabled = false;
            }
            if (GlobalVariable.GVTuCach == 1)
            {
                btnMarkInfo.Enabled = false;
                btnUserManagement.Enabled = false;
                btnQLMH.Enabled = false;
                btnDangKyLop.Enabled = false;
            }
            if (GlobalVariable.GVTuCach == 2)
            {
                btnMarkInfo.Enabled = false;
                btnClassInfo.Enabled = false;
                btnUpdateInfo.Enabled = false;
                btnDangKyLop.Enabled = false;
            }
        }

        private void BangChucNang_Load(object sender, EventArgs e)
        {
            thongTinSinhVienController.loadThongTin(txtMaSo, txtHoTen, txtNgaySinh, txtGioiTinh, txtSdt, txtQueQuan, txtTuCach, pictureBox1);
        }

        void loadlaithongitn()
        {
            thongTinSinhVienController.loadThongTin(txtMaSo, txtHoTen, txtNgaySinh, txtGioiTinh, txtSdt, txtQueQuan, txtTuCach, pictureBox1);
        }

        private void btnClassInfo_Click(object sender, EventArgs e)
        {
            ThongTinLopHoc thongTinLopHoc = new ThongTinLopHoc();
            thongTinLopHoc.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc chắn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(re == DialogResult.OK)
            {
                this.Hide();
                (new DangNhap()).Show();
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            CapNhatThongTin cntt = new CapNhatThongTin();
            cntt.ShowDialog(this);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            thongTinSinhVienController.loadThongTin(txtMaSo, txtHoTen, txtNgaySinh, txtGioiTinh, txtSdt, txtQueQuan, txtTuCach, pictureBox1);
        }

        private void btnMarkInfo_Click(object sender, EventArgs e)
        {
            (new BangDiem()).ShowDialog(this);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung qlnd = new QuanLyNguoiDung();
            qlnd.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            (new Thongtin()).ShowDialog();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            (new QuanLyMonHoc()).ShowDialog();
        }

        private void btnDangKyLop_Click(object sender, EventArgs e)
        {
            (new DangKiHocPhan()).ShowDialog();
        }

        private void ThongTinSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
