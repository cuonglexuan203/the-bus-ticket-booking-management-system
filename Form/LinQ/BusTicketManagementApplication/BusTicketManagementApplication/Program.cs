using BusTicketManagementApplication.src.layers.interfaceLayers.components.booking;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.login;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.Profile;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.setting;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.trip;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.aboutUs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.staff;

namespace BusTicketManagementApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }
    }
}
