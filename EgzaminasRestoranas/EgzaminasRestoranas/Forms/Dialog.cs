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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EgzaminasRestoranas.Forms
{
    public partial class Dialog : Form
    {
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        private ReadTableId TableId = new ReadTableId();
        private Tables tables = new Tables();
        private string Status { get; set; }

        public Dialog()
        {
            InitializeComponent();
        }

        public Dialog(string status)
        {
            Status = status;
            InitializeComponent();
        }
        public Dialog(string message, string buttonText1, string buttonText2)
        {
            InitializeComponent();
            labelText.Text = message;
            button1.Text = buttonText1;
            button2.Text = buttonText2;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Atšaukti rezervacija")
            {
                Status = "Laisvas";
                DeleteReservedTime();
                ChangeStatus();
            }
            else if ( button2.Text == "Atlaisvinti")
            {
                CheckOrderTableStatus();
                
            }
            else if (button2.Text == "Pasodinti klientus")
            {
                Status = "Užimtas";
                OrderBegin();
                ChangeStatus();
            }
            else
            {
                MessageBox.Show("Įvyko klaida, prašome pabandyti dar karta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Pasodinti klientus")
            {
                DeleteReservedTime();
                Status = "Užimtas";
                OrderBegin();
                ChangeStatus();
            }
            else if (button1.Text == "Rezervuoti")
            {
                TableReserve reserve = new TableReserve();
                this.Hide();
                reserve.Show();
            }
            else if( button1.Text == "Papildyti")
            {
                CLientOrder clientOrder = new CLientOrder();
                this.Hide();
                clientOrder.Show();
            }
        }

        public void ChangeStatus()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand($"UPDATE RestaurantTables Set Status='{Status}' WHere ID={TableId.ReadTableFromFile()}", SqlConnection);
                if (SqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Staliuko statusas atnaujintas");
                }
                Connection.CloseConnection(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            tables.Show();
        }

        public void CheckOrderTableStatus()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Select *  from ClientOrder where TableID=@tableid", SqlConnection);
                SqlCommand.Parameters.Add("@tableid", TableId.ReadTableFromFile());
                object obj = SqlCommand.ExecuteScalar();    
                if (Convert.ToInt32(obj) > 0)
                {
                    MessageBox.Show("Stalas turi neapmokėtą užsakymą.");
                    OrderEnd();
                    PayMethod payMethod = new PayMethod();
                    this.Hide();
                    payMethod.Show();
                }
                else
                { 
                    Status = "Laisvas";
                    DeleteEndedOrder delete = new DeleteEndedOrder();
                    delete.DeleteOrderInfo();
                    ChangeStatus();
                }
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
           
        }

        private void OrderBegin()
        {   
            DateTime currentDateTime = DateTime.Now;
            
            try 
            {
                SqlConnection = Connection.Connection();             
                SqlCommand = new SqlCommand($"Insert into OrderInfo(TableID,StartDateTime) Values(@TableID,@DateTime)", SqlConnection);
                SqlCommand.Parameters.AddWithValue("@TableID", TableId.ReadTableFromFile());
                SqlCommand.Parameters.AddWithValue("@DateTime", currentDateTime);
                SqlCommand.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderEnd()
        {
            DateTime currentDateTime = DateTime.Now;
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand($"UPdate OrderInfo Set EndDateTime=@DateTime Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
                SqlCommand.Parameters.AddWithValue("@DateTime", currentDateTime);
                SqlCommand.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteReservedTime()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand($"Delete from TableReserve Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            tables.Show();
        }
    }
}
