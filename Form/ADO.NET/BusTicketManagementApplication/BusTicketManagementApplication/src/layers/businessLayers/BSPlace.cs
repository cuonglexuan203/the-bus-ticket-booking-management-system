using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSPlace
    {
        public List<string> GetPlaceNames()
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Select(d => d["region"].ToString().Trim()).ToList();
            return res;
        }
        public string GetPlaceId(string placeName)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Where(d => d["region"].ToString().Trim() == placeName).Select(d => d["id_place"].ToString().Trim()).FirstOrDefault();
            return res;
        }
        public string GetPlaceName(string id)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Where(d => d["id_place"].ToString().Trim() == id).Select(d => d["region"].ToString().Trim()).FirstOrDefault();
            return res;
        }
    }
}
