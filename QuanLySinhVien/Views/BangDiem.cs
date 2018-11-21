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
    public partial class BangDiem : Form
    {
        BangDiemController bangDiemController;

        public BangDiem()
        {
            InitializeComponent();
            bangDiemController = new BangDiemController();
            
        }

        private void cbHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bangDiemController.dataGridViewDiemLoad(cbHK, cbNamHoc, dtgvDiem);
            // Thêm số thư tự
            int count = 1;
            foreach (DataGridViewRow row in dtgvDiem.Rows)
            {
                row.Cells[0].Value = count;
                count++;
            }
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            bangDiemController.comboBoxHocKyLoad(cbHK);
            bangDiemController.comboBoxNamHocLoad(cbNamHoc);
            bangDiemController.chonHKNHHienTai(cbHK, cbNamHoc);

            bangDiemController.dataGridViewDiemLoad(cbHK, cbNamHoc, dtgvDiem);
            // Thêm số thư tự
            int count = 1;
            foreach(DataGridViewRow row in dtgvDiem.Rows)
            {
                row.Cells[0].Value = count;
                count++;
            }
        }

        //private void dtgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dtgvDiem.Rows[dtgvDiem.SelectedCells[0].RowIndex].Selected = true;
        //    if(dtgvDiem.SelectedRows.Count == 1)
        //    {
        //        txtTenMon.Text = dtgvDiem.SelectedRows[0].Cells[1].Value.ToString();
        //        txtTK.Text = dtgvDiem.SelectedRows[0].Cells[2].Value.ToString();
        //        txtGK.Text = dtgvDiem.SelectedRows[0].Cells[3].Value.ToString();
        //        txtCk.Text = dtgvDiem.SelectedRows[0].Cells[4].Value.ToString();
        //        txtTongKEt.Text = dtgvDiem.SelectedRows[0].Cells[5].Value.ToString();
        //        txtXL.Text = dtgvDiem.SelectedRows[0].Cells[6].Value.ToString();

        //    }
        //}

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnReportMark_Click(object sender, EventArgs e)
        {
            List<MonHoc> lst = new List<MonHoc>();
            foreach (DataGridViewRow row in dtgvDiem.Rows)
            {
                lst.Add(new MonHoc
                {
                    TenMon = row.Cells[1].Value.ToString(),
                    ThuongKy = row.Cells[2].Value.ToString(),
                    GiuaKy = row.Cells[3].Value.ToString(),
                    CuoiKy = row.Cells[4].Value.ToString(),
                    TongKet = row.Cells[5].Value.ToString(),
                    XepLoai = row.Cells[6].Value.ToString()
                });
            }
            ReportDataSource rs = new ReportDataSource();
            rs.Name = "DataSet1";
            rs.Value = lst;
            BaoCaoDiem baoCaoDiem = new BaoCaoDiem();
            baoCaoDiem.reportViewer1.LocalReport.DataSources.Clear();
            baoCaoDiem.reportViewer1.LocalReport.DataSources.Add(rs);
            baoCaoDiem.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.Report1.rdlc";

            string hoten = ((ThongTinSinhVien)this.Owner).txtHoTen.Text;
            baoCaoDiem.reportViewer1.LocalReport.SetParameters(new ReportParameter("Name", hoten));
            baoCaoDiem.ShowDialog(this);

        }
    }
}
