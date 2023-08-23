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
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        ReadTableId TableId = new ReadTableId();
        private double OrderSum { get; set; }
        private object StartDateTime;
        private object EndDateTime;
        private int OrderQuantity;
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
            TableNumber();
            ClientOrderInfoOutput();
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
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardPay cardPay = new CardPay();
            this.Hide();
            cardPay.Show(); 
        }
     
        private void ClientOrderOutput()
        {
            using (SqlConnection = Connection.Connection())
            {
                string query = $"SELECT Name, Price FROM ClientOrder Where TableID={TableId.ReadTableFromFile()}"; 
                SqlCommand command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {   
                        string name = reader["Name"].ToString();
                        string price = reader["Price"].ToString();
                        OrderSum += double.Parse(price);  
                        PrintToConsole($"{name}.................................................................{price}€");
                        OrderQuantity++;
                    }
                    PrintToConsole($"Viso.................................................................{OrderSum}€");
                }
                Connection.CloseConnection();
            }
        }

        private void TableNumber()
        {
            try
            {
                using (SqlConnection = Connection.Connection())
                {
                    string query = $"SELECT * FROM RestaurantTables Where ID={TableId.ReadTableFromFile()}";
                    SqlCommand command = new SqlCommand(query, SqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var seatsCount = reader["SeatsCount"];
                            PrintToConsole($"\nStalo numeris: {2}");
                            PrintToConsole($"Vietų skaičius: {seatsCount}");     
                        }
                        else
                        {
                            MessageBox.Show("Nerado duomenų");
                        }

                    }
                    Connection.CloseConnection();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClientOrderInfoOutput()
        {
            try
            {
                using (SqlConnection = Connection.Connection())
                {
                    string query = $"SELECT * FROM OrderInfo Where TableID={TableId.ReadTableFromFile()}";
                    SqlCommand command = new SqlCommand(query, SqlConnection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            StartDateTime = reader["StartDateTime"];
                            EndDateTime = reader["EndDateTime"];
                            PrintToConsole($"Užsakymas startavo: {StartDateTime}");
                            PrintToConsole($"Užsakymo uždarymas: {EndDateTime}");
                        }
                        else
                        {
                            MessageBox.Show("Nerado duomenų");
                        }
                       
                    }
                    Connection.CloseConnection();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message );
            }

        }

        private void Cash_Click(object sender, EventArgs e)
        {
            CashPay cashPay = new CashPay(OrderSum);
            this.Hide();
            cashPay.Show();
        }

        private void PrintWaiter()
        {
            PrintToConsole($"Aptarnavo: {workerName.Text}");
        }
        
        private void Print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atsispausdino");
            try
            {
                SqlConnection = Connection.Connection();  
                SqlCommand = new SqlCommand("Insert into RestaurantReceipt(WaiterName,StartDateTime,EndDateTime,TableID,OrderQuantity,ReceiptSum) Values(@waiterName, @startDateTime,@endDateTime,@tableID,@orderQuantity,@receiptSum)",SqlConnection);
                SqlCommand.Parameters.AddWithValue("@waiterName", workerName.Text);
                SqlCommand.Parameters.AddWithValue("@startDateTime", StartDateTime);
                SqlCommand.Parameters.AddWithValue("@endDateTime", EndDateTime);
                SqlCommand.Parameters.AddWithValue("@tableID", TableId.ReadTableFromFile());
                SqlCommand.Parameters.AddWithValue("@orderQuantity", OrderQuantity);
                SqlCommand.Parameters.AddWithValue("@receiptSum", OrderSum);
                SqlCommand.ExecuteNonQuery();
                MessageBox.Show("Restorano čekis išsaugotas duomenų bazėje");
                Connection.CloseConnection();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
