using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal interface IBSMain
    {
        List<DataRowView> GetTable(string tableName);
    }
}
