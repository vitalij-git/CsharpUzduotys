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
            if(workerRole.Text == "Padavejas")
            {
                WaiterMain waiterMain = new WaiterMain();
                this.Hide();
                waiterMain.Show();
            }
            else if(workerRole.Text == "Administratorius")
            {
                AdministratorMain admin= new AdministratorMain();
                this.Hide();
                admin.Show();
            }
            
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

        private void addFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            this.Hide();
            addFood.Show();
        }

        private void addDrink_Click(object sender, EventArgs e)
        {
            AddDrink addDrink = new AddDrink();
            this.Hide(); 
            addDrink.Show();
        }
    }
}
