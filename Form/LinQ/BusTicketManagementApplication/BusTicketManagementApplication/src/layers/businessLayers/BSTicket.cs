using BusTicketManagementApplication.src.dbConnection;
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
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string funcName = "func_auto_id_ticket";
            return BSMain.RunFunc(funcName);
        }
    }
}
