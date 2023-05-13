using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSTrip
    {
        //
        public List<DataRowView> GetAllTrips(DateTime dateTime)
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_TRIPINFOR.ToList();
            return res;
        }

        public List<DataRowView> SearchAvailableTrips(string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_AVAILABLETRIP.Where(d => DateTime.Parse(d["Departure_time"].ToString().Trim()) > dateTime);
            if (src != "All")
            {
                res = res.Where(d => d["Start_point"].ToString().Trim() == src);
            }
            if (des != "All")
            {
                res = res.Where(d => d["End_point"].ToString().Trim() == des);
            }
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d["Trip_ID"].ToString().Trim().Contains(input.Trim()));
            }
            return res.ToList();
        }

        public List<DataRowView> SearchTrips(string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_TRIPINFOR.Where(d => DateTime.Parse(d["Departure_time"].ToString().Trim()) > dateTime);
            if (src != "All")
            {
                res = res.Where(d => d["Start_point"].ToString().Trim() == src);
            }
            if (des != "All")
            {
                res = res.Where(d => d["End_point"].ToString().Trim() == des);
            }
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d["Trip_ID"].ToString().Trim().Contains(input.Trim()));
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
