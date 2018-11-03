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
    public partial class KhoiPhucNguoiDung : Form
    {
        KhoiPhucNguoiDungController kpndC = new KhoiPhucNguoiDungController();

        public KhoiPhucNguoiDung()
        {
            InitializeComponent();
            dtgvRestore.AutoGenerateColumns = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhoiPhucNguoiDung_Load(object sender, EventArgs e)
        {
            kpndC.LoadThongTin(dtgvRestore, 1);
        }

        //private void dtgvRestore_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int selectedcell = dtgvRestore.SelectedCells[0].RowIndex;
        //    dtgvRestore.Rows[selectedcell].Selected = true;
        //    txtMa.Text = dtgvRestore.Rows[selectedcell].Cells[0].Value.ToString();
        //    txtHoTen.Text = dtgvRestore.Rows[selectedcell].Cells[2].Value.ToString() + " " + dtgvRestore.Rows[selectedcell].Cells[3].Value.ToString();
        //    txtTuCach.Text = dtgvRestore.Rows[selectedcell].Cells[1].Value.ToString();
        //}

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            int ma, tc;

            try
            {
                ma = Convert.ToInt32(dtgvRestore.SelectedRows[0].Cells[0].Value);
                tc = Convert.ToInt32(dtgvRestore.SelectedRows[0].Cells[1].Value);

                if (rs == DialogResult.OK)
                {
                    if (kpndC.RestoreUsers(ma, tc))
                    {
                        MessageBox.Show("Đã khôi phục thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ((QuanLyNguoiDung)this.Owner).btnShowAll.PerformClick();
                        kpndC.LoadThongTin(dtgvRestore, 1);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Danh sách trống hoặc bạn chưa chọn một người dùng", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
