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

        public void dataGridDsSv(DataGridView dtgv, int malop, int manv, out int tt)
        {
            SqlCommand cmd = new SqlCommand("sp_getDSSV");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Char, 5).Value = malop;

            if (manv == -1)
            {
                cmd.Parameters.Add("@ma", SqlDbType.Char, 15).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@ma", SqlDbType.Char, 15).Value = manv;
            }
            
            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            dtgv.DataSource = dt;

            try
            {
                tt = Convert.ToInt32(dt.Rows[0][7]);
            }
            catch
            {
                tt = 0;
            }
            
        }

        public bool CapNhatDsDiem(float tk, float gk, float ck, int masv, int malop)
        {
            SqlCommand cmd = new SqlCommand("sp_CapNhatDiem");
            cmd.CommandType = CommandType.StoredProcedure;

            // TK
            if (tk != -1)
            {
                cmd.Parameters.Add("@tk", SqlDbType.Float).Value = tk;
            }
            else
            {
                cmd.Parameters.Add("@tk", SqlDbType.Float).Value = DBNull.Value;
            }

            //GK
            if (gk != -1)
            {
                cmd.Parameters.Add("@gk", SqlDbType.Float).Value = gk;
            }
            else
            {
                cmd.Parameters.Add("@gk", SqlDbType.Float).Value = DBNull.Value;
            }

            // CK
            if (ck != -1)
            {
                cmd.Parameters.Add("@ck", SqlDbType.Float).Value = ck;
            }
            else
            {
                cmd.Parameters.Add("@ck", SqlDbType.Float).Value = DBNull.Value;
            }

            cmd.Parameters.Add("@masv", SqlDbType.Char, 15).Value = masv;
            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;

            return dangnhap.ExecuteNonQuery(cmd);
        }
    }
}
