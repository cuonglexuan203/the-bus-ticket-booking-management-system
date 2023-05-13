using BusTicketManagementApplication.src.layers.databaseLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BusManagementEntities : BSMain, IBusManagementEntities
    {
        public static Dictionary<string, List<string>> columnNames = new Dictionary<string, List<string>>()
        {
            {"AGENT", new List<string>{ "id_agent", "id_cash_reserve", "id_place", "address", "phone"} },
            {"AGENT_EVENT", new List<string>{ "id_agent", "id_event", } },
            {"AGENT_REFUND", new List<string>{ "id_agent", "id_refund", } },
            {"AGENT_TRIP", new List<string>{ "id_agent", "id_trip", } },
            {"BOOKING", new List<string>{ "id_booking", "id_ticket", "id_passenger", "id_employee", "booking_time", } },
            {"BUS", new List<string>{ "id_bus", "registration_number", "model", "capacity", "status", "type", } },
            {"BUSROUTE", new List<string>{ "id_route", "id_start_station", "id_end_station", "distance", } },
            {"BUSROUTE_BUSSTATION", new List<string>{ "id_bus_route", "id_bus_station", } },
            {"BUSSTATION", new List<string>{ "id_bus_station", "id_place", "address", "bus_capacity", "count_current_bus", "phone", } },
            {"CASHRESERVE", new List<string>{ "id_cash_reserve", "counter", } },
            {"DRIVER", new List<string>{ "id_driver", "lisence_level", "type", "state", } },
            {"EMPLOYEE", new List<string>{ "id_employee", "id_account", "id_agent", "name", "address", "phone_number", "identity_number", "salary", "email", "birthdate", "gender", "state", } },
            {"EMPLOYEE_POSITION", new List<string>{ "id_employee", "id_position", } },
            {"EMPLOYEE_TICKET", new List<string>{ "id_employee", "id_ticket" } },
            {"EVENT", new List<string>{ "id_event", "discount_type", "discount_percent", } },
            {"PASSENGER", new List<string>{ "id_passenger", "name", "phone_number", "address", "identity_number", "gender", "email", } },
            {"PASSENGERACCOUNT", new List<string>{ "id_passenger", "username", "password", } },
            {"PLACE", new List<string>{ "id_place", "region", } },
            {"POSITION", new List<string>{ "id_position", "type", } },
            {"REFUND", new List<string>{ "id_refund", "refund_name", "refund_percent", } },
            {"SYSTEMACCOUNT", new List<string>{ "id_account", "username", "pass", } },
            {"TICKET", new List<string>{ "id_ticket", "id_trip", "status", "fare", "type", "seat_number", } },
            {"TRIP", new List<string>{ "id_trip", "id_bus", "id_bus_route", "departure_time", "duration", "booked_seat", "status", } },
            {"TRIP_DRIVER", new List<string>{ "id_trip", "id_driver", } },
            // Views
            {"V_AGENTINFOR", new List<string>{ "Agent_ID", "Phone", "Address", "Region", "Money", } },
            {"V_AVAILABLETRIP", new List<string>{ "Trip_ID", "Registration_number_of_bus", "Start_point", "End_point", "Departure_time", "Duration", "Remain_seat", "Status", } },
            {"V_BOOKEDTICKET", new List<string>{ "Passenger_ID", "Ticket_ID", "Fare", "Type", "Seat_number", "Start_point", "End_point", "Departure_time", "Distance", "Duration", "Registration_number_of_bus", "Booking_time", } },
            {"V_BOOKINGINFOR", new List<string>{ "Booking_ID", "Passenger_ID", "Ticket_ID", "Passenger_name", "Passenger_gender", "Passenger_phone_number", "Employee_name", "Employee_gender", "Employee_phone_number", "Booking_time", } },
            {"V_BUSSTATIONINFOR", new List<string>{ "id_place", "Phone_number", "Address", "Region", } },
            {"V_DRIVERINFOR", new List<string>{ "Employees_ID", "Name", "Phone_Number", "Gender", "Lisence_Level", "Type", "State", } },
            {"V_EMPLOYEEINFOR", new List<string>{ "Employees_ID", "Name", "Phone_Number", "Address", "Email", "Identity_number", "Salary", "Birthday", "Gender", "State", "Position", } },
            {"V_ROUTEINFOR", new List<string>{ "id_route", "Start_point", "End_point", "Distance", } },
            {"V_TRIPINFOR", new List<string>{ "Trip_ID", "Registration_number_of_bus", "Start_point", "End_point", "Departure_time", "Duration", "Remain_seat", "Status", } },
            {"V_USERINFOR", new List<string>{ "id_passenger", "name", "phone_number", "username", "password", } },
        };

        public BusManagementEntities() : base()
        {
        }
        public BusManagementEntities(string connectionString) : base(connectionString)
        {
        }
        public BusManagementEntities(DBMain db) : base(db)
        {
        }
        //
        // Tables

        public List<DataRowView> EMPLOYEE_TICKETs
        {
            get => this.GetTable("EMPLOYEE_TICKET");
        }
        public List<DataRowView> PASSENGERACCOUNTs
        {
            get => this.GetTable("PASSENGERACCOUNT");
        }
        public List<DataRowView> BUSes
        {
            get => this.GetTable("BUS");

        }
        public List<DataRowView> TRIPs
        {
            get => this.GetTable("TRIP");

        }
        public List<DataRowView> PLACEs
        {
            get => this.GetTable("PLACE");

        }
        public List<DataRowView> TICKETs
        {
            get => this.GetTable("TICKET");

        }
        public List<DataRowView> BUSROUTEs
        {
            get => this.GetTable("BUSROUTE");

        }
        public List<DataRowView> BOOKINGs
        {
            get => this.GetTable("BOOKING");

        }
        public List<DataRowView> BUSSTATIONs
        {
            get => this.GetTable("BUSSTATION");

        }
        public List<DataRowView> PASSENGERs
        {
            get => this.GetTable("PASSENGER");

        }
        public List<DataRowView> AGENTs
        {
            get => this.GetTable("AGENT");

        }
        public List<DataRowView> EMPLOYEEs
        {
            get => this.GetTable("EMPLOYEE");

        }
        public List<DataRowView> POSITIONs
        {
            get => this.GetTable("POSITION");

        }
        public List<DataRowView> CASHRESERVEs
        {
            get => this.GetTable("CASHRESERVE");

        }
        public List<DataRowView> DRIVERs
        {
            get => this.GetTable("DRIVER");

        }
        public List<DataRowView> EVENTs
        {
            get => this.GetTable("EVENT");

        }
        public List<DataRowView> REFUNDs
        {
            get => this.GetTable("REFUND");

        }
        public List<DataRowView> SYSTEMACCOUNTs
        {
            get => this.GetTable("SYSTEMACCOUNT");

        }
        public List<DataRowView> TRIP_DRIVERs
        {
            get => this.GetTable("TRIP_DRIVER");

        }
        public List<DataRowView> AGENT_TRIPs
        {
            get => this.GetTable("AGENT_TRIP");

        }
        public List<DataRowView> AGENT_EVENTs
        {
            get => this.GetTable("AGENT_EVENT");

        }
        public List<DataRowView> AGENT_REFUNDs
        {
            get => this.GetTable("AGENT_REFUND");

        }
        public List<DataRowView> BUSROUTE_BUSSTATIONs
        {
            get => this.GetTable("BUSROUTE_BUSSTATION");

        }
        public List<DataRowView> EMPLOYEE_POSITIONs
        {
            get => this.GetTable("EMPLOYEE_POSITION");

        }
        //
        // Views
        public List<DataRowView> V_USERINFOR
        {
            get => this.GetTable("V_USERINFOR");

        }
        public List<DataRowView> V_BOOKEDTICKET
        {
            get => this.GetTable("V_BOOKEDTICKET");

        }
        public List<DataRowView> V_BOOKINGINFOR
        {
            get => this.GetTable("V_BOOKINGINFOR");

        }
        public List<DataRowView> V_EMPLOYEEINFOR
        {
            get => this.GetTable("V_EMPLOYEEINFOR");

        }
        public List<DataRowView> V_DRIVERINFOR
        {
            get => this.GetTable("V_DRIVERINFOR");

        }
        public List<DataRowView> V_AGENTINFOR
        {
            get => this.GetTable("V_AGENTINFOR");

        }
        public List<DataRowView> V_AVAILABLETRIP
        {
            get => this.GetTable("V_AVAILABLETRIP");

        }
        public List<DataRowView> V_ROUTEINFOR
        {
            get => this.GetTable("V_ROUTEINFOR");

        }
        public List<DataRowView> V_BUSSTATIONINFOR
        {
            get => this.GetTable("V_BUSSTATIONINFOR");

        }
        public List<DataRowView> V_TRIPINFOR
        {
            get => this.GetTable("V_TRIPINFOR");

        }



        //
        // Procedures
        public bool pro_CheckUniqueUser(string username)
        {
            string procCall = $"pro_CheckUniqueUser '{username}'";
            return this.RunProc(procCall) == 0;
        }
        public void pro_CancelTicket(string ticketId)
        {
            string procCall = $"pro_CancelTicket '{ticketId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_SetCancelTrip(string tripId)
        {
            string procCall = $"pro_SetCancelTrip '{tripId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_SetFinishTrip(string tripId)
        {
            string procCall = $"pro_SetFinishTrip '{tripId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_SetGoingTrip(string tripId)
        {
            string procCall = $"pro_SetGoingTrip '{tripId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_ChangePassengerPassword(string username, string password)
        {
            string procCall = $"pro_ChangePassengerPassword '{username}', '{password}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_ChangeSystemPassword(string username, string password)
        {
            string procCall = $"pro_ChangeSystemPassword '{username}', '{password}'";
            this.RunNonQueryProc(procCall);
        }
        public string pro_ValidateUser(string username, string password)
        {
            string procName = "pro_ValidateUser";
            return this.RunProc(procName, new List<string> { username, password });
        }
        public void pro_AddPassengerAccount(string passengerId, string username, string password)
        {
            string procCall = $"pro_AddPassengerAccount '{passengerId}', '{username}', '{password}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AddEmployeeAccount(string username, string password)
        {
            string procCall = $"pro_AddEmployeeAccount '{username}', '{password}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AssignPassengerPrivilege(string passengerId)
        {
            string procCall = $"pro_AssignPassengerPrivilege '{passengerId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AssignSystemPrivilege(string employeeId, string positionId)
        {
            string procCall = $"pro_AssignSystemPrivilege '{employeeId}', '{positionId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AddBooking(string ticketId, string passengerId, string employeeId)
        {
            string procCall = $"pro_AddBooking '{ticketId}', '{passengerId}', '{employeeId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AddDefaultBooking(string ticketId, string passengerId)
        {
            string procCall = $"pro_AddDefaultBooking '{ticketId}', '{passengerId}'";
            this.RunNonQueryProc(procCall);
        }
        public void pro_AddPassenger(string passengerId, string name, string phone)
        {
            string procCall = $"pro_AddPassenger '{passengerId}', '{name}', '{phone}'";
            this.RunNonQueryProc(procCall);
        }
        public List<DataRowView> pro_DisableEmployee(string employeeId)
        {
            string procCall = $"pro_DisableEmployee '{employeeId}'";
            return this.RunTableValuedProc(procCall);
        }

        //
        // Functions
        public string func_AutoDefaultIdEmployee()
        {
            return this.RunStringResultFunc("func_AutoDefaultIdEmployee()");
        }
        public List<DataRowView> func_GetAvailabelSeat(string tripId, int type)
        {
            string tableValuedFuncCall = $"func_GetAvailabelSeat('{tripId}', {type})";
            return this.RunTableValuedFunc(tableValuedFuncCall);
        }
        public string func_auto_id_ticket()
        {
            return this.RunStringResultFunc("func_auto_id_ticket()");
        }
        public string func_auto_id_agent()
        {
            return this.RunStringResultFunc("func_auto_id_agent()");
        }
        public string func_auto_id_employee()
        {
            return this.RunStringResultFunc("func_auto_id_employee()");
        }
        public string func_auto_id_busroute()
        {
            return this.RunStringResultFunc("func_auto_id_busroute()");
        }
        public string func_auto_id_booking()
        {
            return this.RunStringResultFunc("func_auto_id_booking()");
        }
        public string func_auto_id_busstation()
        {
            return this.RunStringResultFunc("func_auto_id_busstation()");
        }
        public string func_auto_id_passenger()
        {
            return this.RunStringResultFunc("func_auto_id_passenger()");
        }
        public string func_auto_id_bus()
        {
            return this.RunStringResultFunc("func_auto_id_bus()");
        }
        public string func_auto_id_trip()
        {
            return this.RunStringResultFunc("func_auto_id_trip()");
        }
        public string func_auto_id_position()
        {
            return this.RunStringResultFunc("func_auto_id_position()");
        }
        public string func_auto_id_account()
        {
            return this.RunStringResultFunc("func_auto_id_account()");
        }
        public string func_auto_id_package()
        {
            return this.RunStringResultFunc("func_auto_id_package()");
        }
        public string func_auto_id_event()
        {
            return this.RunStringResultFunc("func_auto_id_event()");
        }
        public string func_auto_id_refund()
        {
            return this.RunStringResultFunc("func_auto_id_refund()");
        }
        public string func_auto_id_policy()
        {
            return this.RunStringResultFunc("func_auto_id_policy()");
        }
        public string func_auto_id_privilege()
        {
            return this.RunStringResultFunc("func_auto_id_privilege()");
        }
        public string func_auto_id_cashreserve()
        {
            return this.RunStringResultFunc("func_auto_id_cashreserve()");
        }
    }
}
