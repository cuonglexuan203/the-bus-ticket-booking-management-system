﻿using BusTicketManagementApplication.src.dbConnection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSTrip
    {
        //
        public List<V_TRIPINFOR> GetAllTrips(DateTime dateTime)
        {

            BusManagementEntities db = new BusManagementEntities();
            var res = db.V_TRIPINFOR.ToList();
            return res;
        }

        public List<V_TRIPINFOR> SearchTrips(string input, string src, string des, DateTime dateTime)
        {
            BusManagementEntities db = new BusManagementEntities();
            
            var res = db.V_TRIPINFOR.Where(d => d.Departure_time > dateTime);
            if (src != "All")
            {
                res = res.Where(d => d.Start_point == src);
            }
            if (des != "All")
            {
                res = res.Where(d => d.End_point == des);
            }
            if (!string.IsNullOrEmpty(input))
            {
                res = res.Where(d => d.Trip_ID.Contains(input.Trim()));
            }
            return res.ToList();
        }

        public List<string> GetPlaceNames()
        {
            BusManagementEntities db = new BusManagementEntities();
            var res = db.PLACEs.Select(d => d.region).ToList();
            return res;
        }

    }
}
