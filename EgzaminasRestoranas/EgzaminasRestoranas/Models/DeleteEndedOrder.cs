
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    internal class DeleteEndedOrder
    {
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection(); 
        ReadTableId TableId = new ReadTableId();

        public void DeleteOrderFromDatabase()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                var SqlCommand = new SqlCommand($"Delete From ClientOrder Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteOrderInfo()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                var SqlCommand = new SqlCommand($"Delete From OrderInfo Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}