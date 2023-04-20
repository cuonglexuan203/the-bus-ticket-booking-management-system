using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal static class BSMain
    {
        public static List<int> RunFunc(string funcName, List<int> parameters = null)
        {
            BusManagementEntities db = new BusManagementEntities();
            List<int> list = null;
            
            string query = $"select * from {funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.Database.SqlQuery<int>(query).ToList();
            return list;
        }
        public static List<string> RunFunc(string funcName, List<string> parameters = null)
        {
            BusManagementEntities db = new BusManagementEntities();
            List<string> list = null;
            string query = $"select * from dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.Database.SqlQuery<string>(query).ToList();
            return list;
        }
        public static List<float> RunFunc(string funcName, List<float> parameters = null)
        {
            BusManagementEntities db = new BusManagementEntities();
            List<float> list = null;

            string query = $"select * from {funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.Database.SqlQuery<float>(query).ToList();
            return list;
        }
        //public static string RunFunc(string funcName)
        //{
        //    BusManagementEntities db = new BusManagementEntities();
        //    string query = $"select func"
        //}
    }
}
