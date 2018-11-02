using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace QuanLySinhVien.Controllers
{
    class ThongTinSinhVienController
    {
        public CdbController dangnhap;

        public ThongTinSinhVienController()
        {
            dangnhap = new CdbController();
        }

        public void loadThongTin(TextBox txtMaSo, TextBox txtHoTen, TextBox txtNgaySinh, TextBox txtGioiTinh, TextBox txtSdt, TextBox txtQueQuan, TextBox txtTuCach, PictureBox pictureBox)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = GlobalVariable.GVMaSo;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = GlobalVariable.GVTuCach;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                {
                    txtMaSo.Text = GlobalVariable.GVMaSo.ToString();
                    txtHoTen.Text = dt.Rows[i][3].ToString() + " " + dt.Rows[i][2].ToString();
                    txtNgaySinh.Text = DateTime.Parse(dt.Rows[i][5].ToString()).ToString();
                    txtGioiTinh.Text = (Convert.ToInt32(dt.Rows[i][6]) == 1) ? "Nam" : "Nữ";
                    txtSdt.Text = dt.Rows[i][7].ToString();
                    txtQueQuan.Text = dt.Rows[i][8].ToString();
                    txtTuCach.Text = (Convert.ToInt32(dt.Rows[i][10]) == 0) ? "Sinh Viên" : (Convert.ToInt32(dt.Rows[i][10]) == 1) ? "Giảng Viên" : "Admin";
                    try
                    {
                        pictureBox.Image = Image.FromStream(new MemoryStream((byte[])(dt.Rows[i][9])));
                    }
                    catch
                    {

                    }
                    try
                    {
                        GlobalVariable.GVAnh = (byte[])(dt.Rows[i][9]);
                    }
                    catch
                    {
                        GlobalVariable.GVAnh = null;
                    }
                }
            }
        }
    }
}
