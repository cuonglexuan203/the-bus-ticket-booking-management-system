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
            BusManagementEntities db = new BusManagementEntities();
            var res = db.POSITIONs.Select(d => d["type"].ToString().Trim()).ToList();
            return res;
        }
    }
}
