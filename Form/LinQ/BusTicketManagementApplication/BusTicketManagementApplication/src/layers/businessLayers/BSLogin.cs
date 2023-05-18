using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSLogin
    {
        public V_USERINFOR GetUser(string passengerId)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            return db.V_USERINFORs.Where(d => d.id_passenger == passengerId).FirstOrDefault();
        }
        public V_EMPLOYEEINFOR GetEmployee(string systemId)
        {
            return new BusManagementEntitiesDataContext().V_EMPLOYEEINFORs.Where(d => d.Employees_ID == systemId).FirstOrDefault();
        }
        public bool IsAdmin(string employeeId)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext(StaticEnv.GetDefaultEFConnectionString());
            return db.V_EMPLOYEEINFORs.Count(d => d.Employees_ID == employeeId && d.Position == "administrator") > 0;
        }
        public bool ValidateUser(string username, string password, ref string passengerId, ref string employeeId, ref string errMsg)
        {
            try
            {
                BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext(StaticEnv.GetDefaultEFConnectionString());
                // init errMsg
                errMsg = "Login successfully! No error.";
                passengerId = null;
                employeeId = null;
                var curPassenger = db.PASSENGERACCOUNTs.Where(d => d.username == username && d.password == password);
                if (curPassenger != null && curPassenger.Count() > 0)
                {
                    passengerId = curPassenger.FirstOrDefault().id_passenger.Trim();
                    return true;
                }
                //
                var curEmployee = db.SYSTEMACCOUNTs.Where(d => d.username == username && d.pass == password);
                if (curEmployee != null && curEmployee.Count() > 0)
                {
                    employeeId = db.EMPLOYEEs.Where(d => d.id_account == curEmployee.FirstOrDefault().id_account).FirstOrDefault().id_employee.Trim();
                    return true;
                }
                //
                errMsg = "Username or Password is incorrect!";
                passengerId = string.Empty;
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
                //
                BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext(StaticEnv.GetDefaultEFConnectionString());

                //
                // way 1
                //bool uniqueUser = db.PASSENGERACCOUNTs.Count(d => d.username == username) == 0;
                //if (!uniqueUser)
                //{
                //    errMsg = "Username has exist in the system!";
                //    return false;
                //}
                //
                // way 2
                // check whether unique username
                db.ExecuteCommand($"exec pro_CheckUniqueUser {username}");  // if there are exist user , throw an sql exception
                //
                // in case of unique username
                string funcName = "func_auto_id_passenger";
                passengerId = BSMain.RunFunc(db, funcName);
                if (!string.IsNullOrEmpty(passengerId))
                {
                    db.pro_AddPassenger(passengerId, name, phone);
                    db.pro_AddPassengerAccount(passengerId, username, password); // add passenger account and assign privilege
                    errMsg = "Create new user successfully!. No error";
                }
                else
                {
                    errMsg = "Can't get new passengerId.";
                    return false;
                }
            }
            catch (SqlException err)
            {
                errMsg = err.Message;
                MessageBox.Show(err.Message.ToString());
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
            return true;
        }
        public bool ChangeUserPassword(string username, string newPassword)
        {
            bool res = true;
            //
            try
            {
                BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext(StaticEnv.GetDefaultEFConnectionString());
                if (UserData.IsPassenger)
                {
                    //var curUser = db.PASSENGERACCOUNTs.Where(d => d.username == username).FirstOrDefault();
                    ////
                    //if (curUser == null)
                    //{
                    //    res = false;
                    //    return res;
                    //}
                    ////
                    //curUser.password = newPassword;
                    db.pro_ChangePassengerPassword(username, newPassword);
                }
                else
                {
                    //var curUser = db.SYSTEMACCOUNTs.Where(d => d.username == username).FirstOrDefault();
                    //if (curUser == null)
                    //{
                    //    res = false;
                    //    return res;
                    //}
                    //curUser.pass = newPassword;
                    db.pro_ChangeSystemPassword(username, newPassword);
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            return res;
        }
    }
}