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
    class QuanLyNguoiDungController
    {
        CdbController dangnhap;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Views.QuanLyNguoiDung));

        public QuanLyNguoiDungController()
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

        public void bindingThongTin(int MaSo, int tucach, TextBox txtTen, TextBox txtHo, DateTimePicker dateSN, ComboBox cbGT, TextBox txtSdt, TextBox txtQueQuan, ComboBox cbTuCach, PictureBox pbanh, TextBox txtTenDN, TextBox txtPass, TextBox txtMa, int d)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@d", SqlDbType.Int).Value = d;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(MaSo == Convert.ToInt32(dt.Rows[i][0]) && tucach == Convert.ToInt32(dt.Rows[i][10]))
                {
                    txtTen.Text = dt.Rows[i][2].ToString();
                    txtHo.Text = dt.Rows[i][3].ToString();
                    dateSN.Text = DateTime.Parse(dt.Rows[i][5].ToString()).ToString();
                    cbGT.Text = (Convert.ToInt32(dt.Rows[i][6]) == 1) ? "Nam" : "Nữ";
                    txtSdt.Text = dt.Rows[i][7].ToString();
                    txtQueQuan.Text = dt.Rows[i][8].ToString();
                    txtPass.Text = dt.Rows[i][4].ToString();
                    txtTenDN.Text = dt.Rows[i][1].ToString();
                    txtMa.Text = MaSo.ToString();
                    cbTuCach.Text = (Convert.ToInt32(dt.Rows[i][10]) == 0) ? "Sinh Viên" : (Convert.ToInt32(dt.Rows[i][10]) == 1) ? "Giảng Viên" : "Admin";
                    try
                    {
                        pbanh.Image = Image.FromStream(new MemoryStream((byte[])(dt.Rows[i][9])));
                    }
                    catch
                    {
                        pbanh.Image = ((System.Drawing.Image)(resources.GetObject("pbAnh.Image")));
                    }
                }
            }
        }

        public bool CapNhatInfo(string tendangnhap, string ten, string ho, string password, string birthday, int gioitinh, string sdt, string quequan, byte[] anh, int tucach, int maso)
        {
            SqlCommand cmd = new SqlCommand("sp_updateSinhVien");
            cmd.CommandType = CommandType.StoredProcedure;

            object b = anh;

            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = maso;
            cmd.Parameters.Add("@TenDN", SqlDbType.NVarChar, 20).Value = tendangnhap;
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 20).Value = ten;
            cmd.Parameters.Add("@Ho", SqlDbType.NVarChar, 20).Value = ho;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = password;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@GioiTInh", SqlDbType.Int).Value = gioitinh;
            cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar, 15).Value = sdt;
            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar, 20).Value = quequan;
            cmd.Parameters.Add("@Anh", SqlDbType.Image).Value = (b == null) ? DBNull.Value : b;
            cmd.Parameters.Add("@TuCach", SqlDbType.Int).Value = tucach;

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

        public bool insertNewSinhVien(string tendangnhap, string ten, string ho, string password, string birthday, int gioitinh, string sdt, string quequan, byte[] anh, int tc)
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
            cmd.Parameters.Add("@TuCach", SqlDbType.Int).Value = tc;

            return dangnhap.ExecuteNonQuery(cmd);
        }

        public bool DeleteUser(int maso, int tucach)
        {
            SqlCommand cmd = new SqlCommand("sp_deleteuser");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@maso", SqlDbType.Int).Value = maso;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = tucach;

            return dangnhap.ExecuteNonQuery(cmd);
        }

        public void Search(int loaitk, string nd, int loaitc, DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_TimKiem");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@loaiTK", SqlDbType.Int).Value = loaitk;
            cmd.Parameters.Add("@noidung", SqlDbType.NVarChar, 20).Value = nd;
            if(loaitc != -1)
            {
                cmd.Parameters.Add("@tc", SqlDbType.Int).Value = loaitc;
            }
            else
            {
                cmd.Parameters.Add("@tc", SqlDbType.Int).Value = DBNull.Value;
            }

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            dtgv.DataSource = dt;
        }
    }
}
