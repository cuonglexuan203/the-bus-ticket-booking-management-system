using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.admin
{
    public partial class Statistic : Form
    {
        //
        List<string> filterYear;
        //
        public Statistic()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            
            // 
            InitData();
            InitUI();
            //
            LoadStatisticData(ConvertToInt(this.CbYearFilter.Text.Trim()));
        }   
        //
        private int ConvertToInt(string text)
        {
           return Convert.ToInt32(text);     
        }
        //
        private void InitData()
        {
            // Initialize var data   
            filterYear = new List<string>();
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                filterYear.Add(i.ToString());
            }
        }
        private void InitUI()
        {
            LoadDefaultDataOfYearFilter(this.filterYear.ToArray());
        }
        private void LoadDefaultDataOfYearFilter(string[] data)
        {
            CbYearFilter.Items.AddRange(data);
            CbYearFilter.SelectedIndex = data.Length-1;
        }
        private bool LoadStatisticData(int year )
        {
            bool res = false; 
            if ( year>= 2000 && year <= DateTime.Now.Year ) 
            {
                res = true;
                // TODO: This line of code loads data into the 'cashReserveDataSet.CashReserveStatistics' table.    
                this.cashReserveStatisticsTableAdapter.Fill(this.cashReserveDataSet.CashReserveStatistics,year);

                this.RwCashReverseStatistic.RefreshReport();
    
            }
            return res;
        }

        private void CbYearFilter_TextChanged(object sender, EventArgs e)
        {
            LoadStatisticData(ConvertToInt(this.CbYearFilter.Text));    
        }
    }
}
