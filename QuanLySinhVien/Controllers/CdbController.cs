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
    class CdbController
    {
        private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QuanLySinhVien2;Integrated Security=True";

        public CdbController()
        {
        }
        public DataSet OpenDataSet(string strSQL)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return ds;
        }

        public void UpdateAdapter(SqlCommand cmd, DataGridView dtgv)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataTable dt = (DataTable)dtgv.DataSource;

            try
            {
                da.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool ExecuteUpdate(string strSQL)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.CommandType = CommandType.Text;
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
            return true;
        }
        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cmd.Connection.Close();
                cn.Close();
            }
            return true;
        }
        public DataSet OpenDataSet(SqlCommand cmd)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.Connection = cn;


            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
                cmd.Connection.Close();
            }
            return ds;
        }
    }
}
