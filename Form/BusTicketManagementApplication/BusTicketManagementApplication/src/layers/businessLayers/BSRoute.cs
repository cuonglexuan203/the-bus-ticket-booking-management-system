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
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_ROUTEINFOR.Where(d => d.id_route == id).FirstOrDefault();
            return res;
        }

        public List<V_ROUTEINFOR> GetAllRoutes()
        {
            BusManagementEntities db = new BusManagementEntities();
           
            var res = db.V_ROUTEINFOR.ToList();
            return res;
        }
    }
}
