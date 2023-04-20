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
        //
        private static string phone;
        private static string email;
        private static string address;
        private static bool gender; // 0: male, 1: female
        private static string identity_number;
        private static DateTime birthday;
        //
        private static string firstname;
        private static string lastname;
        //
        private static string currentSelectedTripId = string.Empty;
        //
        public static bool Islogin { get => islogin; set => islogin = value; }
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Phone { get => phone; set => phone = value; }
        public static string Email { get => email; set => email = value; }
        public static string Address { get => address; set => address = value; }
        public static bool Gender { get => gender; set => gender = value; }
        public static string Identity_number { get => identity_number; set => identity_number = value; }
        public static DateTime Birthday { get => birthday; set => birthday = value; }
        public static string Firstname { get => firstname; set => firstname = value; }
        public static string Lastname { get => lastname; set => lastname = value; }
        public static string CurrentSelectedTripId { get => currentSelectedTripId; set => currentSelectedTripId = value; }
        //
        public static void ClearUserData()
        {
            islogin = false;
            username = string.Empty;
            password = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            address = string.Empty;
            gender = false;
            identity_number = string.Empty;
            birthday = DateTime.Now;
            firstname = string.Empty;
            lastname = string.Empty;
            currentSelectedTripId = string.Empty;
        }
        public static void SetUserLoginData(string username, string password)
        {
            UserData.username = username;
            UserData.password = password;
        }
    }
}
