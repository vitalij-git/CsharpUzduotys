using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Forms
{
    public partial class Tables : Form
    {
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        private List<string> SeatsCountList = new List<string>();
        private List<string> StatusList = new List<string>();
        private List<int> TablesIdList = new List<int>();
        private string CurrentTableStatus;
        public Tables()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
            WaiterMain waiterMain = new WaiterMain();
            this.Hide();
            waiterMain.Show();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetRestaurantTablesData();
        }

        private void SetTableSeatsField()
        {
            Table1.Text = SeatsCountList[0] + " vietų staliukas";
            Table2.Text = SeatsCountList[1] + " vietų staliukas";
            Table3.Text = SeatsCountList[2] + " vietų staliukas";
            Table4.Text = SeatsCountList[3] + " vietų staliukas";
            Table5.Text = SeatsCountList[4] + " vietų staliukas";
            Table6.Text = SeatsCountList[5] + " vietų staliukas";
            Table7.Text = SeatsCountList[6] + " vietų staliukas"; 
            Table8.Text = SeatsCountList[7] + " vietų staliukas";
            Table9.Text = SeatsCountList[8] + " vietų staliukas";
            Table10.Text = SeatsCountList[9] + " vietų staliukas";
            Table11.Text = SeatsCountList[10] + " vietų staliukas";
            Table12.Text = SeatsCountList[11] + " vietų staliukas";
        }

        private void SetTableStatusField()
        {
            Status1.Text = StatusList[0];
            Status2.Text = StatusList[1];
            Status3.Text = StatusList[2];
            Status4.Text = StatusList[3];
            Status5.Text = StatusList[4];
            Status6.Text = StatusList[5];
            Status7.Text = StatusList[6];
            Status8.Text = StatusList[7];
            Status9.Text = StatusList[8];
            Status10.Text = StatusList[9];
            Status11.Text = StatusList[10];
            Status12.Text = StatusList[11];
        }

        private void Table1_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[0];
            StreamWriterChosenTableID(TablesIdList[0], int.Parse(SeatsCountList[0]));
            TableClick(CurrentTableStatus);
        }
    
        private void Table2_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[1];
            StreamWriterChosenTableID(TablesIdList[1], int.Parse(SeatsCountList[1]));
            TableClick(CurrentTableStatus);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[2];
            StreamWriterChosenTableID(TablesIdList[2], int.Parse(SeatsCountList[2]));
            TableClick(CurrentTableStatus);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[3];
            StreamWriterChosenTableID(TablesIdList[3], int.Parse(SeatsCountList[3]));
            TableClick(CurrentTableStatus);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[4];
            StreamWriterChosenTableID(TablesIdList[4], int.Parse(SeatsCountList[4]));
            TableClick(CurrentTableStatus);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[5];
            StreamWriterChosenTableID(TablesIdList[5], int.Parse(SeatsCountList[5]));
            TableClick(CurrentTableStatus);
        }

        private void Table7_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[6];
            StreamWriterChosenTableID(TablesIdList[6], int.Parse(SeatsCountList[6]));
            TableClick(CurrentTableStatus);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[7];
            StreamWriterChosenTableID(TablesIdList[7], int.Parse(SeatsCountList[7]));
            TableClick(CurrentTableStatus);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[8];
            StreamWriterChosenTableID(TablesIdList[8], int.Parse(SeatsCountList[8]));
            TableClick(CurrentTableStatus);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[9];
            StreamWriterChosenTableID(TablesIdList[9], int.Parse(SeatsCountList[9]));
            TableClick(CurrentTableStatus);
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[10];
            StreamWriterChosenTableID(TablesIdList[10], int.Parse(SeatsCountList[10]));
            TableClick(CurrentTableStatus);
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            CurrentTableStatus = StatusList[11];
            StreamWriterChosenTableID(TablesIdList[11], int.Parse(SeatsCountList[11]));
            TableClick(CurrentTableStatus);
        }

        private void TableClick(string currentTableStatus)
        {
            if (currentTableStatus == "Užimtas")
            {
                Dialog dialog = new Dialog("Šitas staliukas užimtas, pasirinkite norima veiksma", "Papildyti", "Atlaisvinti");
                this.Hide();
                dialog.ShowDialog();
                

            }
            else if (currentTableStatus == "Rezervuotas")
            {
                var reserveList = GetReservedTableInfo();
                Dialog dialog = new Dialog($"Šitas staliukas rezervuotas {reserveList[0]} vardu {reserveList[1]} laiku,\n pasirinkite norima veiksma", "Pasodinti klientus", "Atšaukti rezervacija");
                this.Hide();
                dialog.ShowDialog();
            }
            else
            {
                Dialog dialog = new Dialog("Pasirinkite norima veiksma", "Rezervuoti", "Pasodinti klientus");
                this.Hide();
                dialog.ShowDialog();
            }
        }
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }
        
        private void StreamWriterChosenTableID(int chosenTableId, int seatsCount)
        {
            string filePath = @"C:\Users\Vitalis\Desktop\Programavimo darbai\EgzaminasRestoranas\EgzaminasRestoranas\bin\Debug\ChosenTableID.txt";
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(chosenTableId);
            }
        }

        private void GetRestaurantTablesData()
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Select * from RestaurantTables", SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    TablesIdList.Add(reader.GetInt32(0));
                    SeatsCountList.Add(reader.GetInt32(1).ToString());
                    StatusList.Add(reader.GetString(2));
                }
                SetTableSeatsField();
                SetTableStatusField();
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> GetReservedTableInfo()
        {
            List<string> reserverInfo = new List<string>();
            ReadTableId tableId = new ReadTableId();
            SqlConnection = Connection.Connection();
            SqlCommand = new SqlCommand($"Select * from TableReserve Where TableID={tableId.ReadTableFromFile()}", SqlConnection);
            SqlDataReader reader = SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                reserverInfo.Add(reader["ClientName"].ToString());
                string reservedTime = reader["ReservedTime"].ToString();
                reservedTime = reservedTime.Remove(5);
                reserverInfo.Add(reservedTime);
            }
            Connection.CloseConnection();
            return reserverInfo;
        }
    }
}
