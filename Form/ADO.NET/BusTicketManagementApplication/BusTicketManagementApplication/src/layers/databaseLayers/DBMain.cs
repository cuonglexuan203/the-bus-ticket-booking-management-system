using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using BusTicketManagementApplication.src.env.statics;

namespace BusTicketManagementApplication.src.layers.databaseLayers
{
    internal class DBMain: IDBMain
    {
        string strConnection = StaticEnv.GetConnectionString();

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        SqlDataReader reader = null;
        //
        public DBMain()
        {
            conn = new SqlConnection(strConnection);
            cmd = conn.CreateCommand();
        }
        public DBMain(string strConn)
        {
            conn = new SqlConnection(strConn);
            cmd = conn.CreateCommand();
        }
        //

        public List<DataRowView> ExecuteQueryList(string query, CommandType type, ref string errMsg)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = query;
            cmd.CommandType = type;
            adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException err)
            {
                errMsg = err.Message;
                MessageBox.Show(errMsg);
            }
            catch(Exception err)
            {
                errMsg = err.Message;
                MessageBox.Show(errMsg);
            }
            finally
            {
                conn.Close();
            }
            return ds.Tables[0].AsDataView().Cast<DataRowView>().ToList();
        }

        public SqlDataReader ExecuteQueryDataReader(string query, CommandType type, ref string errMsg)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = query;
            cmd.CommandType = type;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (SqlException err)
            {
                errMsg = err.Message;
                MessageBox.Show(errMsg);
            }
            catch (Exception err)
            {
                errMsg = err.Message;
                MessageBox.Show(errMsg);
            }
            finally
            {
                conn.Close();
            }
            return reader;
        }
        //
        public bool ExecuteNonQuery(string query, CommandType type, ref string errMsg)
        {
            bool successed = false;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = query;
            cmd.CommandType = type;
            try
            {
                cmd.ExecuteNonQuery();
                successed = true;
            }
            catch (SqlException e)
            {
                errMsg = e.Message;
                MessageBox.Show(errMsg);
            }
            finally { conn.Close(); }
            return successed;
        }
        public int ExecuteScalar(string query, CommandType type, ref string errMsg)
        {
            int count = 0;
            string res = string.Empty;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = query;
            cmd.CommandType = type;
            try
            {
                count = (int)cmd.ExecuteScalar();

            }
            catch (SqlException e)
            {
                errMsg = e.Message;
            }
            finally { conn.Close(); }
            return count;
        }
        public string ExecuteScalarByString(string query, CommandType type, ref string errMsg)
        {

            string res = string.Empty;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.CommandText = query;
            cmd.CommandType = type;
            try
            {
                res = ((string)cmd.ExecuteScalar()).Trim();

            }
            catch (SqlException e)
            {
                errMsg = e.Message;
            }
            finally { conn.Close(); }
            return res;
        }
    }
}
