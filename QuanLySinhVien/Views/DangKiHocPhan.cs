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
    public partial class DangKiHocPhan : Form
    {
        DangKyLopHocPhanController dkhpC = new DangKyLopHocPhanController();

        public DangKiHocPhan()
        {
            InitializeComponent();
        }

        private void DangKiHocPhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dkhpC.loadDatatoDSLop(dtgvLopChuaDK, 0, GlobalVariable.GVMaSo);

            dkhpC.chonHKNHHienTai(txtHK, txtNamHoc);

            // lớp đầy
            foreach(DataGridViewRow row in dtgvLopChuaDK.Rows)
            {
                if(row.Cells[5].Value.ToString() == row.Cells[6].Value.ToString())
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dtgvLopChuaDK.DataSource];
                    currencyManager.SuspendBinding();
                    dtgvLopChuaDK.CurrentCell = null;
                    dtgvLopChuaDK.Rows.RemoveAt(row.Index);
                }
            }

            // Lọc các lớp trong học kì này
            foreach (DataGridViewRow row in dtgvLopChuaDK.Rows)
            {
                if (row.Cells[3].Value.ToString() != txtHK.Text || row.Cells[4].Value.ToString() != txtNamHoc.Text)
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dtgvLopChuaDK.DataSource];
                    currencyManager.SuspendBinding();
                    dtgvLopChuaDK.CurrentCell = null;
                    dtgvLopChuaDK.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                dkhpC.DangKiHocPhan(Convert.ToInt32(dtgvLopChuaDK.SelectedRows[0].Cells[0].Value), GlobalVariable.GVMaSo);
                MessageBox.Show("Đăng kí thành công!");
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không có lớp để đăng kí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
