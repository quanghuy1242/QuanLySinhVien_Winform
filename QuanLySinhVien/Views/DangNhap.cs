using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Tắt tất cả controls khi ấn đăng nhập
            btnDangNhap.Enabled = false;
            btnDangKy.Enabled = false;

            txtMaSo.Enabled = false;
            txtPassword.Enabled = false;

            bool flag = false;
            
            // Mở process bar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            await Task.Run(() =>
            {
                if (dangNhapController.checkDangNhap(txtMaSo, txtPassword))
                {
                    
                    //this.Hide();
                    this.Invoke(new Action(() => this.Hide()));
                    //ttsv.Invoke(new Action(() => ttsv.Show()));
                    flag = true;
                    //return;
                }
                else
                {
                    // tắt process bar khi có lỗi
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Style = ProgressBarStyle.Continuous;
                        progressBar1.MarqueeAnimationSpeed = 0;
                    }));

                    MessageBox.Show("Không thể đăng nhập!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            // tắt process bar
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;

            if (flag)
            {
                ThongTinSinhVien ttsv = new ThongTinSinhVien();
                ttsv.Show();
            }

            // Xong hết rồi thì hiện lên nếu có lỗi
            btnDangNhap.Enabled = true;
            btnDangKy.Enabled = true;

            txtMaSo.Enabled = true;
            txtPassword.Enabled = true;
            
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
