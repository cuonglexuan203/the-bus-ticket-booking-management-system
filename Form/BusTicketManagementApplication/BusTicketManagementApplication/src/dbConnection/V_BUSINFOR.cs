using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.dbConnection
{
    class V_BUSINFOR
    {
        public string Id_bus { get; set; }
        public string Registration_Number { get; set; }
        public string Model { get; set; }
        public Nullable<byte> Capacity { get; set; }
        public string Status { get; set; }
        public bool Type { get; set; }
        public virtual ICollection<TRIP> TRIPs { get; set; }
    }
}
