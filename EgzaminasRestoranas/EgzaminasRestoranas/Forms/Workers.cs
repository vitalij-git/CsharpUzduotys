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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdministratorMain adminMaain = new AdministratorMain();
            this.Hide();
            adminMaain.Show();
        }
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
        }
    }
}
