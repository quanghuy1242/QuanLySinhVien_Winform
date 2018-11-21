using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLySinhVien.Controllers;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Views
{
    public partial class DanhSachHocSinhCuaLop : Form
    {
        DanhSachHocSinhController dshs;
        int trangThai;

        public DanhSachHocSinhCuaLop()
        {
            InitializeComponent();
            dshs = new DanhSachHocSinhController();
            dtgvDs.AutoGenerateColumns = false;


            dtgvDs.Columns["DiemTK"].DefaultCellStyle.Format = "#.##";
            dtgvDs.Columns["DiemGK"].DefaultCellStyle.Format = "#.##";
            dtgvDs.Columns["DiemCK"].DefaultCellStyle.Format = "#.##";
            dtgvDs.Columns["TongKet"].DefaultCellStyle.Format = "#.##";

            if (GlobalVariable.GVTuCach == 0)
            {
                txtState.Visible = false;
                btnReport.Visible = false;
                capQuyenCapNhatDiem();
            }
            if (GlobalVariable.GVTuCach == 2)
            {
                btnReport.Visible = false;
            }
        }

        private void capQuyenCapNhatDiem()
        {
            dtgvDs.Columns["DiemTK"].ReadOnly = true;

            dtgvDs.Columns["DiemGK"].ReadOnly = true;

            dtgvDs.Columns["DiemCK"].ReadOnly = true;

            btnUpdateDiem.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadLaiData()
        {
            // Lấy dtgv của cha
            DataGridView dtgv = ((ThongTinLopHoc)this.Owner).dtgvLop;
            int malop;
            try
            {
                malop = Convert.ToInt32(dtgv.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("Bạn chưa học lớp nào!");
                return;
            }

            if (GlobalVariable.GVTuCach == 0)
            {
                // Nếu người đăng nhập là sinh viên
                dshs.dataGridDsSv(dtgvDs, malop, GlobalVariable.GVMaSo, out trangThai);
            }
            if (GlobalVariable.GVTuCach == 1)
            {
                // Nếu người đăng nhập là giảng viên
                dshs.dataGridDsSv(dtgvDs, malop, -1, out trangThai);
            }
            if (GlobalVariable.GVTuCach == 2)
            {
                // Nếu người đăng nhập là admin
                int tucach = ((QuanLyNguoiDung)this.Owner.Owner).cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1;
                if (tucach == 0)
                {
                    int masosv = Convert.ToInt32(((QuanLyNguoiDung)this.Owner.Owner).txtMa.Text);
                    dshs.dataGridDsSv(dtgvDs, malop, masosv, out trangThai);
                }
                if(tucach == 1)
                {
                    dshs.dataGridDsSv(dtgvDs, malop, -1, out trangThai);
                }
            }

            if (trangThai == 0)
            {
                txtState.Text = "Bạn chưa thể cập nhật điểm vì các thông tin điểm đang bị khoá";
                capQuyenCapNhatDiem();
            }
            else
            {
                txtState.Text = "";
            }
        }

        private void DanhSachHocSinhCuaLop_Load(object sender, EventArgs e)
        {
            loadLaiData();
            dtgvDs.CellValidating += new DataGridViewCellValidatingEventHandler(dtgvDs_CellValidating);
            dtgvDs.CellEndEdit += new DataGridViewCellEventHandler(dtgvDs_CellEndEdit);
        }

        //private void dtgvDs_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dtgvDs.SelectedRows.Count == 1)
        //    {
        //        txtMaso.Text = dtgvDs.SelectedRows[0].Cells[0].Value.ToString();
        //        txtHoTen.Text = dtgvDs.SelectedRows[0].Cells[1].Value.ToString();
        //    }
        //}

        private void dtgvDs_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float text;
            if (GlobalVariable.GVMaSo != 0)
            {
                try
                {
                    text = Convert.ToInt32(e.FormattedValue);

                    if (text > 10)
                    {
                        dtgvDs.Rows[e.RowIndex].ErrorText = "Điểm không thể lớn hơn 10";
                        e.Cancel = true;
                    }
                }
                catch
                {

                }
            }
        }

        private void dtgvDs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgvDs.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void btnUpdateDiem_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(DataGridViewRow row in dtgvDs.Rows)
            {
                float tk = -1, gk = -1, ck = -1;
                try
                {
                    tk = float.Parse(row.Cells[2].Value.ToString());
                }
                catch
                {

                }

                try
                {
                    gk = float.Parse(row.Cells[3].Value.ToString());
                }
                catch
                {

                }

                try
                {
                    ck = float.Parse(row.Cells[4].Value.ToString());
                }
                catch
                {

                }

                int ms = Convert.ToInt32(row.Cells[0].Value);

                ComboBox cbHK = ((ThongTinLopHoc)this.Owner).cbHK;
                ComboBox cbNamHoc = ((ThongTinLopHoc)this.Owner).cbNamHoc;

                DataGridView dtgv = ((ThongTinLopHoc)this.Owner).dtgvLop;

                int malop = Convert.ToInt32(dtgv.SelectedRows[0].Cells[0].Value);

                dshs.CapNhatDsDiem(tk, gk, ck, ms, malop);
                count++;
            }
            loadLaiData();
            MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            List<HocSinh> lst = new List<HocSinh>();
            foreach(DataGridViewRow row in dtgvDs.Rows)
            {
                HocSinh hs = new HocSinh
                {
                    MaSo = row.Cells[0].Value.ToString(),
                    HovaTen = row.Cells[1].Value.ToString(),
                    ThuongKy = row.Cells[2].Value.ToString(),
                    GiuaKy = row.Cells[3].Value.ToString(),
                    CuoiKy = row.Cells[4].Value.ToString(),
                    TongKet = row.Cells[5].Value.ToString(),
                    XepLoai = row.Cells[6].Value.ToString(),

                };
                lst.Add(hs);
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSet2";
            rs.Value = lst;
            BaoCaoDanhSachSinhVien baoCaoDanhSachSinhVien = new BaoCaoDanhSachSinhVien();
            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.DataSources.Clear();
            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.DataSources.Add(rs);
            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.Report2.rdlc";

            string MaLop = ((ThongTinLopHoc)this.Owner).dtgvLop.SelectedRows[0].Cells[0].Value.ToString();
            string HoTen = ((ThongTinLopHoc)this.Owner).dtgvLop.SelectedRows[0].Cells[1].Value.ToString();
            string TenMon = ((ThongTinLopHoc)this.Owner).dtgvLop.SelectedRows[0].Cells[2].Value.ToString();

            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.SetParameters(new ReportParameter("Malop", MaLop));
            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.SetParameters(new ReportParameter("Tengv", HoTen));
            baoCaoDanhSachSinhVien.reportViewer1.LocalReport.SetParameters(new ReportParameter("TenMH", TenMon));

            baoCaoDanhSachSinhVien.ShowDialog();
        }
    }
}
