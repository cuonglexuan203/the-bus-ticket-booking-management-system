using BusTicketManagementApplication.src.dbConnection;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSEmployee
    {
        public List<V_EMPLOYEEINFOR> SearchEmployees(string input, int tag, string position)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.V_EMPLOYEEINFORs.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if (tag == 0)
                {
                    res = res.Where(d => d.Employees_ID.Contains(input.Trim())).ToList();
                }
                else if (tag == 1)
                {
                    res = res.Where(d => d.Name.Contains(input.Trim())).ToList();
                }
            }
            //
            if (position != "All")
            {
                res = res.Where(d => d.Position == position).ToList();
            }
            return res.ToList();
        }
        public bool DeleteEmployee(string employeeId)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            return db.pro_DisableEmployee(employeeId).FirstOrDefault().state == false;
        }
    }
}
