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
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.V_AVAILABLETRIPs.Where(d => d.Trip_ID == id).FirstOrDefault();
            return res;
        }
        public string GetRouteId(string idTrip)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = db.TRIPs.Where(d => d.id_trip == idTrip).Select(d => d.id_bus_route).FirstOrDefault();
            return res;
        }

        public List<string> GetAvailableSeat(string idTrip, int type) // type 0: seat, 1: sleeper
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string funcName = "func_GetAvailabelSeat";
            List<string> ticketList = BSMain.RunTableValuedFunc(funcName, new List<string> { idTrip, type.ToString() });
            return ticketList;
        }
        public TICKET GetTicket(string idTrip, bool type, string seatNumber)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            var res = (from entry in db.TICKETs
                       where entry.id_trip == idTrip && entry.type == type && entry.seat_number == seatNumber
                       select entry).FirstOrDefault();
            return res;
        }
        public void AddPassenger(string name, string phone)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            string idPassenger = BSMain.RunTableValuedFunc("func_AddPassenger", new List<string> { name, phone }).FirstOrDefault();

        }
        public V_BOOKEDTICKET GetBookedTicket(string ticketId)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            return db.V_BOOKEDTICKETs.Where(d => d.Ticket_ID == ticketId).FirstOrDefault();
        }
        //
        public void AddBooking(string ticketId, string passengerId, string employeeId)
        {
            BusManagementEntitiesDataContext db = new BusManagementEntitiesDataContext();
            db.pro_AddBooking(ticketId, passengerId, employeeId);
        }

    }
}