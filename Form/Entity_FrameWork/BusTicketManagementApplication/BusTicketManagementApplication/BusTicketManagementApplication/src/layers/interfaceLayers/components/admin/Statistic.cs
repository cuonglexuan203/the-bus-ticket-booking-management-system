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
        List<string> filterYears;
        //
        public Statistic()
        {
            InitializeComponent();
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
        private void InitData()
        {
            filterYears = new List<string>();
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                filterYears.Add(i.ToString());
            }
            //
        }
        private void InitUI()
        {
            LoadDefaultDataOfYearFilter(this.filterYears.ToArray());
        }
        private void LoadDefaultDataOfYearFilter(string[] data)
        {
            CbYearFilter.Items.AddRange(data);
            CbYearFilter.SelectedIndex = data.Length - 1;
        }
        private bool LoadStatisticData(int year)
        {
            bool res = false;
            if (year >= 2000 && year <= DateTime.Now.Year)
            {
                res = true;
                //
                this.cashReserveTableAdapter.Fill(this.cashReserveStatisticDataSet.CashReserve, year);
                this.RwCashReserveStatistic.RefreshReport();
            }
            return res;
        }

        private void CbYearFilter_TextChanged(object sender, EventArgs e)
        {
            LoadStatisticData(ConvertToInt(this.CbYearFilter.Text));
        }
    }
}