using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagementApplication.src.layers.businessLayers;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.bus
{
    public partial class Bus : Form
    {
        private App parentForm;
        //
        bool type;

        public Bus()
        {
            InitializeComponent();
        }

        public Bus(App parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        

        private void BtnSearchIcon_Click(object sender, EventArgs e)
        {

            SearchBus(this.TbSearch.Text);
        }

       

        private void Bus_Load(object sender, EventArgs e)
        {
            LoadDefault();
            LoadDefaultBusSearchItems();
        }

        private void LoadDefault()
        {
            BSBus bSBus = new BSBus();
            this.dgvMainData.DataSource = bSBus.GetAllBus();
        }
        private void LoadDefaultBusSearchItems()
        {
            string[] busTypes = "Interprovince Transit".Split(' ');
            string[] searchType = "ID of bus,Registration number".Split(',');
            cbType.Items.AddRange(busTypes);
            cbSearch.Items.AddRange(searchType);
            this.cbType.SelectedIndex = 0;
            this.cbSearch.SelectedIndex = 0;
            //
            

        }

        private void SearchBus(string SearchInput)
        {
            this.dgvMainData.Refresh();
            BSBus bSBus = new BSBus();

            if (this.cbSearch.SelectedIndex == 0)
            {


                this.dgvMainData.DataSource = bSBus.SearchBusByID(SearchInput, type);

            }
            else if (this.cbSearch.SelectedIndex == 1 )
            {
                

                this.dgvMainData.DataSource = bSBus.SearchBusByRegistrationNumber(SearchInput, type);
            }


        }
        //function
        

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (this.cbType.SelectedIndex == 0)
            {

                type = true;

            }
            else if (this.cbType.SelectedIndex == 1)
            {

                type = false;

            }
            SearchBus(this.TbSearch.Text);
        }
    }
}
