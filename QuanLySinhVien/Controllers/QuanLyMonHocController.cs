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

    }
}
