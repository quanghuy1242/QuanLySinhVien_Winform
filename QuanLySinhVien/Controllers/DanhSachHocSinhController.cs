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
    class DanhSachHocSinhController
    {
        CdbController dangnhap;
        
        public DanhSachHocSinhController()
        {
            dangnhap = new CdbController();
        }

        public void dataGridDsSv(DataGridView dtgv, int malop)
        {
            SqlCommand cmd = new SqlCommand("sp_getDSSV");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Char, 5).Value = malop;
            cmd.Parameters.Add("@magv", SqlDbType.Char, 15).Value = GlobalVariable.GVMaSo;

            dtgv.DataSource = dangnhap.OpenDataSet(cmd).Tables[0];
        }

        public bool CapNhatDsDiem(float tk, float gk, float ck, int masv, int malop)
        {
            SqlCommand cmd = new SqlCommand("sp_CapNhatDiem");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tk", SqlDbType.Float).Value = tk;
            cmd.Parameters.Add("@gk", SqlDbType.Float).Value = gk;
            cmd.Parameters.Add("@ck", SqlDbType.Float).Value = ck;
            cmd.Parameters.Add("@masv", SqlDbType.Char, 15).Value = masv;
            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;

            return dangnhap.ExecuteNonQuery(cmd);
        }
    }
}
