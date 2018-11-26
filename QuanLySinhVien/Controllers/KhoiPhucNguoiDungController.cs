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
    class KhoiPhucNguoiDungController
    {
        CdbController dangnhap;
        public KhoiPhucNguoiDungController()
        {
            dangnhap = new CdbController();
        }

        public void LoadThongTin(DataGridView dtgv, int d)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@d", SqlDbType.Int).Value = d;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            dtgv.DataSource = dt;
        }

        public bool RestoreUsers(int maso, int tucach)
        {
            SqlCommand cmd = new SqlCommand("sp_restoreuser");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@maso", SqlDbType.Int).Value = maso;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = tucach;

            return dangnhap.ExecuteNonQuery(cmd);
        }

        public bool xoaHoanToan(int maso, int tucach)
        {
            SqlCommand cmd = new SqlCommand("sp_xoaHoanToan");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = maso;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = tucach;

            return dangnhap.ExecuteNonQuery(cmd);
        }
    }
}
