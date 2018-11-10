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
        bool isUpdate = true;

        public QuanLyMonHoc()
        {
            InitializeComponent();
            dtgvMonHoc.AutoGenerateColumns = false;
            dtgvLopHoc.AutoGenerateColumns = false;

            btnHuyThem.Visible = false;
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
            txtMaLop.Text = "";
            txtMaGV.Text = "";
            nudSiSo.Value = 0;
            txtHK.Text = "";
            txtNamHoc.Text = "";
            txtTenGV.Text = "";

            try
            {
                int selectedcell = dtgvLopHoc.SelectedCells[0].RowIndex;
                dtgvLopHoc.Rows[selectedcell].Selected = true;

                txtMaLop.Text = dtgvLopHoc.Rows[selectedcell].Cells[0].Value.ToString();
                txtMaGV.Text = dtgvLopHoc.Rows[selectedcell].Cells[1].Value.ToString();
                nudSiSo.Value = Convert.ToInt32(dtgvLopHoc.Rows[selectedcell].Cells[6].Value);
                //string s = dtgvLopHoc.Rows[selectedcell].Cells[5].Value.ToString();
                txtHK.Text = dtgvLopHoc.Rows[selectedcell].Cells[4].Value.ToString().Trim();
                txtNamHoc.Text = dtgvLopHoc.Rows[selectedcell].Cells[5].Value.ToString().Trim();

                try
                {
                    txtTenGV.Text = qlmhC.getTenGV(Convert.ToInt32(txtMaGV.Text));
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateAdd_Click(object sender, EventArgs e)
        {
            int malop, magv, mamh, siso;
            string hocky, namhoc;
            try
            {
                
                magv = Convert.ToInt32(txtMaGV.Text);
                mamh = Convert.ToInt32(dtgvMonHoc.SelectedRows[0].Cells[0].Value);
                hocky = txtHK.Text;
                namhoc = txtNamHoc.Text;
                siso = Convert.ToInt32(nudSiSo.Value);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (isUpdate)
            {
                // Cập nhật
                malop = Convert.ToInt32(txtMaLop.Text);

                qlmhC.updateClass(malop, magv, mamh, hocky, namhoc, siso);
                qlmhC.comboBoxHocKyLoad(cbHK);
                qlmhC.comboBoxNamHocLoad(cbNamHoc);
                MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(qlmhC.checkGiangVienInLopHoc(magv, hocky, namhoc, mamh))
                {
                    // Thêm lớp
                    qlmhC.insertNewClass(magv, mamh, hocky, namhoc, siso);

                    // Load lại bảng lớp và 2 combo box
                    qlmhC.comboBoxHocKyLoad(cbHK);
                    qlmhC.comboBoxNamHocLoad(cbNamHoc);
                    qlmhC.dataGridViewMonHocLoad(dtgvMonHoc);

                    MessageBox.Show("Thêm thành công một lớp!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giảng viên đã dạy môn này trong học kì này!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                


            }
            isUpdate = true;
            btnUpdateAdd.Text = "Cập nhật";
            panel1.BackColor = Color.WhiteSmoke;

            dtgvLopHoc.Enabled = true;
            dtgvMonHoc.Enabled = true;


        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenGV.Text = qlmhC.getTenGV(Convert.ToInt32(txtMaGV.Text));
            }
            catch
            {
                txtTenGV.Text = "";
            }
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            btnUpdateAdd.Text = "Thêm";
            panel1.BackColor = Color.Aqua;

            btnHuyThem.Visible = true;

            dtgvLopHoc.Enabled = false;
            dtgvMonHoc.Enabled = false;

            txtMaLop.Text = "";
            txtMaGV.Text = "";
            nudSiSo.Value = 0;
            txtHK.Text = "";
            txtNamHoc.Text = "";
            txtTenGV.Text = "";
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            dtgvLopHoc.Enabled = true;
            dtgvMonHoc.Enabled = true;

            isUpdate = true;
            btnUpdateAdd.Text = "Cập nhật";
            panel1.BackColor = Color.WhiteSmoke;
            btnHuyThem.Visible = false;
        }

        private void cbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, 0));
            }
            catch
            {

            }
            
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!qlmhC.checkMaSinhVien(Convert.ToInt32(txtMaSV.Text)))
                {
                    MessageBox.Show("Mã Số Sinh viên không tồn tại!");
                    return;
                }

                if (qlmhC.checkLopSVDaHoc(Convert.ToInt32(txtMaLopHuy.Text), Convert.ToInt32(txtMaSV.Text)) == 1)
                {
                    MessageBox.Show("Sinh viên đã học lớp này!");
                    return;
                }

                qlmhC.DangKiHocPhan(Convert.ToInt32(txtMaLopHuy.Text), Convert.ToInt32(txtMaSV.Text));
                MessageBox.Show("Đăng kí thành công!");
            }
            catch
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (!qlmhC.checkMaSinhVien(Convert.ToInt32(txtMaSV.Text)))
                {
                    MessageBox.Show("Mã Số Sinh viên không tồn tại!");
                    return;
                }

                if (qlmhC.checkLopSVDaHoc(Convert.ToInt32(txtMaLopHuy.Text), Convert.ToInt32(txtMaSV.Text)) == 0)
                {
                    MessageBox.Show("Sinh viên chưa học lớp này!");
                    return;
                }

                qlmhC.HuyHocPhan(Convert.ToInt32(txtMaLopHuy.Text), Convert.ToInt32(txtMaSV.Text));
                MessageBox.Show("Huỷ thành công!");
            }
            catch
            {
                MessageBox.Show("Hãy điền đủ thông tin!");
            }
        }
    }
}
