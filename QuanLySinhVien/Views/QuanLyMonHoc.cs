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
        Dictionary<int, string> DSGIangVien = new Dictionary<int, string>();
        int TrangThaiCapNhat;

        public QuanLyMonHoc()
        {
            InitializeComponent();
            dtgvMonHoc.AutoGenerateColumns = false;
            dtgvLopHoc.AutoGenerateColumns = false;
            dtgvNamHocHocKy.AutoGenerateColumns = false;

            btnHuyThem.Visible = false;
        }

        private void anHienCacControl(bool f)
        {
            txtMaLop.Enabled = f;
            txtMaGV.Enabled = f;
            nudSiSo.Enabled = f;
            txtHK.Enabled = f;
            txtNamHoc.Enabled = f;
            txtTenGV.Enabled = f;
            txtTenLop.Enabled = f;
        }

        private void loadState()
        {
            // Load trạng thái Allow Edit:
            TrangThaiCapNhat = 0;
            TrangThaiCapNhat = qlmhC.loadTrangThaiCapNhat(cbHK.Text.Trim(), cbNamHoc.Text.Trim());
            if (TrangThaiCapNhat == 0)
            {
                kcp.Checked = true;
            }
            if (TrangThaiCapNhat == 1)
            {
                cp.Checked = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            qlmhC.comboBoxHocKyLoad(cbHK);
            qlmhC.comboBoxNamHocLoad(cbNamHoc);
            qlmhC.chonHKNHHienTai(cbHK, cbNamHoc);

            qlmhC.comboBoxHocKyLoad(txtHK);
            qlmhC.comboBoxNamHocLoad(txtNamHoc);
            //qlmhC.chonHKNHHienTai(txtHK, txtNamHoc);


            qlmhC.dataGridViewMonHocLoad(dtgvMonHoc);

            qlmhC.loadComboBoxGiangVien(txtMaGV, txtTenGV, out DSGIangVien);

            dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, 0));

            loadState();

            // Load danh sách học kỳ năm học:
            qlmhC.dtgvNHHK(dtgvNamHocHocKy);

        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật các môn học?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
                txtMaLop.Text = "";
                txtMaGV.Text = "";
                nudSiSo.Value = 0;
                txtHK.Text = "";
                txtNamHoc.Text = "";
                txtTenGV.Text = "";
                txtTenLop.Text = "";
                anHienCacControl(false);
            }

            
        }

        private void dtgvLopHoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            anHienCacControl(false);

            txtMaLop.Text = "";
            txtMaGV.Text = "";
            nudSiSo.Value = 0;
            txtHK.Text = "";
            txtNamHoc.Text = "";
            txtTenGV.Text = "";
            txtTenLop.Text = "";

            try
            {
                int selectedcell = dtgvLopHoc.SelectedCells[0].RowIndex;
                dtgvLopHoc.Rows[selectedcell].Selected = true;

                txtMaLop.Text = dtgvLopHoc.Rows[selectedcell].Cells[0].Value.ToString();
                txtMaGV.Text = dtgvLopHoc.Rows[selectedcell].Cells[2].Value.ToString();
                nudSiSo.Value = Convert.ToInt32(dtgvLopHoc.Rows[selectedcell].Cells[7].Value);
                //string s = dtgvLopHoc.Rows[selectedcell].Cells[5].Value.ToString();
                txtHK.Text = dtgvLopHoc.Rows[selectedcell].Cells[5].Value.ToString().Trim();
                txtNamHoc.Text = dtgvLopHoc.Rows[selectedcell].Cells[6].Value.ToString().Trim();
                txtTenLop.Text = dtgvLopHoc.Rows[selectedcell].Cells[1].Value.ToString();

                try
                {
                    txtTenGV.Text = qlmhC.getTenGV(Convert.ToInt32(txtMaGV.Text));
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                }

                anHienCacControl(true);

            }
            catch
            {
                //MessageBox.Show(ex.Message);
                
            }
        }

        private void btnUpdateAdd_Click(object sender, EventArgs e)
        {
            int malop, magv, mamh, siso;
            string hocky, namhoc, tenlop;
            try
            {
                
                magv = Convert.ToInt32(txtMaGV.Text);
                mamh = Convert.ToInt32(dtgvMonHoc.SelectedRows[0].Cells[0].Value);
                hocky = txtHK.Text.Trim();
                namhoc = txtNamHoc.Text;
                namhoc = namhoc.Replace(" ", "");
                siso = Convert.ToInt32(nudSiSo.Value);
                tenlop = txtTenLop.Text;

                if (tenlop.Length == 0)
                {
                    MessageBox.Show("Tên Lớp là bắt buộc!");
                    return;
                }

                //string[] Arrayhk = { "HK1", "HK2", "HK3" };
                //int count = 0;
                //foreach(var str in Arrayhk)
                //{
                //    if (str != hocky) count++;
                //    if(count == 3)
                //    {
                //        MessageBox.Show("Học  không hợp lệ!");
                //        return;
                //    }
                //}

                if (siso == 0)
                {
                    MessageBox.Show("Sỉ số lớp phải lớn hơn 0");
                    return;
                }
                

            }
            catch
            {
                MessageBox.Show("Không có gì để cập nhật hoặc điền lỗi", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (isUpdate)
            {
                // Cập nhật
                try
                {
                    malop = Convert.ToInt32(txtMaLop.Text);
                    qlmhC.updateClass(malop, magv, mamh, hocky, namhoc, siso, tenlop);
                    //qlmhC.comboBoxHocKyLoad(cbHK);
                    //qlmhC.comboBoxNamHocLoad(cbNamHoc);
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }

                
                
            }
            else
            {
                if(qlmhC.checkGiangVienInLopHoc(magv, hocky, namhoc, mamh))
                {
                    // Thêm lớp
                    qlmhC.insertNewClass(magv, mamh, hocky, namhoc, siso, tenlop.ToUpper());

                    // Load lại bảng lớp và 2 combo box

                    //qlmhC.dataGridViewMonHocLoad(dtgvMonHoc);
                    dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, 0));


                    MessageBox.Show("Thêm thành công một lớp!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giảng viên đã dạy môn này trong học kì này!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                


            }
            isUpdate = true;
            dtgvLopHoc.Enabled = true;
            dtgvMonHoc.Enabled = true;

            isUpdate = true;
            btnUpdateAdd.Text = "Cập nhật";
            panel1.BackColor = Color.WhiteSmoke;
            btnHuyThem.Visible = false;

            btnNewClass.Enabled = true;

            //Click lại dòng đó

            try
            {
                dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, dtgvLopHoc.SelectedRows[0].Index));
            }
            catch
            {

            }
        }

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvMonHoc.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Chưa chọn một môn học!");
                return;
            }

            TrangThaiCapNhat = 0;
            TrangThaiCapNhat = qlmhC.loadTrangThaiCapNhat(cbHK.Text.Trim(), cbNamHoc.Text.Trim());

            if (TrangThaiCapNhat == 1)
            {
                MessageBox.Show("Không thể thêm một lớp học trong khi đang bật chế độ cho phép chỉnh sửa!");
                return;
            }

            anHienCacControl(true);

            isUpdate = false;
            btnUpdateAdd.Text = "Thêm";
            panel1.BackColor = Color.Aqua;
            btnNewClass.Enabled = false;

            btnHuyThem.Visible = true;

            dtgvLopHoc.Enabled = false;
            dtgvMonHoc.Enabled = false;

            txtMaLop.Text = "";
            txtMaGV.Text = "";
            nudSiSo.Value = 0;

            //txtHK.Text = "";
            //txtNamHoc.Text = "";
            qlmhC.chonHKNHHienTai(txtHK, txtNamHoc);

            txtTenGV.Text = "";

            txtMaLop.Text = "[...]";
            txtTenLop.Text = "";
        }

        private void btnHuyThem_Click(object sender, EventArgs e)
        {
            dtgvLopHoc.Enabled = true;
            dtgvMonHoc.Enabled = true;

            isUpdate = true;
            btnUpdateAdd.Text = "Cập nhật";
            panel1.BackColor = Color.WhiteSmoke;
            btnHuyThem.Visible = false;

            btnNewClass.Enabled = true;
            txtHK.Text = "";
            txtNamHoc.Text = "";

            try
            {
                dtgvLopHoc_CellClick_1(dtgvLopHoc, new DataGridViewCellEventArgs(0, dtgvLopHoc.SelectedRows[0].Index));
            }
            catch
            {
                anHienCacControl(false);
            }
            
        }

        private void cbHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, 0));
                loadState();
            }
            catch
            {
                cp.Checked = false;
                kcp.Checked = false;
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

                if (!qlmhC.checklopday(Convert.ToInt32(txtMaLopHuy.Text)))
                {
                    MessageBox.Show("Lớp này đã đủ số lượng sinh viên!");
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

        private void txtMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maDuocLay = Convert.ToInt32((sender as ComboBox).Text);
            try
            {
                foreach(KeyValuePair<int, string> item in DSGIangVien)
                {
                    if(item.Key == maDuocLay)
                    {
                        txtTenGV.Text = item.Value;
                        return;
                    }
                }
            }
            catch(Exception exx)
            {
                txtTenGV.Text = "";
                MessageBox.Show(exx.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenDuocLay = (sender as ComboBox).Text;
            try
            {
                foreach (KeyValuePair<int, string> item in DSGIangVien)
                {
                    if (item.Value == tenDuocLay)
                    {
                        txtMaGV.Text = item.Key.ToString();
                        return;
                    }
                }
            }
            catch (Exception exx)
            {
                txtMaGV.Text = "";
                MessageBox.Show(exx.Message);
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvLopHoc_CellClick(dtgvMonHoc, new DataGridViewCellEventArgs(0, 0));
                loadState();
            }
            catch
            {
                cp.Checked = false;
                kcp.Checked = false;
            }
        }

        private void dtgvMonHoc_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                
            }
        }

        private void dtgvMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void xoáMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xoá môn " + dtgvMonHoc.SelectedRows[0].Cells[1].Value.ToString() + "?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                if (qlmhC.getSoLopCuaMotMon(Convert.ToInt32(dtgvMonHoc.SelectedRows[0].Cells[0].Value)) != 0)
                {
                    MessageBox.Show("Bạn không thể xoá một môn học đang chứa các lớp học!");
                    return;
                }
                dtgvMonHoc.Rows.Remove(dtgvMonHoc.SelectedRows[0]);
                //MessageBox.Show("Coming soon...");
            }
        }

        private void updateStateAllow_Click(object sender, EventArgs e)
        {
            int tt;
            if (cp.Checked == true)
            {
                tt = 1;
                DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật trạng thái mới? (Giảng viên có thể cập nhật điểm cho sinh viên trong học kỳ này)", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    qlmhC.updateTrangThaiCapNhat(cbHK.Text.Trim(), cbNamHoc.Text.Trim(), tt);
                }
            }
            else if (kcp.Checked == true)
            {
                tt = 0;
                DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật trạng thái mới? (Giảng viên không thể cập nhật điểm cho sinh viên trong học kỳ này)", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    qlmhC.updateTrangThaiCapNhat(cbHK.Text.Trim(), cbNamHoc.Text.Trim(), tt);
                }
            }
            else
            {
                MessageBox.Show("Học kỳ này chưa có lớp học nào!");
                return;
            }
            
            //loadState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật các thay đổi trong học kỳ năm học?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                int count = 0;
                //string loi = "";
                for (int i = 0; i < dtgvNamHocHocKy.Rows.Count - 1; i++)
                {
                    if (dtgvNamHocHocKy.Rows[i].Cells[2].Value.ToString() == "1")
                    {
                        count++;
                    }
                    if (dtgvNamHocHocKy.Rows[i].Cells[2].Value == DBNull.Value)
                    {
                        dtgvNamHocHocKy.Rows[i].Cells[2].Value = false;
                    }
                }

                

                //if(loi.Length != 0)
                //{
                //    MessageBox.Show(loi);
                //    return;
                //}

                if (count != 1)
                {
                    MessageBox.Show("Vui lòng chọn học kỳ năm học hiện tại!!");
                    return;
                }

                if (qlmhC.updatedtgvHKNHtodb(dtgvNamHocHocKy))
                {
                    // Tải lại danh sách học kỳ năm hcocj
                    qlmhC.comboBoxHocKyLoad(cbHK);
                    qlmhC.comboBoxNamHocLoad(cbNamHoc);
                    qlmhC.chonHKNHHienTai(cbHK, cbNamHoc);

                    qlmhC.comboBoxHocKyLoad(txtHK);
                    qlmhC.comboBoxNamHocLoad(txtNamHoc);

                    dtgvLopHoc_CellClick_1(dtgvLopHoc, new DataGridViewCellEventArgs(0, 0));

                    MessageBox.Show("Thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui lòng kiểm tra lại tính hợp lệ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void dtgvNamHocHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (colIndex != 2) return;

            foreach(DataGridViewRow row in dtgvNamHocHocKy.Rows)
            {
                row.Cells[2].Value = false;
            }
            dtgvNamHocHocKy.Rows[rowIndex].Cells[colIndex].Value = true;
        }

        private void dtgvNamHocHocKy_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dtgvNamHocHocKy.Rows[e.RowIndex].Cells[2].Value = true;
        }

        private void dtgvNamHocHocKy_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox a;
            a = e.Control as TextBox;
            a.CharacterCasing = CharacterCasing.Upper;
            a.KeyPress += textbox_keypress;
        }

        void textbox_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
