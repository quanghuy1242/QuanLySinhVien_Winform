﻿using System;
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
            //if(GlobalVariable.GVTuCach == 0)
            //{
            //    btnDanhSach.Visible = false;
            //}
            //if (GlobalVariable.GVTuCach == 2)
            //{
            //    btnDanhSach.Visible = false;
            //}
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
            if(GlobalVariable.GVTuCach != 2)
            {
                // Nếu người đang đănng nhập không phải là admin, thì ds lớp sẽ được load từ ms, tucach
                ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop, GlobalVariable.GVMaSo, GlobalVariable.GVTuCach);
            }
            else
            {
                int maso = Convert.ToInt32(((QuanLyNguoiDung)this.Owner).txtMa.Text);
                int tucach = ((QuanLyNguoiDung)this.Owner).cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1;
                ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop, maso, tucach);
            }
            //dtgvLop_CellClick(dtgvLop, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (GlobalVariable.GVTuCach != 2)
            {
                // Nếu người đang đănng nhập không phải là admin, thì ds lớp sẽ được load từ ms, tucach
                ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop, GlobalVariable.GVMaSo, GlobalVariable.GVTuCach);
            }
            else
            {
                int maso = Convert.ToInt32(((QuanLyNguoiDung)this.Owner).txtMa);
                int tucach = ((QuanLyNguoiDung)this.Owner).cbTuCach.SelectedItem.ToString() == "Sinh Viên" ? 0 : 1;
                ttlhCon.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLop, maso, tucach);
            }
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
