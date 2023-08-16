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
    public partial class PayMethod : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        ReadTableId TableId = new ReadTableId();
        public PayMethod()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            this.Hide();
            dialog.Show();
        }

        private void PayMethod_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            ClientOrderOutput();
            ClientOrderInfoOutput();

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

        private void Card_Click(object sender, EventArgs e)
        {
            
            SqlConnection.Open();
            SqlCommand = new SqlCommand($"Select * from ClientOrder Where TableID={TableId.ReadTableFromFile()}",SqlConnection);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            while (reader.Read())
            {

            }

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
                    double priceSum = 0;
                    int row = 0;
                    while (reader.Read())
                    {   
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        priceSum += double.Parse(price);  
                        PrintToConsole($"{name}.................................................................{price}€");
                    }
                    PrintToConsole($"Viso.................................................................{priceSum}€");
                }
                SqlConnection.Close();
            }
        }

        private void ClientOrderInfoOutput()
        {
            try
            {
                using (SqlConnection = ConnectionToDatabase.Connection())
                {
                    string query = $"SELECT * FROM OrderInfo Where TableID={TableId.ReadTableFromFile()}";

                    SqlConnection.Open();
                    SqlCommand command = new SqlCommand(query, SqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        double priceSum = 0;
                        DateTime startDateTime = (DateTime)reader["StartDateTime"];
                        DateTime endDateTime = (DateTime)reader["EndDateTime"];
                        string seats = reader["Seats"].ToString();
                        PrintToConsole($"\nVietų skaičius...................................................................................................{seats}");
                        PrintToConsole($"\nUžsakymas startavo......................................{startDateTime}");
                        PrintToConsole($"\nUžsakymo uždarymas......................................{endDateTime}");
                    }
                    SqlConnection.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message );
            }

        }
    }
}
