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
    internal class BSTrip
    {
        private readonly BusManagementEntitiesDataContext _db;

        public BSTrip()
        {
            _db = new BusManagementEntitiesDataContext();
        }

        public List<V_TRIPINFOR> GetAllTrips(DateTime dateTime)
        {
            var trips = _db.V_TRIPINFORs.ToList();
            return trips;
        }

        public List<V_AVAILABLETRIP> SearchAvailableTrips(string input, string src, string des, DateTime dateTime)
        {
            var trips = _db.V_AVAILABLETRIPs.Where(d => d.Departure_time > dateTime);

            if (src != "All")
            {
                trips = trips.Where(d => d.Start_point == src);
            }

            if (des != "All")
            {
                trips = trips.Where(d => d.End_point == des);
            }

            if (!string.IsNullOrEmpty(input))
            {
                trips = trips.Where(d => d.Trip_ID.Contains(input.Trim()));
            }

            return trips.ToList();
        }

        public List<V_TRIPINFOR> SearchTrips(string input, string src, string des, DateTime dateTime)
        {
            var trips = _db.V_TRIPINFORs.Where(d => d.Departure_time > dateTime);

            if (src != "All")
            {
                trips = trips.Where(d => d.Start_point == src);
            }

            if (des != "All")
            {
                trips = trips.Where(d => d.End_point == des);
            }

            if (!string.IsNullOrEmpty(input))
            {
                trips = trips.Where(d => d.Trip_ID.Contains(input.Trim()));
            }

            return trips.ToList();
        }

        public void SetCancelTrip(string tripId)
        {
            _db.pro_SetCancelTrip(tripId);
        }

        public void SetFinish(string tripId)
        {
            _db.pro_SetFinishTrip(tripId);
        }

        public void SetGoing(string tripId)
        {
            _db.pro_SetGoingTrip(tripId);
        }
    }
}
