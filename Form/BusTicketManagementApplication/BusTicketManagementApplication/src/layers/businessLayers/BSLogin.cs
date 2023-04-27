using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSLogin
    {
        public V_USERINFOR GetUser(string passengerId)
        {
            BusManagementEntities db = new BusManagementEntities();
            return db.V_USERINFOR.Where(d => d.id_passenger == passengerId).FirstOrDefault();
        }
        public V_EMPLOYEEINFOR GetEmployee(string systemId)
        {
            return new BusManagementEntities().V_EMPLOYEEINFOR.Where(d => d.Employees_ID == systemId).FirstOrDefault();
        }
        public bool IsAdmin(string employeeId)
        {
            BusManagementEntities db = new BusManagementEntities();
            return db.V_EMPLOYEEINFOR.Count(d => d.Employees_ID == employeeId && d.Position == "administrator") > 0;
        }
        public bool ValidateUser(string username, string password,ref string passengerId, ref string employeeId, ref string errMsg)
        {
            try
            {
                BusManagementEntities db = new BusManagementEntities();
                // init errMsg
                errMsg = "Login successfully! No error.";
                passengerId = null;
                employeeId = null;
                var curPassenger = db.PASSENGERACCOUNTs.Where(d => d.username == username && d.password == password);
                if (curPassenger != null && curPassenger.Count() > 0)
                {
                    passengerId = curPassenger.FirstOrDefault().id_passenger;
                    return true;
                }
                //
                var curEmployee = db.SYSTEMACCOUNTs.Where(d => d.username == username && d.pass == password);
                if (curEmployee != null && curEmployee.Count() > 0)
                {
                    employeeId = db.EMPLOYEEs.Where(d => d.id_account == curEmployee.FirstOrDefault().id_account).FirstOrDefault().id_employee;
                    return true;
                }
                errMsg = "Username or Password is incorrect!";
                passengerId = string.Empty;
            }
            catch(SqlException err)
            {
                errMsg = err.Message;
                //MessageBox.Show(errMsg);
                return false;
            }
            return false;
        }
        public bool CreateNewUser(string username, string password,string name, string phone,ref string passengerId, ref string errMsg)
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
                BusManagementEntities db = new BusManagementEntities();
                //
                bool uniqueUser = db.PASSENGERACCOUNTs.Count(d => d.username == username) == 0;
                if(!uniqueUser)
                {
                    errMsg = "Username has exist in the system!";
                    return false;
                }
                //
                string funcName = "func_auto_id_passenger";
                passengerId =  BSMain.RunFunc(funcName);
                if (!string.IsNullOrEmpty(passengerId))
                {
                    db.pro_AddPassenger(passengerId, name, phone);
                    db.pro_AddPassengerAccount(passengerId, username, password); // add passenger account and assign privilege
                    errMsg = "Create new user successfully!. No error";
                }
                else
                {
                    errMsg = "Can't get new passengerId";
                }
            }
            catch (SqlException err)
            {
                errMsg = err.Message;
                MessageBox.Show(errMsg);
                return false;

            }
            return true;
        }
        public bool ChangeUserPassword(string username, string newPassword)
        {
            bool res = true;
            //
            BusManagementEntities db = new BusManagementEntities();
            var curUser = db.PASSENGERACCOUNTs.Where(d => d.username == username).FirstOrDefault();
            //
            if(curUser == null)
            {
                res = false;
                return res;
            }
            //
            curUser.password = newPassword;
            db.SaveChanges();
            return res;
        }
    }
}
