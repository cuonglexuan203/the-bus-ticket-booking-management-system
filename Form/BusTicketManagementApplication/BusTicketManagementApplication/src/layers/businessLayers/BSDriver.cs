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
        public List<DRIVER> GetAllDrivers()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.DRIVERs.ToList();
            return res;
        }


        public List<DRIVER> SearchDriver(string input, int tag)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.DRIVERs.ToList();
            if (!string.IsNullOrEmpty(input))
            {
                if (tag == 0)
                {
                    res = res.Where(d => d.id_driver.Contains(input.Trim())).ToList();
                }
                else if (tag == 1)
                {
                    res = res.Where(d => d.lisence_level.Contains(input.Trim())).ToList();
                }
            }
            return res.ToList();
        }
    }
}
