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
            //this.TopMost = true;
            Thread t = new Thread(new ThreadStart(startSplash));

            if (GlobalVariable.moLanDauTien == 0)
            {
                t.Start();
                Thread.Sleep(3000);
            }

            //startSplash2();

            InitializeComponent();


            t.Abort();

            GlobalVariable.moLanDauTien++;
            
            dangNhapController = new DangNhapController();

            this.BringToFront();
            this.Activate();
            
        }

        async private void startSplash2()
        {
            await Task.Run(() =>
            {
                Application.Run(new SplashScreen());
            });
        }

        private void startSplash()
        {
            Application.Run(new SplashScreen());
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
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;

            await Task.Run(() =>
            {
                try
                {
                    if (dangNhapController.checkDangNhap(txtMaSo, txtPassword))
                    {
                        this.Invoke(new Action(() => this.Hide()));
                        flag = true;
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
                }
                catch
                {
                    progressBar1.Invoke(new Action(() =>
                    {
                        progressBar1.Style = ProgressBarStyle.Continuous;
                        progressBar1.MarqueeAnimationSpeed = 0;
                    }));
                    MessageBox.Show("Không kết nối được với server!");
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

        private void DangNhap_Shown(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;
            this.Activate();
            this.Focus();
            //Application.OpenForms.OfType<Form>()
            //    .Where(form => String.Equals(form.Name, "SplashScreen"))
            //    .ToList()
            //    .ForEach(form =>
            //    {
            //        form.Invoke(new Action(() =>
            //        {
            //            form.Hide();
            //        }));
            //    });

            this.TopMost = false;
        }
    }
}
