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

        public List<V_BUSSTATIONINFOR> GetAllStations()
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();

            var res = db.V_BUSSTATIONINFORs.ToList();
            return res;
        }
    }
}
