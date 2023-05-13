using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.databaseLayers
{
    internal interface IDBMain
    {
        List<DataRowView> ExecuteQueryList(string query, CommandType type, ref string errMsg);
        SqlDataReader ExecuteQueryDataReader(string query, CommandType type, ref string errMsg);
        bool ExecuteNonQuery(string query, CommandType type, ref string errMsg);
        int ExecuteScalar(string query, CommandType type, ref string errMsg);
        string ExecuteScalarByString(string query, CommandType type, ref string errMsg);
    }
}
