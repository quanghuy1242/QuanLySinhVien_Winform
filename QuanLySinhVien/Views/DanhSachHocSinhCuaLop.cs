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
    public partial class DanhSachHocSinhCuaLop : Form
    {
        DanhSachHocSinhController dshs;

        public DanhSachHocSinhCuaLop()
        {
            InitializeComponent();
            dshs = new DanhSachHocSinhController();
            dtgvDs.AutoGenerateColumns = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadLaiData()
        {
            // Lấy dtgv của cha
            DataGridView dtgv = ((ThongTinLopHoc)this.Owner).dtgvLop;

            int malop = Convert.ToInt32(dtgv.SelectedRows[0].Cells[0].Value);

            dshs.dataGridDsSv(dtgvDs, malop);
        }

        private void DanhSachHocSinhCuaLop_Load(object sender, EventArgs e)
        {
            loadLaiData();
        }

        //private void dtgvDs_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dtgvDs.SelectedRows.Count == 1)
        //    {
        //        txtMaso.Text = dtgvDs.SelectedRows[0].Cells[0].Value.ToString();
        //        txtHoTen.Text = dtgvDs.SelectedRows[0].Cells[1].Value.ToString();
        //    }
        //}
        

        private void btnUpdateDiem_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(DataGridViewRow row in dtgvDs.Rows)
            {
                float tk = float.Parse(row.Cells[2].Value.ToString());
                float gk = float.Parse(row.Cells[3].Value.ToString());
                float ck = float.Parse(row.Cells[4].Value.ToString());
                int ms = Convert.ToInt32(row.Cells[0].Value);
                ComboBox cbHK = ((ThongTinLopHoc)this.Owner).cbHK;
                ComboBox cbNamHoc = ((ThongTinLopHoc)this.Owner).cbNamHoc;

                DataGridView dtgv = ((ThongTinLopHoc)this.Owner).dtgvLop;

                int malop = Convert.ToInt32(dtgv.SelectedRows[0].Cells[0].Value);

                dshs.CapNhatDsDiem(tk, gk, ck, ms, malop);
                count++;
            }
            loadLaiData();
            MessageBox.Show(count.ToString() + " sinh viên được cập nhật điểm", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
