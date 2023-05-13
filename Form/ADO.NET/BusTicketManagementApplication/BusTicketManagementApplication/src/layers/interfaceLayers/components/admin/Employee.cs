using BusTicketManagementApplication.src.layers.businessLayers;
using BusTicketManagementApplication.src.layers.interfaceLayers.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    public partial class Employee : Form
    {
        private string searchInput = string.Empty;
        public Employee()
        {
            InitializeComponent();
        }
       

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadDefaultFilterItems();

        }
        private void LoadDefaultFilterItems()
        {
            string[] items = "ID Name".Split(' ');
            this.CbField.Items.AddRange(items);
            this.CbField.SelectedIndex = 0;
            //
            string[] positionItems = new BSPosition().GetPositionNames().ToArray();
            this.CbPosition.Items.Add("All");
            this.CbPosition.Items.AddRange(positionItems);
            this.CbPosition.SelectedIndex = 0;

        }
        private void DgvMainData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.LbSelectedId.Text = this.DgvMainData?.CurrentRow?.Cells[0]?.Value.ToString();
            this.LbSelectedName.Text = this.DgvMainData?.CurrentRow?.Cells[1]?.Value.ToString();
        }

        private void TbSearch_Leave(object sender, EventArgs e)
        {
            this.searchInput = this.TbSearch.Text.Trim();
        }
        private void FilterEmployees()
        {
            BSEmployee bsemployee = new BSEmployee();
            int tag = this.CbField.SelectedIndex;
            string position = this.CbPosition.Text.Trim();
            this.DgvMainData.DataSource = bsemployee.SearchEmployees(this.searchInput.Trim(), tag, position);
        }
        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void CbField_TextChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void CbPosition_TextChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchInput = this.TbSearch.Text;
                FilterEmployees();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.LbSelectedId.Text.Trim()))
            {
                MessageBox.Show("Please select the employee to delete");
                return;
            }
            try
            {
                BSEmployee bsemployee = new BSEmployee();
                string deleteEmployeeId = this.LbSelectedId.Text.Trim();
                if (deleteEmployeeId == UserData.GetSystemId())
                {
                    MessageBox.Show("Can not disable the current employee!");
                    return;
                }
                bool res = bsemployee.DeleteEmployee(deleteEmployeeId);
                //
                if (!res)
                {
                    MessageBox.Show("Can't delete the employee!");
                }
                else
                {
                    MessageBox.Show("The employee has been disabled!");
                    FilterEmployees();
                }
            }
            catch (SqlException sqlerr)
            {
                MessageBox.Show(sqlerr.Message);
            }
        }
    }
}
