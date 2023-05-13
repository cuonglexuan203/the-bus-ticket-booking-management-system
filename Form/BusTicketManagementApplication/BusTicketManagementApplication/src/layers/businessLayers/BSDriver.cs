using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketManagementApplication.src.dbConnection;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSDriver
    {
        public List<V_DRIVERINFOR> GetAllDrivers()
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.V_DRIVERINFOR.ToList();
            }
        }

        public List<V_DRIVERINFOR> SearchDriver(string input, int tag)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                var res = db.V_DRIVERINFOR.AsQueryable();

                if (!string.IsNullOrEmpty(input))
                {
                    if (tag == 0)
                    {
                        res = res.Where(d => d.Employees_ID.Contains(input.Trim()));
                    }
                    else if (tag == 1)
                    {
                        res = res.Where(d => d.Lisence_Level.Contains(input.Trim()));
                    }
                }

                return res.ToList();
            }
        }
    }
}





