using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSPassenger
    {
        public string GetNewPassengerId()
        {
            BusManagementEntities db = new BusManagementEntities();
            string funcName = "func_auto_id_passenger";
            return BSMain.RunFunc(funcName);
        }
        public PASSENGER GetPassenger(string passengerId)
        {
            BusManagementEntities db = new BusManagementEntities();
            return db.PASSENGERs.Where(d => d.id_passenger == passengerId).FirstOrDefault();
        }
        public bool UpdatePassenger(string passengerId, string fullname, string phone, string email, bool? gender)
        {
            bool res = true;
            BusManagementEntities db = new BusManagementEntities();
            var curPassenger = db.PASSENGERs.Where(d => d.id_passenger == passengerId).FirstOrDefault();
            if (curPassenger != null)
            {
                curPassenger.name = fullname;
                curPassenger.phone_number = phone;
                curPassenger.email = email;
                curPassenger.gender = gender;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Can not find out the passenger!");
                res = false;
            }
            return res;
        }
        public bool UpdateEmployee(string employeeId, string fullname, string phone, string email, bool? gender)
        {
            bool res = true;
            BusManagementEntities db = new BusManagementEntities();
            var curPassenger = db.EMPLOYEEs.Where(d => d.id_employee == employeeId).FirstOrDefault();
            if (curPassenger != null)
            {
                curPassenger.name = fullname;
                curPassenger.phone_number = phone;
                curPassenger.email = email;
                curPassenger.gender = gender;
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Can not find out the employee!");
                res = false;
            }
            return res;
        }
        public List<PASSENGER> SearchPassenger(string input, int tag)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.PASSENGERs.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if(tag == 0)
                {
                    res = res.Where(d => d.id_passenger.Contains(input.Trim())).ToList();
                }
                else if(tag == 1)
                {
                    res = res.Where(d => d.name.Contains(input.Trim())).ToList();
                }
            }
            return res.ToList();
        }
    }
}
