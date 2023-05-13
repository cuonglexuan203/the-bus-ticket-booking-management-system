using BusTicketManagementApplication.src.dbConnection;
using BusTicketManagementApplication.src.layers.interfaceLayers.components.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusTicketManagementApplication.src.layers.businessLayers
{
    internal class BSEmployee
    {
        public List<V_EMPLOYEEINFOR> SearchEmployees(string input, int tag, string position)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                var query = db.V_EMPLOYEEINFOR.AsQueryable();

                if (!string.IsNullOrEmpty(input))
                {
                    if (tag == 0)
                    {
                        query = query.Where(d => d.Employees_ID.Contains(input.Trim()));
                    }
                    else if (tag == 1)
                    {
                        query = query.Where(d => d.Name.Contains(input.Trim()));
                    }
                }

                if (position != "All")
                {
                    query = query.Where(d => d.Position == position);
                }

                return query.ToList();
            }
        }

        public bool DeleteEmployee(string employeeId)
        {
            using (BusManagementEntities db = new BusManagementEntities())
            {
                var result = db.pro_DisableEmployee(employeeId).FirstOrDefault();
                return result?.state == false;
            }
        }
    }