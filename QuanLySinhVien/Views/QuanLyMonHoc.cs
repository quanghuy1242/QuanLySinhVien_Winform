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
    public partial class QuanLyMonHoc : Form
    {
        QuanLyMonHocController qlmhC = new QuanLyMonHocController();

        public QuanLyMonHoc()
        {
            InitializeComponent();
            dtgvMonHoc.AutoGenerateColumns = false;
            dtgvLopHoc.AutoGenerateColumns = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            qlmhC.comboBoxHocKyLoad(cbHK);
            qlmhC.comboBoxNamHocLoad(cbNamHoc);
            qlmhC.dataGridViewMonHocLoad(dtgvMonHoc);
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật các môn học được thêm vào?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(rs == DialogResult.OK)
            {
                qlmhC.updatedtgvtodb(dtgvMonHoc);
                qlmhC.dataGridViewMonHocLoad(dtgvMonHoc);
                MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedcell = dtgvMonHoc.SelectedCells[0].RowIndex;
            int maMH;
            dtgvMonHoc.Rows[selectedcell].Selected = true;

            try
            {
                maMH = Convert.ToInt32(dtgvMonHoc.Rows[selectedcell].Cells[0].Value);
                qlmhC.dataGridViewLopHocLoad(cbHK, cbNamHoc, dtgvLopHoc, maMH);
                dtgvLopHoc_CellClick_1(dtgvLopHoc, new DataGridViewCellEventArgs(0, 0)); // Click dòng đầu tiên của dtgvLopHoc
            }
            catch
            {

            }

            
        }

        private void dtgvLopHoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedcell = dtgvLopHoc.SelectedCells[0].RowIndex;
            dtgvLopHoc.Rows[selectedcell].Selected = true;

            txtMaLop.Text = dtgvLopHoc.Rows[selectedcell].Cells[0].Value.ToString();
            txtMaGV.Text = dtgvLopHoc.Rows[selectedcell].Cells[1].Value.ToString();
            nudSiSo.Value = Convert.ToInt32(dtgvLopHoc.Rows[selectedcell].Cells[5].Value);
            txtHK.Text = dtgvLopHoc.Rows[selectedcell].Cells[3].Value.ToString();
            txtNamHoc.Text = dtgvLopHoc.Rows[selectedcell].Cells[4].Value.ToString();

            try
            {
                txtTenGV.Text = qlmhC.getTenGV(Convert.ToInt32(txtMaGV.Text));
            }
            catch
            {

            }
        }
    }
}
