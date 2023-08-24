using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EgzaminasRestoranas.Forms
{
    public partial class RestaurantMenu : Form
    {
        private SqlDishMenuRepository SqlDishMenuRepository = new SqlDishMenuRepository();
        private SqlDrinkMenuRepository SqlDrinkMenuRepository = new SqlDrinkMenuRepository();
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

        private void PrintToDishConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            dishTextBox.SelectionFont = customFont;
            dishTextBox.SelectionColor = Color.Black;
            dishPanel.Size = new Size(dishPanel.Size.Width, dishTextBox.Height);
            dishTextBox.AppendText(message + Environment.NewLine);
        }

        private void PrintToDrinkConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            drinkTextBox.SelectionFont = customFont;
            drinkTextBox.SelectionColor = Color.Black;
            drinkPanel.Size = new Size(drinkPanel.Size.Width, drinkTextBox.Height);
            drinkTextBox.AppendText(message + Environment.NewLine);
        }
        private void RestaurantMenu_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            DishMenuOutput();
            DrinkMenuOutput();
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

        private void DishMenuOutput()
        {
            var dishDictionary = SqlDishMenuRepository.GetAll();

            foreach(var dish in dishDictionary) 
            {
                foreach(var dishList in dish.Value)
                {
                    PrintToDishConsole($"{dishList.Name}........................{dishList.Price}€");
                    var dishBox = new DishComboBoxItem()
                    {
                        Name = dishList.Name,
                        Price = dishList.Price,
                        Id = dishList.Id
                        
                    };
                    dishComboBox.Items.Add(dishBox);
                }
                if(dishComboBox.Items.Count > 0)
                {
                    dishComboBox.SelectedIndex = 0;
                }
            }
        }

        private void DrinkMenuOutput()
        {
            var drinkDictionary = SqlDrinkMenuRepository.GetAll();
            foreach (var drinks in drinkDictionary)
            {
                foreach( var drink in drinks.Value)
                {
                    PrintToDrinkConsole($"{drink.Name}.....................{drink.Price}€");
                    var drinkBOx = new DrinkComboBoxItem()
                    {
                        Name = drink.Name,
                        Price = drink.Price,
                        Id= drink.Id

                    };
                    drinkComboBox.Items.Add(drinkBOx);
                }
                if (drinkComboBox.Items.Count > 0)
                {
                    drinkComboBox.SelectedIndex = 0;
                }
            }

        }

        private void dishDelete_Click(object sender, EventArgs e)
        {
            DishComboBoxItem selectedDish = (DishComboBoxItem)dishComboBox.SelectedItem;
            int dishId = selectedDish.Id;   
            SqlDishMenuRepository.Delete(dishId);
        }

        private void drinkDelete_Click(object sender, EventArgs e)
        {
            DrinkComboBoxItem selectedDrink = (DrinkComboBoxItem)drinkComboBox.SelectedItem;
            int drinkId = selectedDrink.Id;
            SqlDrinkMenuRepository.Delete(drinkId);
        }

        private void dishUpdate_Click(object sender, EventArgs e)
        {
            DishComboBoxItem selectedDish = (DishComboBoxItem)dishComboBox.SelectedItem;
            int dishId = selectedDish.Id;
            this.Hide();
            DishUpdate dishUpdate = new DishUpdate(dishId);
            dishUpdate.Show();

        }

        private void drinkUpdate_Click(object sender, EventArgs e)
        {
            DrinkComboBoxItem selectedDrink = (DrinkComboBoxItem)drinkComboBox.SelectedItem;
            int drinkId = selectedDrink.Id;
            this.Hide();
            DrinkUpdate drinkUpdate = new DrinkUpdate(drinkId);
            drinkUpdate.Show();
        }
    }
}
