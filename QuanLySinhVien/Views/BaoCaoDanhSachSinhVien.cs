using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.Views
{
    public partial class BaoCaoDanhSachSinhVien : Form
    {
        public BaoCaoDanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void BaoCaoDanhSachSinhVien_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
