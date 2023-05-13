using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSAgent
    {
        public List<DataRowView> SearchAgents(string input, string region)
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_AGENTINFOR;
            if (region != "All")
            {
                res = db.V_AGENTINFOR.Where(d => d["Region"].ToString().Trim() == region).ToList();

            }
            if(!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d["Agent_ID"].ToString().Trim().Contains(input)).ToList();
            }
            return res.ToList();
        }
    }
}
