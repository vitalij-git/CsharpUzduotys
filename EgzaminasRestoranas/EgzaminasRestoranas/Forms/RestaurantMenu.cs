using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Forms
{
    public partial class RestaurantMenu : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
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
            using (SqlConnection = ConnectionToDatabase.Connection())
            {
                string query = $"SELECT * FROM DishMenu ";

                SqlConnection.Open();
                SqlCommand command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        PrintToDishConsole($"{name}........................{price}€");
                    }
                }
                SqlConnection.Close();
            }
        }

        private void DrinkMenuOutput()
        {
            using (SqlConnection = ConnectionToDatabase.Connection())
            {
                string query = $"SELECT * FROM DrinkMenu ";

                SqlConnection.Open();
                SqlCommand command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        PrintToDrinkConsole($"{name}........................{price}€");
                    }
                }
                SqlConnection.Close();
            }
        }
    }
}
