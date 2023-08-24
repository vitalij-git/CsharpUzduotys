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
    public partial class DrinkUpdate : Form
    {

        public DrinkUpdate(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id { get; set; }
        SqlDrinkMenuRepository SqlDrinkMenuRepository = new SqlDrinkMenuRepository();
        private void Update_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(drinkPrice.Text);
            DrinkMenu drink = new DrinkMenu(drinkTitle.Text, price);
            SqlDrinkMenuRepository.Update(drink, Id);
            BackToRestaurantMenu();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BackToRestaurantMenu();
        }
        private void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void DrinkUpdate_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetDrinkhInfo();
        }
        private void GetDrinkhInfo()
        {
            DrinkMenu drink = new DrinkMenu();
            drink = SqlDrinkMenuRepository.GetById(Id);
            if (drink != null)
            {
                drinkTitle.Text = drink.Name;
                drinkPrice.Text = drink.Price.ToString();
            }
        }

        private void BackToRestaurantMenu()
        {
            RestaurantMenu restaurantMenu = new RestaurantMenu();
            this.Hide();
            restaurantMenu.Show();
        }
    }
}
