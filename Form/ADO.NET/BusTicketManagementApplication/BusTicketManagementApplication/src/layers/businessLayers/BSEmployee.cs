using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSEmployee
    {
        public List<DataRowView> SearchEmployees(string input, int tag, string position)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_EMPLOYEEINFOR.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if (tag == 0)
                {
                    res = res.Where(d => d["Employees_ID"].ToString().Trim().Contains(input.Trim())).ToList();
                }
                else if (tag == 1)
                {
                    res = res.Where(d => d["Name"].ToString().Trim().Contains(input.Trim())).ToList();
                }
            }
            //
            if (position != "All")
            {
                res = res.Where(d => d["Position"].ToString().Trim() == position).ToList();
            }
            return res.ToList();
        }
        public bool DeleteEmployee(string employeeId)
        {
            BusManagementEntities db = new BusManagementEntities();
            return Boolean.Parse(db.pro_DisableEmployee(employeeId).FirstOrDefault()["state"].ToString().Trim()) == false;
        }
    }
}
