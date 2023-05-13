using BusTicketManagementApplication.src.dbConnection;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSBooking
    {
        public V_AVAILABLETRIP GetTrip(string id)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.V_AVAILABLETRIP.FirstOrDefault(d => d.Trip_ID == id);
            }
        }

        public string GetRouteId(string idTrip)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.TRIPs.Where(d => d.id_trip == idTrip).Select(d => d.id_bus_route).FirstOrDefault();
            }
        }

        public TICKET GetTicket(string idTrip, bool type, string seatNumber)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.TICKETs.FirstOrDefault(entry => entry.id_trip == idTrip && entry.type == type && entry.seat_number == seatNumber);
            }
        }

        public void AddPassenger(string name, string phone)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                string idPassenger = db.func_AddPassenger(name, phone).FirstOrDefault();
            }
        }

        public V_BOOKEDTICKET GetBookedTicket(string ticketId)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                return db.V_BOOKEDTICKET.FirstOrDefault(d => d.Ticket_ID == ticketId);
            }
        }

        public void AddBooking(string ticketId, string passengerId, string employeeId)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                db.pro_AddBooking(ticketId, passengerId, employeeId);
            }
        }
    }
}