using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSPosition
    {
        public List<string> GetPositionNames()
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.POSITIONs.Select(d => d.type).ToList();
            return res;
        }
    }
}
