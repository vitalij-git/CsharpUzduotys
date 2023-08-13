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
    public partial class Tables : Form
    {
        public string WorkerFullName { get; set; }
        public string WorkerRole { get; set; }
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        private List<string> SeatsCountList = new List<string>();
        private List<string> StatusList = new List<string>();
        private List<int> TablesIdList = new List<int>();   
        public Tables()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
            WaiterMain waiterMain = new WaiterMain();
            waiterMain.WorkerFullName = WorkerFullName;
            waiterMain.WorkerRole = WorkerRole; 
            this.Hide();
            waiterMain.Show();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            workerName.Text = WorkerFullName;
            workerRole.Text = WorkerRole;
            try
            {
                SqlConnection = Connection.Connection();
                SqlConnection.Open();
                SqlCommand = new SqlCommand("Select * from RestaurantTables", SqlConnection);
                SqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                   SeatsCountList.Add(reader.GetInt32(1).ToString());
                   StatusList.Add(reader.GetString(2));    
                }
                SetTableSeatsField();
                SetTableStatusField();
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            TableClick(1);
        }
    
        private void Table2_Click(object sender, EventArgs e)
        {
            TableClick(2);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            TableClick(3);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            TableClick(4);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            TableClick(5);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            TableClick(6);
        }

        private void Table7_Click(object sender, EventArgs e)
        {
            TableClick(7);
        }

        private void Table8_Click(object sender, EventArgs e)
        {
            TableClick(8);
        }

        private void Table9_Click(object sender, EventArgs e)
        {
            TableClick(9);
        }

        private void Table10_Click(object sender, EventArgs e)
        {
            TableClick(10);
        }

        private void Table11_Click(object sender, EventArgs e)
        {
            TableClick(11);
        }

        private void Table12_Click(object sender, EventArgs e)
        {
            TableClick(12);
        }

        private void TableClick(int tableID)
        {
            if (Status2.Text == "Užimtas")
            {
                Dialog dialog = new Dialog("Šitas staliukas užimtas, pasirinkite norima veiksma", "Papildyti", "Atlaisvinti", tableID);
                dialog.ShowDialog();

            }
            else if (Status2.Text == "Rezervuotas")
            {
                Dialog dialog = new Dialog("Šitas staliukas rezervuotas, pasirinkite norima veiksma", "Grįžti", "Atšaukti rezervacija", tableID);
                dialog.ShowDialog();
            }
            else
            {
                Dialog dialog = new Dialog("Pasirinkite norima veiksma", "Rezervuoti", "Pasodinti klientus", tableID);
                dialog.ShowDialog();
            }
        }
    }
}
