using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal interface IBusManagementEntities
    {
        //
        // Procedures
        bool pro_CheckUniqueUser(string username);
        void pro_CancelTicket(string ticketId);
        void pro_SetCancelTrip(string tripId);
        void pro_SetFinishTrip(string tripId);
        void pro_SetGoingTrip(string tripId);
        void pro_ChangePassengerPassword(string username, string password);
        void pro_ChangeSystemPassword(string username, string password);
        string pro_ValidateUser(string username, string password);
        void pro_AddPassengerAccount(string passengerId, string username, string password);
        void pro_AddEmployeeAccount(string username, string password);
        void pro_AssignPassengerPrivilege(string passengerId);
        void pro_AssignSystemPrivilege(string employeeId, string positionId);
        void pro_AddBooking(string ticketId, string passengerId, string employeeId);
        void pro_AddDefaultBooking(string ticketId, string passengerId);
        void pro_AddPassenger(string passengerId, string name, string phone);
        List<DataRowView> pro_DisableEmployee(string employeeId);
        //
        // Functions
        string func_AutoDefaultIdEmployee();
        List<DataRowView> func_GetAvailabelSeat(string tripId, int type);
        string func_auto_id_ticket();
        string func_auto_id_agent();
        string func_auto_id_employee();
        string func_auto_id_busroute();
        string func_auto_id_booking();
        string func_auto_id_busstation();
        string func_auto_id_passenger();
        string func_auto_id_bus();
        string func_auto_id_trip();
        string func_auto_id_position();
        string func_auto_id_account();
        string func_auto_id_package();
        string func_auto_id_event();
        string func_auto_id_refund();
        string func_auto_id_policy();
        string func_auto_id_privilege();
        string func_auto_id_cashreserve();

    }
}
