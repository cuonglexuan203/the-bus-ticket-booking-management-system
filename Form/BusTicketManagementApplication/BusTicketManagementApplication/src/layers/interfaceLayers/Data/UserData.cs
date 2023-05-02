using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.Data
{
    internal class UserData
    {
        private static bool islogin = false;
        private static string username;
        private static string password;
        private static string passengerId = string.Empty;
        //
        private static bool isAdmin = false;
        private static bool isStaff = false;
        private static bool isPassenger = true;
        private static string systemId = string.Empty;
        //
        //
        private static string phone;
        private static string email;
        private static string address;
        private static bool? gender; // 0: male, 1: female
        private static string identity_number;
        private static DateTime birthday;
        //
        private static string fullName;
        //
        private static string currentSelectedTripId = string.Empty;
        //
        public static bool Islogin { get => islogin; set => islogin = value; }
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Phone { get => phone; set => phone = value; }
        public static string Email { get => email; set => email = value; }
        public static string Address { get => address; set => address = value; }
        public static bool? Gender { get => gender; set => gender = value; }
        public static string Identity_number { get => identity_number; set => identity_number = value; }
        public static DateTime Birthday { get => birthday; set => birthday = value; }
        public static string CurrentSelectedTripId { get => currentSelectedTripId; set => currentSelectedTripId = value; }
        public static string FullName { get => fullName; set => fullName = value; }
        public static bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        public static bool IsStaff { get => isStaff; set => isStaff = value; }
        public static bool IsPassenger { get => isPassenger; set => isPassenger = value; }

        /// <summary>
        /// Log out
        /// </summary>
        public static void ClearUserData()
        {
            islogin = false;
            username = string.Empty;
            password = string.Empty;
            passengerId = string.Empty;
            //
            isAdmin = false;
            isStaff = false;
            isPassenger = false;
            systemId = string.Empty;
            //
            fullName = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            address = string.Empty;
            gender = null;
            identity_number = string.Empty;
            birthday = DateTime.Now;
            //
            currentSelectedTripId = string.Empty;
        }
        public static void SetUserLoginData(string username, string password)
        {
            UserData.Username = username;
            UserData.Password = password;
        }
        public static void SetPassengerId(string passengerId)
        {
            UserData.passengerId = passengerId;
        }
        public static void SetUserData(string fullName, string phone)
        {
            UserData.FullName = fullName;
            UserData.Phone = phone;
        }
        public static string GetPassengerId()
        {
            return UserData.passengerId;
        }
        //
        public static void SetSystemId(string systemId)
        {
            UserData.systemId = systemId;
        }
        public static string GetSystemId()
        {
            return UserData.systemId;
        }
    }
}
