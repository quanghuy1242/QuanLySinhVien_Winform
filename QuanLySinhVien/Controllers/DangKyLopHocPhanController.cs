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
    class DangKyLopHocPhanController
    {
        CdbController dangnhap;
        public DangKyLopHocPhanController()
        {
            dangnhap = new CdbController();
        }

        public void loadDatatoDSLop(DataGridView dtgv, int tc, int ms)
        {
            SqlCommand cmd = new SqlCommand("sp_GetClassInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = "";
            cmd.Parameters.Add("@namhoc", SqlDbType.Char, 15).Value = "";
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = tc;
            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = ms;
            cmd.Parameters.Add("@dadk", SqlDbType.Int).Value = 0;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            dtgv.DataSource = dt;
        }

        public void DangKiHocPhan(int malop, int masv)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertNewStudenttoClass");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;
            cmd.Parameters.Add("@masv", SqlDbType.Int).Value = masv;

            dangnhap.ExecuteNonQuery(cmd);
        }
    }
}
