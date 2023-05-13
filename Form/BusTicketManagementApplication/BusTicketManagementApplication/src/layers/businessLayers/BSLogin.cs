//using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Configuration;
using System.Configuration.Internal;
using BusTicketManagementApplication.src.env.statics;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSLogin
    {
        namespace BusTicketManagementApplication.src.layers.businessLayers
    {
        internal class BSLogin
        {
            public V_USERINFOR GetUser(string passengerId)
            {
                using (var db = new BusManagementEntities())
                {
                    return db.V_USERINFOR.FirstOrDefault(d => d.id_passenger == passengerId);
                }
            }
        }
        public V_EMPLOYEEINFOR GetEmployee(string systemId)
        {
            using (var db = new BusManagementEntities())
            {
                return db.V_EMPLOYEEINFOR.FirstOrDefault(d => d.Employees_ID == systemId);
            }
        }

        public bool IsAdmin(string employeeId)
        {
            using (var db = new BusManagementEntities(StaticEnv.GetDefaultEFConnectionString()))
            {
                return db.V_EMPLOYEEINFOR.Count(d => d.Employees_ID == employeeId && d.Position == "administrator") > 0;
            }
        }

        public bool ValidateUser(string username, string password, ref string passengerId, ref string employeeId, ref string errMsg)
        {
            try
            {
                using (var db = new BusManagementEntities(StaticEnv.GetDefaultEFConnectionString()))
                {
                    // init errMsg
                    errMsg = "Login successfully! No error.";
                    passengerId = null;
                    employeeId = null;
                    var curPassenger = db.PASSENGERACCOUNTs.FirstOrDefault(d => d.username == username && d.password == password);
                    if (curPassenger != null)
                    {
                        passengerId = curPassenger.id_passenger?.Trim();
                        return true;
                    }
                    var curEmployee = db.SYSTEMACCOUNTs.FirstOrDefault(d => d.username == username && d.pass == password);
                    if (curEmployee != null)
                    {
                        employeeId = db.EMPLOYEEs.FirstOrDefault(d => d.id_account == curEmployee.id_account)?.id_employee?.Trim();
                        return true;
                    }
                    errMsg = "Username or Password is incorrect!";
                    passengerId = string.Empty;
                }
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
            return false;
        }

        public bool CreateNewUser(string username, string password, string name, string phone, ref string passengerId, ref string errMsg)
        {
            passengerId = string.Empty;
            try
            {
                foreach (char c in username)
                {
                    if (c < 48 || (c > 57 && c < 65) || (c > 90 && c < 97) || c > 122)
                    {
                        errMsg = "Username is invalid. Username must be letters in alphabet and digits";
                        return false;
                    }
                }

                using (var db = new BusManagementEntities(StaticEnv.GetDefaultEFConnectionString()))
                {
                    db.Database.BeginTransaction();
                    try
                    {
                        // check whether unique username
                        db.Database.ExecuteSqlCommand($"exec pro_CheckUniqueUser @username", new SqlParameter("username", username)); // if there are exist user , throw an sql exception

                        // in case of unique username
                        string funcName = "func_auto_id_passenger";
                        passengerId = BSMain.RunFunc(db, funcName);

                        if (string.IsNullOrEmpty(passengerId))
                        {
                            errMsg = "Can't get new passengerId.";
                            return false;
                        }

                        db.pro_AddPassenger(passengerId, name, phone);
                        db.pro_AddPassengerAccount(passenger
