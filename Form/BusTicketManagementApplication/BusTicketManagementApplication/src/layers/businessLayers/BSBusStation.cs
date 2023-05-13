using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketManagementApplication.src.dbConnection;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSBusStation
    {

        public List<BUS> GetAllStations()
        {
            using (BusManagementEnities db = new BusManagementEnities)
            {
                return db.GetAllStations.ToList();
            }
        }
    }
}
