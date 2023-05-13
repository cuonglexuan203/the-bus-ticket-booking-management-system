using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSPassenger
    {
        public string GetNewPassengerId()
        {
            BusManagementEntities db = new BusManagementEntities();
            string funcName = "func_auto_id_passenger";
            return db.RunFunc(funcName, new List<string> ());
        }
        public DataRowView GetPassenger(string passengerId)
        {
            BusManagementEntities db = new BusManagementEntities();
            return db.PASSENGERs.Where(d => d["id_passenger"].ToString().Trim() == passengerId).FirstOrDefault();
        }
        public bool UpdatePassenger(string passengerId, string fullname, string phone, string email, bool? gender)
        {
            bool res = true;
            BusManagementEntities db = new BusManagementEntities();
            var curPassenger = db.PASSENGERs.Where(d => d["id_passenger"].ToString().Trim() == passengerId).FirstOrDefault();
            if (curPassenger != null)
            {
                curPassenger["name"] = fullname;
                curPassenger["phone_number"] = phone;
                curPassenger["email"] = email;
                curPassenger["gender"] = gender;
                //db.SaveChanges();
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
            var curPassenger = db.EMPLOYEEs.Where(d => d["id_employee"].ToString().Trim() == employeeId).FirstOrDefault();
            if (curPassenger != null)
            {
                curPassenger["name"] = fullname;
                curPassenger["phone_number"] = phone;
                curPassenger["email"] = email;
                curPassenger["gender"] = gender;
                //db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Can not find out the employee!");
                res = false;
            }
            return res;
        }
        public List<DataRowView> SearchPassenger(string input, int tag)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.PASSENGERs.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if(tag == 0)
                {
                    res = res.Where(d => d["id_passenger"].ToString().Trim().Contains(input.Trim())).ToList();
                }
                else if(tag == 1)
                {
                    res = res.Where(d => d["name"].ToString().Trim().Contains(input.Trim())).ToList();
                }
            }
            return res.ToList();
        }
    }
}
