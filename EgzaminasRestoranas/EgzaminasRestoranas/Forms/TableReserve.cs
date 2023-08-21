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
    public partial class TableReserve : Form
    {
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        private ReadTableId TableId = new ReadTableId();
        private  DateTimePicker timePicker = new DateTimePicker();
        public TableReserve()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            this.Hide();
            tables.Show();
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void TableReserve_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            InitializeTimePicker();
        }
        private void InitializeTimePicker()
        {
            
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(10, 10);
            timePicker.Width = 100;    
            panelBox.Controls.Add(timePicker);  
        }

        private void confirmReserve_Click(object sender, EventArgs e)
        {
            if(clientName.Text.Length == 0)
            {
                MessageBox.Show("Įveskite rezervacijos kliento varda");
            }
            else
            {
                try
                {
                    SqlConnection = Connection.Connection();
                    SqlCommand = new SqlCommand("Insert into TableReserve(ClientName,ReservedTime,TableID) Values(@name,@time,@tableID)", SqlConnection);
                    SqlCommand.Parameters.AddWithValue("@name", clientName.Text);
                    SqlCommand.Parameters.AddWithValue("@time", timePicker.Value);
                    SqlCommand.Parameters.AddWithValue("@tableID", TableId.ReadTableFromFile());
                    if (SqlCommand.ExecuteNonQuery() > 0)
                    {
                        Dialog dialog = new Dialog("Rezervuotas");
                        dialog.ChangeStatus();
                        this.Hide();
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
}
