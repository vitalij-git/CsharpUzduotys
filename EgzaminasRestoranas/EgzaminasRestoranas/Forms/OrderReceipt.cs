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
    public partial class OrderReceipt : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        ReadTableId TableId = new ReadTableId();
        public OrderReceipt()
        {
            InitializeComponent();
        }

        private void receiptPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mokėjimas praėjo sekmingai \nKvitas spaudinasi...");
            DeleteEndedOrder delete = new DeleteEndedOrder();
            delete.DeleteOrderFromDatabase();
            this.Hide();
            Dialog dialog = new Dialog();
            dialog.CheckOrderTableStatus();
            
        }

        private void OrderReceipt_Load(object sender, EventArgs e)
        {
            ClientOrderOutput();
            PrintWaiter();
        }

        private void PrintToConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            TextBox.SelectionFont = customFont;
            TextBox.SelectionColor = Color.Black;
            panel.Size = new Size(panel.Size.Width, TextBox.Height);
            TextBox.AppendText(message + Environment.NewLine);
        }

        private void ClientOrderOutput()
        {
            using (SqlConnection = ConnectionToDatabase.Connection())
            {
                string query = $"SELECT Name, Price FROM ClientOrder Where TableID={TableId.ReadTableFromFile()}";

                SqlConnection.Open();
                SqlCommand command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    double orderSum = 0;
                    int row = 0;
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        orderSum += double.Parse(price);
                        PrintToConsole($"{name}........................{price}€");
                    }
                    PrintToConsole($"\nSuma..................................{Math.Round(orderSum * 0.79, 2)}€");
                    PrintToConsole($"PVM 21%...........................{Math.Round(orderSum * 0.21, 2)}€");
                    PrintToConsole($"Viso...................................{orderSum}€");
                }
                SqlConnection.Close();
            }     
        }
        
        private void PrintWaiter()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            PrintToConsole($"Aptarnavo: {userStatusList[0]}");
        }
    }
}
