using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    class BSBus
    {

        public List<BUS> GetAllBus()
        {

            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.BUS.ToList();
            return res;
        }

        public List<BUS> SearchBusByID(string input, bool type)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();

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
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();

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
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();

            var res = db.BUS.Where(d => d.type == type);
            return res.ToList();
        }
    }
}