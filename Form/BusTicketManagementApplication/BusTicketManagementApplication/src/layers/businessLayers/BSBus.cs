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
            using ( BusManangementEntities db = new BusManagementEntities() )
            {
                return db.Buses.ToList();
            }
        }

        public List<BUS> SearchBusByID(string input, bool type)
        {
            using ( BusManagementEntities db = new BusManagementEntities())
            {
                var query = FilterBus(db, type);

                if (!string.IsNullOrEmpty(input))
                {
                    query = query.Where(d => d.id_bus.Contains(input));
                }

                return query.ToList();
            }
        }

        public List<BUS> SearchBusByRegistrationNumber(string input, bool type)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                var query = FilterBus(db, type);

                if (!string.IsNullOrEmpty(input))
                {
                    query = query.Where(d => d.registration_number.Contains(input));
                }

                return query.ToList();
            }
        }

        private IQueryable<BUS> FilterBus(BusManagementEntities db, bool type)
        {
            return db.Buses.Where(d => d.type == type);
        }
    }
}

