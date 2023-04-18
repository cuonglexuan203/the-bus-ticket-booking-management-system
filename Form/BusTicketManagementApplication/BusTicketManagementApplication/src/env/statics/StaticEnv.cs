using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.env.statics
{
    internal static class StaticEnv
    {
        public static Size AppSize { get => new Size(1200, 700); }
        public static Size DashboardSize { get => new Size(235, 700); }
        public static Size FillContentSize { get => new Size(965, 598); }
    }
}
