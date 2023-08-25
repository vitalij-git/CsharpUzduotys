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
    public partial class TodayAddDishAndDrinksToMenu : Form
    {
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        public TodayAddDishAndDrinksToMenu()
        {
            InitializeComponent();
        }

        private void TodayAddDishAndDrinksToMenu_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetTodayDish();
            GetTodayDrinks();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            this.Hide();
            statistics.Show();
        }

        private void PrintToConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            TextBox.SelectionFont = customFont;
            TextBox.SelectionColor = Color.Black;
            panel.Size = new Size(panel.Size.Width, TextBox.Height);
            TextBox.AppendText(message + Environment.NewLine);
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void GetTodayDish()
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from DishMenu Where cast(AddDate as Date) = cast(getdate() as Date)";
                SqlCommand = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string price = reader["Price"].ToString();
                   
                    PrintToConsole($"{name}.........................................{price}");
                }
               Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetTodayDrinks()
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from DrinkMenu Where cast(AddDate as Date) = cast(getdate() as Date)";
                SqlCommand = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string price = reader["Price"].ToString();

                    PrintToConsole($"{name}.........................................{price}");
                }
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
