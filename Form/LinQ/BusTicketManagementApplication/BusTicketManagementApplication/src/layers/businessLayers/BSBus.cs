using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketManagementApplication.src.dbConnection;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    class BSBus
    {

        public List<BUS> GetAllBus()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.Buses.ToList();
            return res;
        }

        public List<BUS> SearchBusByID(string input, bool type)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = FilterBus(type);
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.id_bus.Contains(input)).ToList();
                return res.ToList();
            }
            return res.ToList();
        }

        public List<BUS> SearchBusByRegistrationNumber(string input, bool type)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = FilterBus(type);
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.registration_number.Contains(input)).ToList();
                return res.ToList();
            }
            return res.ToList();
        }

        public List<BUS> FilterBus(bool type)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.Buses.Where(d => d.type == type);
            return res.ToList();
        }
    }
}
