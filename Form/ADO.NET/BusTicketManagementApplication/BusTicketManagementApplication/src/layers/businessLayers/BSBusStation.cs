using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSBusStation
    {

        public List<DataRowView> GetAllStations()
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.V_BUSSTATIONINFOR.ToList();
            return res;
        }
    }
}
