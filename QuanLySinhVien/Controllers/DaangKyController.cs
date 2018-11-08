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
    class DaangKyController
    {
        public CdbController dangnhap;

        public DaangKyController()
        {
            dangnhap = new CdbController();
        }

        public bool insertNewSinhVien(string tendangnhap, string ten, string ho, string password, string birthday, int gioitinh, string sdt, string quequan, byte[] anh)
        {
            SqlCommand cmd = new SqlCommand("sp_insertNewSinhVien");
            cmd.CommandType = CommandType.StoredProcedure;
            
            object b = anh;

            cmd.Parameters.Add("@TenDN", SqlDbType.NVarChar, 20).Value = tendangnhap;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@Ho", SqlDbType.NVarChar, 20).Value = ho;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = password;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@GioiTInh", SqlDbType.Int).Value = gioitinh;
            cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar, 15).Value = sdt;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 20).Value = quequan;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = (b == null) ? DBNull.Value : b;
            cmd.Parameters.Add("@TuCach", SqlDbType.Int).Value = 0;

            return dangnhap.ExecuteNonQuery(cmd);
        }

        public bool checkTenDangNhap(string tendn)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@d", SqlDbType.Int).Value = DBNull.Value;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (tendn == dt.Rows[i][1].ToString())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
