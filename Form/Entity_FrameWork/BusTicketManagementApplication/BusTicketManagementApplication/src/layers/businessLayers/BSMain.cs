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
        public static List<string> RunTableValuedFunc(string funcName, List<string> parameters = null)
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
        public static List<float> RunTableValuedFunc(string funcName, List<float> parameters = null)
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
        public static string RunFunc(string funcName)
        {
            BusManagementEntities db = new BusManagementEntities();
            string query = $"select dbo.{funcName}()";  
            return db.Database.SqlQuery<string>(query).ToList().FirstOrDefault().ToString();
        }
        public static string RunFunc(DbContext db, string funcName)
        {
            string query = $"select dbo.{funcName}()";
            return db.Database.SqlQuery<string>(query).ToList().FirstOrDefault().ToString();
        }

        // modify run proc // redundant
        public static void RunProc(string procName)
        {
            BusManagementEntities db = new BusManagementEntities();
            string query = $"exec dbo.{procName}";
            db.Database.SqlQuery<string>(query).ToList().FirstOrDefault().ToString();
        }
        public static void RunProc(string procName, List<string> parameters = null)
        {
            BusManagementEntities db = new BusManagementEntities();
            string query = $"exec dbo.{procName} ";
            if (parameters != null && parameters.Count > 0)
            {
                parameters = parameters.Select(d => "'" + d + "'").ToList();
                string inputParams = string.Join(", ", parameters);
                query += inputParams;
            }
            db.Database.SqlQuery<string>(query).ToList().FirstOrDefault().ToString();
            db.SaveChanges();
        }

    }
}
