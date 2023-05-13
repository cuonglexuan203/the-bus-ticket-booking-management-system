using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
   internal class BSDriver
    {
        public List<DataRowView> GetAllDrivers()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_DRIVERINFOR.ToList();
            return res;
        }


        public List<DataRowView> SearchDriver(string input, int tag)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.V_DRIVERINFOR.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if (tag == 0)
                {
                    res = res.Where(d => d["Employees_ID"].ToString().Trim().Contains(input.Trim())).ToList();
                }
                else if (tag == 1)
                {
                    res = res.Where(d => d["Lisence_Level"].ToString().Trim().Contains(input.Trim())).ToList();
                }
            }
            return res;
        }
    }
}
