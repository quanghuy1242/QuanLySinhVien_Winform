using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVien.Controllers
{
    class DangNhapController
    {
        public CdbController dangnhap;

        public DangNhapController()
        {
            dangnhap = new CdbController();
        }

        public bool checkDangNhap(TextBox txtMaSo, TextBox txtPass)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllPerson");
            cmd.CommandType = CommandType.StoredProcedure;

            string maso = Convert.ToString(txtMaSo.Text);
            string password = txtPass.Text;

            string passdt, tendangnhap;
            int daxoa;
            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tendangnhap = Convert.ToString(dt.Rows[i][0]);
                passdt = dt.Rows[i][1].ToString();
                daxoa = Convert.ToInt32(dt.Rows[i][4]);

                if (maso == tendangnhap && password == passdt && daxoa == 0)
                {
                    GlobalVariable.GVtendn = tendangnhap;
                    GlobalVariable.GVPassword = passdt;
                    GlobalVariable.GVMaSo = Convert.ToInt32(dt.Rows[i][2]);
                    GlobalVariable.GVTuCach = Convert.ToInt32(dt.Rows[i][3]);

                    return true;
                }
            }
            return false;
        }
    }
}
