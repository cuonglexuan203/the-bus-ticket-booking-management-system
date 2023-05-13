using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSTicket
    {
        public string GetNewTicketId()
        {
            BusManagementEntities db = new BusManagementEntities();
            string funcName = "func_auto_id_ticket";
            return db.RunFunc(funcName, new List<string>());
        }
    }
}
