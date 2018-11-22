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
        private string connectionString = ConnectionString.AZURE_STRING;

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

        public bool UpdateAdapter(SqlCommand cmd, DataGridView dtgv)
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
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
            return true;
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

    public static class TryConnect
    {
        public static bool isAvailable(this SqlConnection conn)
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể kết nối đến Database!");
                return false;
            }
            return true;
        }
    }
}
