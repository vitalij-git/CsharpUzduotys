
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
        SqlCommand SqlCommand = new SqlCommand();
        ReadTableId TableId = new ReadTableId();

        public void DeleteOrderFromDatabase()
        {
            CopyOrderToArchive();
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                SqlCommand = new SqlCommand($"Delete From ClientOrder Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
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
                SqlCommand = new SqlCommand($"Delete From OrderInfo Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CopyOrderToArchive()
        {
            DateTime date = DateTime.UtcNow.Date;   
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                SqlCommand = new SqlCommand($"Insert into AllOrder(Name,Price) Select Name,Price from ClientOrder Where TableID={TableId.ReadTableFromFile()}", SqlConnection);
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