using BusTicketManagementApplication.src.layers.databaseLayers;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSMain: IBSMain
    {
        DBMain db;
        //
        public BSMain()
        {
            db = new DBMain();
        }
        public BSMain(string connectionString)
        {
            db = new DBMain(connectionString);
        }
        public BSMain(DBMain db)
        {
            this.db = db;
        }
        //
        // Functions
        public List<int> RunTableValuedFunc(string funcName, List<int> parameters = null)
        {
            List<int> list = null;
            string query = $"select * from dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            string errMsg = null;
            list = db.ExecuteQueryList(query, CommandType.Text, ref errMsg)?.Select(d => Convert.ToInt32(d?[0]))?.ToList();
            return list;
        }
        public List<string> RunTableValuedFunc(string funcName, List<string> parameters = null)
        {
            List<string> list = null;
            string query = $"select * from dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            string errMsg = null;
            list = db.ExecuteQueryList(query, CommandType.Text, ref errMsg)?.Select(d => (d?[0])?.ToString())?.ToList();
            return list;
        }
        public List<float> RunTableValuedFunc(string funcName, List<float> parameters = null)
        {
            List<float> list = null;
            string query = $"select * from dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            string errMsg = null;
            list = db.ExecuteQueryList(query, CommandType.Text, ref errMsg)?.Select(d => (float)(d?[0]))?.ToList();
            return list;
        }
        public List<DataRowView> RunTableValuedFunc(string tableValuedFuncCall)
        {
            List<DataRowView> list = null;
            string errMsg = null;
            string query = "select * from dbo." + tableValuedFuncCall;
            list = db.ExecuteQueryList(query, CommandType.Text, ref errMsg);
            return list;
        }
        //
        public string RunFunc(string funcName, List<string> parameters = null)
        {
            string query = $"select dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            string errMsg = null;
            return db.ExecuteScalarByString(query, CommandType.Text,ref errMsg);
        }
        public int RunFunc(string funcName, List<int> parameters = null)
        {
            string query = $"select dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            string errMsg = null;
            return db.ExecuteScalar(query, CommandType.Text, ref errMsg);
        }
        public int RunFunc(string funcCall)
        {
            string errMsg = null;
            string query = "select dbo." + funcCall;
            return db.ExecuteScalar(query, CommandType.Text,ref errMsg);

        }
        public string RunStringResultFunc(string funcCall)
        {
            string errMsg = null;
            string query = "select dbo." + funcCall;
            return db.ExecuteScalarByString(query, CommandType.Text, ref errMsg);

        }
        //
        // Procedures

        public int RunProc(string procName, List<int> parameters = null)
        {
            string query = $"exec dbo.{procName} ";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            string errMsg = null;
            return db.ExecuteScalar(query, CommandType.Text, ref errMsg);
        }
        public string RunProc(string procName, List<string> parameters = null)
        {
            string query = $"exec dbo.{procName} ";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            string errMsg = null;
            return db.ExecuteScalarByString(query, CommandType.Text,ref errMsg);
        }
        public int RunProc(string procCall)
        {
            string errMsg = null;
            string query = "exec dbo." + procCall;
            return db.ExecuteScalar(query, CommandType.Text, ref errMsg);
        }
        public string RunStringResultProc(string procCall)
        {
            string errMsg = null;
            string query = "exec dbo." + procCall;
            return db.ExecuteScalarByString(query, CommandType.Text, ref errMsg);
        }
        public List<DataRowView> RunTableValuedProc(string procCall)
        {
            string errMsg = null;
            string query = "exec dbo." + procCall;
            return db.ExecuteQueryList(query, CommandType.Text, ref errMsg);
        }
        public void RunNonQueryProc(string procCall)
        {
            string errMsg = null;
            string query = "exec dbo." + procCall;
            db.ExecuteNonQuery(query, CommandType.Text, ref errMsg);
        }
        //
        // Utilities
        public List<DataRowView> GetTable(string tableName)
        {
            string query = $"select * from dbo.[{tableName}]";
            string errMsg = null;
            return NameColumns(db.ExecuteQueryList(query, CommandType.Text, ref errMsg) , BusManagementEntities.columnNames[tableName]);
        }
        //
        public List<DataRowView> NameColumns(List<DataRowView> rows, List<string> names)
        {
            List<DataRowView> rowsWithNamedColumns = new List<DataRowView>();
            if (rows.Count > 0)
            {
                DataTable dataTable = new DataTable();
                foreach (string name in names)
                {
                    dataTable.Columns.Add(name, typeof(object));
                }
                foreach (DataRowView row in rows)
                {
                    DataRowView newRow = dataTable.DefaultView.AddNew();
                    for (int i = 0; i < names.Count; i++)
                    {
                        newRow[names[i]] = row[i];
                    }
                    rowsWithNamedColumns.Add(newRow);
                }
            }
            return rowsWithNamedColumns;
        }

    }
}
