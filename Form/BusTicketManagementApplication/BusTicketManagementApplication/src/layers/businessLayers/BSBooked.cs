﻿//using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSBooked
    {
        public List<V_BOOKEDTICKET> GetAllBookedTickets()
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.V_BOOKEDTICKET.ToList();
            }
        }

        public List<V_BOOKEDTICKET> SearchBookedTickets(string passengerId, string input, string src, string des, DateTime dateTime)
        {
            using (BusManagementDataContext     db = new BusManagementDataContext())
            {
                var res = db.V_BOOKEDTICKET
                            .Where(d => d.Departure_time > dateTime && d.Passenger_ID == passengerId);

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
                    res = res.Where(d => d.Ticket_ID.Contains(input.Trim()));
                }

                return res.ToList();
            }
        }
    }
}