using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    class BSBus
    {

        public List<DataRowView> GetAllBus()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.BUSes.ToList();
            return res;
        }

        public List<DataRowView> SearchBusByID(string input, bool type)
        {

            var res = FilterBus(type);
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d["id_bus"].ToString().Trim().Contains(input)).ToList();
                return res.ToList();
            }
            return res.ToList();
        }

        public List<DataRowView> SearchBusByRegistrationNumber(string input, bool type)
        {

            var res = FilterBus(type);
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d["registration_number"].ToString().Trim().Contains(input)).ToList();
                return res.ToList();
            }
            return res.ToList();
        }

        public List<DataRowView> FilterBus(bool type)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.BUSes.Where(d => Boolean.Parse(d["type"].ToString().Trim()) == type);
            return res.ToList();
        }
    }
}
