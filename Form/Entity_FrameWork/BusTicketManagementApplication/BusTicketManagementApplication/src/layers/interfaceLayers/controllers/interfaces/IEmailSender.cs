using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.controllers.interfaces
{
    internal interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string body);
    }
}
