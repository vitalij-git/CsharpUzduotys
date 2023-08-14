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

namespace EgzaminasRestoranas.Forms
{
    public partial class Dialog : Form
    {
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        private int TableId { get; set; }
        private string Status;
        public Dialog()
        {
            
        }
        public Dialog(string message, string buttonText1, string buttonText2, int tableId)
        {
            InitializeComponent();
            labelText.Text = message;
            button1.Text = buttonText1;
            button2.Text = buttonText2;
            TableId = tableId;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Atšaukti rezervacija")
            {
                Status = "Laisvas";
                ChangeStatus();
            }
            else if ( button2.Text == "Atlaisvinti")
            {
                Status = "Laisvas";
                ChangeStatus();
            }
            else if (button2.Text == "Pasodinti klientus")
            {
                Status = "Užimtas";
                ChangeStatus();
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Grįžti")
            {
                this.Close();
            }
            else if (button1.Text == "Rezervuoti")
            {
                Status = "Rezervuotas";
                ChangeStatus();
            }
            else if( button1.Text == "Papildyti")
            {
                CLientOrder clientOrder = new CLientOrder();
                this.Hide();
                clientOrder.Show();
            }
        }

        private void ChangeStatus()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                SqlCommand = new SqlCommand($"UPDATE RestaurantTables Set Status='{Status}' WHere ID={TableId}", SqlConnection);
                if (SqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Staliuko statusas atnaujintas");
                }
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
