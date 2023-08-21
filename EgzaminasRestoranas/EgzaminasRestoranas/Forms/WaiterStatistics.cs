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

namespace EgzaminasRestoranas.Forms
{
    public partial class WaiterStatistics : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        public WaiterStatistics()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            this.Hide();
            statistics.Show();
        }

        private void WaiterStatistics_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetWorkerNameFromDatabase();
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void PrintToConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            TextBox.SelectionFont = customFont;
            TextBox.SelectionColor = Color.Black;
            panel.Size = new Size(panel.Size.Width, TextBox.Height);
            TextBox.AppendText(message + Environment.NewLine);
        }

        private void GetTodayTotalProfit()
        {
            double totalProfitSum = 0;
            int totalFinishedOrders = 0;
            string fullName="";
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                string query = $"Select * from RestaurantReceipt Where WaiterName = '{chosedWorker.Text}'";
                SqlCommand = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    fullName = reader["WaiterName"].ToString();
                    string price = reader["ReceiptSum"].ToString();
                    totalProfitSum += double.Parse(price);
                    totalFinishedOrders++;
                }
                PrintToConsole($"{fullName} padavėjas aptarnavo {totalFinishedOrders} staliukų ir atnešė {totalProfitSum} eurų apyvartos");
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showWorkerStatistics_Click(object sender, EventArgs e)
        {
            GetTodayTotalProfit();
        }

        private void GetWorkerNameFromDatabase()
        {
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                SqlCommand = new SqlCommand("Select * from Workers Where Role='Padavejas'", SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = SqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dt.Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName") ;
                chosedWorker.DataSource = dt;  
                chosedWorker.DisplayMember ="FullName";
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
