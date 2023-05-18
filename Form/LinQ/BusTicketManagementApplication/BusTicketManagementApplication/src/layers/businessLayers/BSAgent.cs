using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSAgent
    {
        public List<V_AGENTINFOR> SearchAgents(string input, string region)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.V_AGENTINFORs.ToList();
            if (region != "All")
            {
                res = db.V_AGENTINFORs.Where(d => d.Region == region).ToList();

            }
            if(!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.Agent_ID.Contains(input)).ToList();
            }
            return res.ToList();
        }
    }
}
