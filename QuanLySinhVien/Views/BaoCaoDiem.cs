using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Views
{
    public partial class BaoCaoDiem : Form
    {
        public BaoCaoDiem()
        {
            InitializeComponent();
        }

        private void BaoCaoDiem_Load(object sender, EventArgs e)
        {
            //DataGridView dtgv = ((BangDiem)this.Owner).dtgvDiem;

            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(rs);
            //reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.Report1.rdlc";

            //reportViewer1.Refresh();
            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            //TextBox hoten = ((ThongTinSinhVien)this.Owner.Owner).txtHoTen;
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
