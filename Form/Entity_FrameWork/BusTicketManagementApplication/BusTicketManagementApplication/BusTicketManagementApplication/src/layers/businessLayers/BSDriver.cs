using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketManagementApplication.src.dbConnection;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
   internal class BSDriver
    {
        public List<V_DRIVERINFOR> GetAllDrivers()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_DRIVERINFOR.ToList();
            return res;
        }


        public List<V_DRIVERINFOR> SearchDriver(string input, int tag)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.V_DRIVERINFOR.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if (tag == 0)
                {
                    res = res.Where(d => d.Employees_ID.Contains(input.Trim())).ToList();
                }
                else if (tag == 1)
                {
                    res = res.Where(d => d.Lisence_Level.Contains(input.Trim())).ToList();
                }
            }
            return res;
        }
    }
}
