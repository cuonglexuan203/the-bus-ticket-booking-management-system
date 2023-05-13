using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSRoute
    {
        public DataRowView GetRoute(string id)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_ROUTEINFOR.Where(d => d["id_route"].ToString().Trim() == id).FirstOrDefault();
            return res;
        }

        public List<DataRowView> GetAllRoutes()
        {
            BusManagementEntities db = new BusManagementEntities();
           
            var res = db.V_ROUTEINFOR.ToList();
            return res;
        }
    }
}
