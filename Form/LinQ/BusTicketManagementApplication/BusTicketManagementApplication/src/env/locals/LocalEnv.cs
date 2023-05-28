using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.env.locals
{
    internal static class LocalEnv
    {
        private static string emailServerName = "cuongit2003@gmail.com";
        private static string encodedEmailServerPassword = "fncevgzbeilqcyos";

        public static string EmailServerName { get => emailServerName; set => emailServerName = value; }
        public static string EncodedEmailServerPassword { get => encodedEmailServerPassword; set => encodedEmailServerPassword = value; }
    }
}
