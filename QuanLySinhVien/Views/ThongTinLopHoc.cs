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
    public partial class ThongTinLopHoc : Form
    {
        ThongTinLopHocController ttlhCon;

        public ThongTinLopHoc()
        {
            InitializeComponent();
            ttlhCon = new ThongTinLopHocController();
            dtgvLop.AutoGenerateColumns = false;
            if(GlobalVariable.GVTuCach == 0)
            {
                btnDanhSach.Visible = false;
            }
        }

        //private void cbHK_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop);
        //}

        //private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop);
        //}

        private void ThongTinLopHoc_Load(object sender, EventArgs e)
        {
            ttlhCon.comboBoxHocKyLoad(cbHK);
            ttlhCon.comboBoxNamHocLoad(cbNamHoc);
            ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop);
            //dtgvLop_CellClick(dtgvLop, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop);
        }

        //private void dtgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    dtgvLop.Rows[dtgvLop.SelectedCells[0].RowIndex].Selected = true;
        //    //if (dtgvLop.SelectedRows.Count == 1)
        //    //{
        //    //    txtMaLop.Text = dtgvLop.SelectedRows[0].Cells[0].Value.ToString();
        //    //    txtHoTenGV.Text = dtgvLop.SelectedRows[0].Cells[1].Value.ToString();
        //    //    txtMonHoc.Text = dtgvLop.SelectedRows[0].Cells[2].Value.ToString();
        //    //    txtSiSo.Text = dtgvLop.SelectedRows[0].Cells[3].Value.ToString();
        //    //}
        //}

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            DanhSachHocSinhCuaLop dshs = new DanhSachHocSinhCuaLop();
            dshs.ShowDialog(this);
            
        }
    }
}
