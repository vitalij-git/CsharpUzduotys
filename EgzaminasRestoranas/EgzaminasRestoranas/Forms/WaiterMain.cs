using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Forms
{
    public partial class WaiterMain : Form
    {
       
        public WaiterMain()
        {
            InitializeComponent();
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sėkmingai atsijungėte");
            this.Hide();
            WorkerLogin workerLogin = new WorkerLogin();
            workerLogin.Show();
        }

        private void WaiterMain_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            this.Hide();
            tables.Show();
        }
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void ShowMenu_Click(object sender, EventArgs e)
        {
            RestaurantMenu menu = new RestaurantMenu();
            this.Hide();
            menu.Show();
        }
    }
}
