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
    public partial class AddFood : Form
    {
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        RestaurantMenu Menu = new RestaurantMenu();
        public AddFood()
        {
            InitializeComponent();
        }

        private void AddFood_Load(object sender, EventArgs e)
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

        private void addDish_Click(object sender, EventArgs e)
        {
                if (dishName.Text != "" && dishPrice.Text != "")
                {
                    AddDishToDatabase();
                    BackMethod();
                }
                else
                {
                    MessageBox.Show("Liko tuščių laukų");
                }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BackMethod();
        }

        private void BackMethod()
        {
            this.Hide();
            Menu.Show();
        }

        private void  AddDishToDatabase()
        {
            try
            {
                SqlConnection = Connection.Connection();
                double price = Convert.ToDouble(dishPrice.Text);
                string query = "Insert into DishMenu(Name,Price) Values(@dishName,@dishPrice)";
                using (SqlCommand = new SqlCommand(query, SqlConnection))
                {
                    SqlCommand.Parameters.AddWithValue("@dishName", dishName.Text);
                    SqlCommand.Parameters.AddWithValue("@dishPrice", price);
                    SqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Patiekalas sekmingai pridėtas");
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dishPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dishName_TextChanged(object sender, EventArgs e)
        {

        }

        private void workerRole_Click(object sender, EventArgs e)
        {

        }

        private void workerName_Click(object sender, EventArgs e)
        {

        }
    }
}
