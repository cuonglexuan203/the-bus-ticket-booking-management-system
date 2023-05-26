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

            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.V_DRIVERINFORs.ToList();
            return res;
        }


        public List<V_DRIVERINFOR> SearchDriver(string input, int tag)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();

            var res = db.V_DRIVERINFORs.ToList();
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
