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
    public partial class DishUpdate : Form
    {
        
        
        public DishUpdate(int id)
        {
            InitializeComponent();
            Id = id;
        }
        public int Id { get; set; }
        private SqlDishMenuRepository SqlDishMenuRepository = new SqlDishMenuRepository();
        private void Back_Click(object sender, EventArgs e)
        {
            BackToRestaurantMenu();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(dishPrice.Text);
            DishMenu dish =new DishMenu(dishTitle.Text,price);
            SqlDishMenuRepository.Update(dish, Id);
            BackToRestaurantMenu();
        }

        private void DishUpdate_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetDishInfo();

        }
        private void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void GetDishInfo()
        {
            DishMenu dish = new DishMenu();
            dish = SqlDishMenuRepository.GetById(Id);
            if (dish != null)
            {
                dishTitle.Text = dish.Name;
                dishPrice.Text = dish.Price.ToString();
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
