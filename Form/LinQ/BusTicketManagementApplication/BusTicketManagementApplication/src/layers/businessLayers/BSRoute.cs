using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSRoute
    {
        public V_ROUTEINFOR GetRoute(string id)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.V_ROUTEINFORs.Where(d => d.id_route == id).FirstOrDefault();
            return res;
        }

        public List<V_ROUTEINFOR> GetAllRoutes()
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();


            var res = db.V_ROUTEINFORs.ToList();
            return res;
        }
    }
}
