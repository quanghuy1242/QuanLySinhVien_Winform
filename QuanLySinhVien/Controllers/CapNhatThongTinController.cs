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
    class CapNhatThongTinController
    {
        CdbController dangnhap;

        public CapNhatThongTinController()
        {
            dangnhap = new CdbController();
        }

        public bool CapNhatInfo(string tendangnhap, string ten, string ho, string password, string birthday, int gioitinh, string sdt, string quequan, byte[] anh, int tucach, int maso)
        {
            SqlCommand cmd = new SqlCommand("sp_updateSinhVien");
            cmd.CommandType = CommandType.StoredProcedure;

            object b = anh;

            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = GlobalVariable.GVMaSo;
            cmd.Parameters.Add("@TenDN", SqlDbType.NVarChar, 20).Value = tendangnhap;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@Ho", SqlDbType.NVarChar, 20).Value = ho;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = password;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@GioiTInh", SqlDbType.Int).Value = gioitinh;
            cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar, 15).Value = sdt;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 20).Value = quequan;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = (b == null) ? DBNull.Value : b;
            cmd.Parameters.Add("@TuCach", SqlDbType.Int).Value = GlobalVariable.GVTuCach;
            
            GlobalVariable.GVPassword = password;
            try
            {
                GlobalVariable.GVAnh = anh;
            }
            catch
            {
                GlobalVariable.GVAnh = null;
            }

            return dangnhap.ExecuteNonQuery(cmd);
        }

        public void loadThongTin(TextBox txtTen, TextBox txtHo, DateTimePicker txtNgaySinh, ComboBox txtGioiTinh, TextBox txtSdt, TextBox txtQueQuan, TextBox txtTenDN, TextBox txtPass)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = GlobalVariable.GVMaSo;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = GlobalVariable.GVTuCach;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                {
                    txtHo.Text = dt.Rows[i][3].ToString();
                    txtTen.Text = dt.Rows[i][2].ToString();
                    txtNgaySinh.Text = DateTime.Parse(dt.Rows[i][5].ToString()).ToString();
                    txtGioiTinh.Text = (Convert.ToInt32(dt.Rows[i][6]) == 1) ? "Nam" : "Nữ";
                    txtSdt.Text = dt.Rows[i][7].ToString();
                    txtQueQuan.Text = dt.Rows[i][8].ToString();
                    txtTenDN.Text = dt.Rows[i][1].ToString();
                    txtPass.Text = dt.Rows[i][4].ToString();
                }
            }
        }
    }
}
