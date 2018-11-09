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
            foreach(DataGridViewRow row in dtgvLopChuaDK.Rows)
            {
                if(row.Cells[5].Value.ToString() == row.Cells[6].Value.ToString())
                {
                    CurrencyManager currencyManager = (CurrencyManager)BindingContext[dtgvLopChuaDK.DataSource];
                    currencyManager.SuspendBinding();
                    dtgvLopChuaDK.CurrentCell = null;
                    row.Visible = false;
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            dkhpC.DangKiHocPhan(Convert.ToInt32(dtgvLopChuaDK.SelectedRows[0].Cells[0].Value), GlobalVariable.GVMaSo);
            MessageBox.Show("Đăng kí thành công!");
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
