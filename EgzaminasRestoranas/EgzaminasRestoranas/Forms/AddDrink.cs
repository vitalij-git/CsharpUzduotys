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
    public partial class AddDrink : Form
    {
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        ConnectToDatabase Connection = new ConnectToDatabase();
        RestaurantMenu Menu = new RestaurantMenu();
        public AddDrink()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BackMethod();
        }

        private void addDrinkToMenu_Click(object sender, EventArgs e)
        {
            if (drinkName.Text != "" && drinkPrice.Text!= "")
            {
                AddDrinkToDatabase();
                BackMethod();
            }
            else
            {
                MessageBox.Show("Liko tuščių laukų");
            }
        }

        private void AddDrink_Load(object sender, EventArgs e)
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

        private void BackMethod()
        {
            this.Hide();
            Menu.Show();
        }

        private void AddDrinkToDatabase()
        {
            try
            {
                SqlConnection = Connection.Connection();
                double price = Convert.ToDouble(drinkPrice.Text);
                string query = "Insert into DrinkMenu(Name,Price) Values(@drinkName,@drinkPrice)";
                using (SqlCommand = new SqlCommand(query, SqlConnection))
                {
                    SqlCommand.Parameters.AddWithValue("@drinkName", drinkName.Text);
                    SqlCommand.Parameters.AddWithValue("@drinkPrice", price);
                    SqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Gerimas sekmingai pridėtas");
                SqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
