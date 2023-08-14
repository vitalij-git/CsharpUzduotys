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
    public partial class RestaurantMenu : Form
    {
        public RestaurantMenu()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            WaiterMain waiterMain = new WaiterMain();
            this.Hide();
            waiterMain.Show();
        }

        private void RestaurantMenu_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
        }
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }
    }
}
