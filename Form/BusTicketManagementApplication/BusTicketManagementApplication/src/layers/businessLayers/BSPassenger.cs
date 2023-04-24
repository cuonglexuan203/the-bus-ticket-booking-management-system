using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSPassenger
    {
        public string GetNewPassengerId()
        {
            BusManagementEntities db = new BusManagementEntities();
            string funcName = "func_auto_id_passenger";
            return BSMain.RunFunc(funcName);
        }
    }
}
