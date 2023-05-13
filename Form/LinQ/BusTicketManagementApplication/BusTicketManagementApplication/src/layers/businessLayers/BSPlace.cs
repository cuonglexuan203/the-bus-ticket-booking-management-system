using BusTicketManagementApplication.src.dbConnection;
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
            var res = db.PLACEs.Select(d => d.region).ToList();
            return res;
        }
        public string GetPlaceId(string placeName)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Where(d => d.region == placeName).Select(d => d.id_place).FirstOrDefault();
            return res;
        }
        public string GetPlaceName(string id)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Where(d => d.id_place == id).Select(d => d.region).FirstOrDefault();
            return res;
        }
    }
}
