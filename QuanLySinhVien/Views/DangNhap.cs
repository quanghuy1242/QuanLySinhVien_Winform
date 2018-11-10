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
    public partial class DangNhap : Form
    {
        DangNhapController dangNhapController;

        public DangNhap()
        {
            InitializeComponent();
            dangNhapController = new DangNhapController();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (dangNhapController.checkDangNhap(txtMaSo, txtPassword)) {
                ThongTinSinhVien ttsv = new ThongTinSinhVien();
                this.Hide();
                ttsv.Show();
                return;
            }
            MessageBox.Show("Không thể đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKi dangKi = new DangKi();
            dangKi.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
