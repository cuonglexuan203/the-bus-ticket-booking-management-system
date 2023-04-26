using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
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
        public bool ValidateUser(string username, string password,ref string passengerId, ref string errMsg)
        {
            BusManagementEntities db = new BusManagementEntities();
            var curUser = db.PASSENGERACCOUNTs.Where(d => d.username == username && d.username.Length == username.Length
            && d.password == password && d.password.Length == password.Length);
            if (curUser != null && curUser.Count() > 0)
            {
                errMsg = "Login successfully! No error.";
                passengerId = curUser.FirstOrDefault().id_passenger;
                return true;
            }
            errMsg = "Username or Password is incorrect!";
            passengerId = string.Empty;
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
                    db.pro_AddPassengerAccount(passengerId, username, password);
                    db.pro_AssignPassengerPrivilege(passengerId);
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
