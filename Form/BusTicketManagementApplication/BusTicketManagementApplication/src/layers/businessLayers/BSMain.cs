using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal static class BSMain
    {
        public static List<int> RunTableValuedFunc(string funcName, List<int> parameters = null)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            List<int> list = null;

            string query = $"select * from {funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.ExecuteQuery<int>(query).ToList();
            return list;
        }
        public static List<string> RunTableValuedFunc(string funcName, List<string> parameters = null)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            List<string> list = null;
            string query = $"select * from dbo.{funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.ExecuteQuery<string>(query).ToList();
            return list;
        }
        public static List<float> RunTableValuedFunc(string funcName, List<float> parameters = null)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            List<float> list = null;

            string query = $"select * from {funcName}(";
            if (parameters != null && parameters.Count > 0)
            {
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            query += ")";
            list = db.ExecuteQuery<float>(query).ToList();
            return list;
        }
        public static string RunFunc(string funcName)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string query = $"select dbo.{funcName}()";
            return db.ExecuteQuery<string>(query).ToList().FirstOrDefault().ToString();
        }
        public static string RunFunc(BusManagementEntitiesDataContext db, string funcName)
        {
            string query = $"select dbo.{funcName}()";
            return db.ExecuteQuery<string>(query).ToList().FirstOrDefault().ToString();
        }

        // modify run proc // redundant
        public static void RunProc(string procName)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string query = $"exec dbo.{procName}";
            db.ExecuteQuery<string>(query).ToList().FirstOrDefault().ToString();
        }
        public static void RunProc(string procName, List<string> parameters = null)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string query = $"exec dbo.{procName} ";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            db.ExecuteQuery<string>(query).ToList().FirstOrDefault().ToString();
            db.SubmitChanges();
        }

    }
}
