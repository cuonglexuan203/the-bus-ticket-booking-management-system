using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSBooked
    {
        //
        public List<DataRowView> GetAllBookedTickets()
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_BOOKEDTICKET.ToList();
            return res;
        }

        public List<DataRowView> SearchBookedTickets(string passengerId,string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_BOOKEDTICKET.Where(d => DateTime.Parse(d["Departure_time"].ToString().Trim()) > dateTime && d["Passenger_ID"].ToString().Trim() == passengerId);
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
                res = res.Where(d => d["Ticket_ID"].ToString().Trim().Contains(input.Trim()));
            }
            return res.ToList();
        }
    }
}
