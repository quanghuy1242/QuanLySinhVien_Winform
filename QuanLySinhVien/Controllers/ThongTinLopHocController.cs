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
    class ThongTinLopHocController
    {
        public CdbController dangnhap;

        public ThongTinLopHocController()
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

        public void chonHKNHHienTai(ComboBox hk, ComboBox nh)
        {
            SqlCommand cmd = new SqlCommand("sp_getNamHocHocKyHienTai");
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = dangnhap.OpenDataSet(cmd).Tables[0];

            hk.Text = dt.Rows[0][1].ToString();
            nh.Text = dt.Rows[0][0].ToString();
        }

        public void dataGridViewLopHocLoad(ComboBox cbHk, ComboBox cbNamHoc, DataGridView dtgv, int maso, int tucach, int dadk)
        {
            SqlCommand cmd = new SqlCommand("sp_GetClassInfo");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@hk", SqlDbType.Char, 5).Value = cbHk.SelectedValue;
            cmd.Parameters.Add("@namhoc", SqlDbType.Char, 15).Value = cbNamHoc.SelectedValue;
            cmd.Parameters.Add("@ms", SqlDbType.Int).Value = maso;
            cmd.Parameters.Add("@tc", SqlDbType.Int).Value = tucach;
            cmd.Parameters.Add("@dadk", SqlDbType.Int).Value = dadk;

            dtgv.DataSource = dangnhap.OpenDataSet(cmd).Tables[0];
            
        }
        
    }
}
