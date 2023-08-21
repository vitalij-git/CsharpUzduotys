using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Forms
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdministratorMain administratorMain = new AdministratorMain();
            this.Hide();
            administratorMain.Show();   
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
        }

        private void totalProfit_Click(object sender, EventArgs e)
        {
            TodayTotalProfit todayTotalProfit = new TodayTotalProfit();
            this.Hide();
            todayTotalProfit.Show();
        }

        private void TodayAddedToMenu_Click(object sender, EventArgs e)
        {
            TodayAddDishAndDrinksToMenu menu =  new TodayAddDishAndDrinksToMenu();
            this.Hide();
            menu.Show();
        }

        private void waiterStatistics_Click(object sender, EventArgs e)
        {
            WaiterStatistics waiterstatistics = new WaiterStatistics();
            this.Hide();
            waiterstatistics.Show();
        }
    }
}
