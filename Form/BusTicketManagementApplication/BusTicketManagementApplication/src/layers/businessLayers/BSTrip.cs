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
        //
        public List<V_TRIPINFOR> GetAllTrips(DateTime dateTime)
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_TRIPINFOR.ToList();
            return res;
        }

        public List<V_AVAILABLETRIP> SearchAvailableTrips(string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();
            
            var res = db.V_AVAILABLETRIP.Where(d => d.Departure_time > dateTime);
            if (src != "All")
            {
                res = res.Where(d => d.Start_point == src);
            }
            if (des != "All")
            {
                res = res.Where(d => d.End_point == des);
            }
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.Trip_ID.Contains(input.Trim()));
            }
            return res.ToList();
        }

        public List<V_TRIPINFOR> SearchTrips(string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();

            var res = db.V_TRIPINFOR.Where(d => d.Departure_time > dateTime);
            if (src != "All")
            {
                res = res.Where(d => d.Start_point == src);
            }
            if (des != "All")
            {
                res = res.Where(d => d.End_point == des);
            }
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.Trip_ID.Contains(input.Trim()));
            }
            return res.ToList();
        }
        //
        public void SetCancelTrip(string tripId)
        {
            BusManagementEntities db = new BusManagementEntities();
            db.pro_SetCancelTrip(tripId);
        }
        public void SetFinish(string tripId)
        {
            BusManagementEntities db = new BusManagementEntities();
            db.pro_SetFinishTrip(tripId);
        }
        public void SetGoing(string tripId)
        {
            BusManagementEntities db = new BusManagementEntities();
            db.pro_SetGoingTrip(tripId);
        }

    }
}
