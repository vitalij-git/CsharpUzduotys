using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EgzaminasRestoranas.Forms
{
    public partial class TodayTotalProfit : Form
    {
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        public TodayTotalProfit()
        {
            InitializeComponent();
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();   
            this.Hide();
            statistics.Show();
        }

        private void TodayTotalProfit_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetTodayTotalProfit();

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
            try 
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from AllOrder Where cast(Date as Date) = cast(getdate() as Date)";
                SqlCommand = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string price = reader["Price"].ToString();
                    totalProfitSum += double.Parse(price);
                    PrintToConsole($"{name}.........................................{price}");
                }
                PrintToConsole($"PVM mokėstis(21%)...................................{Math.Round(totalProfitSum * 0.21, 2)}");
                PrintToConsole($"Viso...........................................................{totalProfitSum}");
                PrintToConsole($"Pelnas........................................................{Math.Round(totalProfitSum * 0.79, 2)}");
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
