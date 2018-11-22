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
    class QuanLyMonHocController
    {
        CdbController dangnhap;

        public QuanLyMonHocController()
        {
            dangnhap = new CdbController();
        }

        public void comboBoxHocKyLoad(ComboBox cbHK)
        {
            SqlCommand cmd = new SqlCommand("sp_GetHocKy");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            cbHK.DataSource = dt;
            cbHK.DisplayMember = "HocKy";
            cbHK.ValueMember = "HocKy";
        }

        public void comboBoxNamHocLoad(ComboBox cbNamHoc)
        {
            SqlCommand cmd = new SqlCommand("sp_GetNamHoc");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];
            cbNamHoc.DataSource = dt;
            cbNamHoc.DisplayMember = "NamHoc";
            cbNamHoc.ValueMember = "NamHoc";
        }

        public void dataGridViewMonHocLoad(DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_getAllSubject");
            cmd.CommandType = CommandType.StoredProcedure;

            dtgv.DataSource = dangnhap.OpenDataSet(cmd).Tables[0];
        }

        public void dataGridViewLopHocLoad(ComboBox cbHk, ComboBox cbNamHoc, DataGridView dtgv, int maMH)
        {
            SqlCommand cmd = new SqlCommand("sp_GetClassFromSubject");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = cbHk.SelectedValue;
            cmd.Parameters.Add("@nh", SqlDbType.Char, 15).Value = cbNamHoc.SelectedValue;
            cmd.Parameters.Add("@maMH", SqlDbType.Int).Value = maMH;

            dtgv.DataSource = dangnhap.OpenDataSet(cmd).Tables[0];
        }
        
        public void updatedtgvtodb(DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_getAllSubject");
            cmd.CommandType = CommandType.StoredProcedure;

            dangnhap.UpdateAdapter(cmd, dtgv);
        }

        public string getTenGV(int magv)
        {
            SqlCommand cmd = new SqlCommand("sp_GetInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = magv;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            return dt.Rows[0][3].ToString() + " " + dt.Rows[0][2].ToString();
        }

        public void updateClass(int malop, int magv, int mamh, string hocky, string namhoc, int siso, string tenLop)
        {
            SqlCommand cmd = new SqlCommand("sp_updateClass");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;
            cmd.Parameters.Add("@magv", SqlDbType.Int).Value = magv;
            cmd.Parameters.Add("@mamh", SqlDbType.Int).Value = mamh;
            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = hocky;
            cmd.Parameters.Add("@namhoc", SqlDbType.Char, 15).Value = namhoc;
            cmd.Parameters.Add("@ss", SqlDbType.Int).Value = siso;
            cmd.Parameters.Add("@tenlop", SqlDbType.Char, 15).Value = tenLop;

            dangnhap.ExecuteNonQuery(cmd);
        }

        public void chonHKNHHienTai(ComboBox hk, ComboBox nh)
        {
            SqlCommand cmd = new SqlCommand("sp_getNamHocHocKyHienTai");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            hk.Text = dt.Rows[0][1].ToString();
            nh.Text = dt.Rows[0][0].ToString();
        }

        public void insertNewClass(int magv, int mamh, string hocky, string namhoc, int siso, string tenLop)
        {
            SqlCommand cmd = new SqlCommand("sp_addNewClass");
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@magv", SqlDbType.Int).Value = magv;
            cmd.Parameters.Add("@mamh", SqlDbType.Int).Value = mamh;
            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = hocky;
            cmd.Parameters.Add("@namhoc", SqlDbType.Char, 15).Value = namhoc;
            cmd.Parameters.Add("@ss", SqlDbType.Int).Value = siso;
            cmd.Parameters.Add("@tenlop", SqlDbType.Char, 15).Value = tenLop;

            dangnhap.ExecuteNonQuery(cmd);
        }

        public bool checkGiangVienInLopHoc(int magv, string hk, string namhoc, int mamon)
        {
            SqlCommand cmd = new SqlCommand("sp_GetClassInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = hk;
            cmd.Parameters.Add("@namhoc", SqlDbType.Char, 15).Value = namhoc;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = magv;
            cmd.Parameters.Add("@dadk", SqlDbType.Int).Value = 0;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (mamon == Convert.ToInt32(dt.Rows[i][6]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool checkMaSinhVien(int ma)
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllPerson");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            for (int e = 0; e < dt.Rows.Count;e++)
            {
                if(Convert.ToInt32(dt.Rows[e][2]) == ma)
                {
                    return true;
                }
            }
            return false;
        }

        public int checkLopSVDaHoc(int malop, int masv)
        {
            SqlCommand cmd = new SqlCommand("sp_checkSVMaLopDaCo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@MaLop", SqlDbType.Int).Value = malop;
            cmd.Parameters.Add("@MaSV", SqlDbType.Int).Value = masv;

            return Convert.ToInt32(dangnhap.OpenDataSet(cmd).Tables[0].Rows[0][0]);
        }

        public void DangKiHocPhan(int malop, int masv)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertNewStudenttoClass");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;
            cmd.Parameters.Add("@masv", SqlDbType.Int).Value = masv;

            dangnhap.ExecuteNonQuery(cmd);
        }

        public void HuyHocPhan(int malop, int masv)
        {
            SqlCommand cmd = new SqlCommand("sp_HuyHocPhan");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;
            cmd.Parameters.Add("@masv", SqlDbType.Int).Value = masv;

            dangnhap.ExecuteNonQuery(cmd);
        }

        public bool checklopday(int malop)
        {
            SqlCommand cmd = new SqlCommand("sp_checklopday");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@malop", SqlDbType.Int).Value = malop;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            int siso = Convert.ToInt32(dt.Rows[0][0]);
            int dadk = Convert.ToInt32(dt.Rows[0][1]);

            if (dadk < siso) return true;
            return false;
        }

        public void loadComboBoxGiangVien(ComboBox MaGV, ComboBox TenGV, out Dictionary<int, string> ahhh)
        {
            Dictionary<int, string> danhSachGV = new Dictionary<int, string>();

            SqlCommand cmd = new SqlCommand("sp_GetAllP");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@d", SqlDbType.Int).Value = 0;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(dt.Rows[i][10].ToString() == "1")
                {
                    int key = Convert.ToInt32(dt.Rows[i][0]);
                    string value = dt.Rows[i][3].ToString() + " " + dt.Rows[i][2].ToString();
                    danhSachGV.Add(key, value);
                }
            }

            ahhh = danhSachGV;

            // CBMaGV
            MaGV.DataSource = danhSachGV.Keys.ToList();
            MaGV.DisplayMember = "MaGV";
            //MaGV.ValueMember = "MaGVV";

            // CB Tên GV
            TenGV.DataSource = danhSachGV.Values.ToList();
            TenGV.DisplayMember = "MaGV";
            //TenGV.ValueMember = "MaGVV";
        }

        public int loadTrangThaiCapNhat(string hk, string nh)
        {
            SqlCommand cmd = new SqlCommand("sp_getStateofAllow");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = hk;
            cmd.Parameters.Add("@nh", SqlDbType.Char, 15).Value = nh;

            try
            {
                return Convert.ToInt32(dangnhap.OpenDataSet(cmd).Tables[0].Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }

        public void updateTrangThaiCapNhat(string hk, string nh, int tt)
        {
            SqlCommand cmd = new SqlCommand("sp_updateStateofAllow");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = hk;
            cmd.Parameters.Add("@nh", SqlDbType.Char, 15).Value = nh;
            cmd.Parameters.Add("@tt", SqlDbType.Int).Value = tt;

            dangnhap.ExecuteNonQuery(cmd);
        }
        public int getSoLopCuaMotMon(int MaMH)
        {
            SqlCommand cmd = new SqlCommand("sp_getDSMH");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i][0]) == MaMH)
                {
                    return Convert.ToInt32(dt.Rows[i][1]);
                }
            }

            return -1;
        }

        public void dtgvNHHK(DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_getDSHKNH");
            cmd.CommandType = CommandType.StoredProcedure;


            dtgv.DataSource = dangnhap.OpenDataSet(cmd).Tables[0];
        }

        public bool updatedtgvHKNHtodb(DataGridView dtgv)
        {
            SqlCommand cmd = new SqlCommand("sp_getDSHKNH");
            cmd.CommandType = CommandType.StoredProcedure;

            return dangnhap.UpdateAdapter(cmd, dtgv);
        }
    }
}
