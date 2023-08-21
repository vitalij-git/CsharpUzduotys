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
    public partial class CLientOrder : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        ReadTableId TableId = new ReadTableId();
        public CLientOrder()
        {
            InitializeComponent();
        }

        private void CLientOrder_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            try
            {
                GetDishFromDatabase();
                GetDrinkFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            this.Hide();
            tables.Show();  
        }

        private void AddDishToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                SqlCommand = new SqlCommand("Insert into ClientOrder(name,Price,TableID) Values('" + comboBoxDish.Text + "','" + comboBoxDish.SelectedValue + "','" + TableId.ReadTableFromFile() + "')", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                MessageBox.Show($"Patiekalas {comboBoxDish.Text}, sekmingai pridėtas prie užsakymo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }

        private void AddDrinkToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                SqlCommand = new SqlCommand("Insert into ClientOrder(Name,Price,TableID) Values('" + comboBoxDrink.Text + "','" + comboBoxDrink.SelectedValue + "','" + TableId.ReadTableFromFile() + "')", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                MessageBox.Show($"Patiekalas {comboBoxDrink.Text}, sekmingai pridėtas prie užsakymo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetDishFromDatabase()
        {
            SqlConnection = ConnectionToDatabase.Connection();
            SqlCommand = new SqlCommand("Select * from DishMenu", SqlConnection);
            SqlDataAdapter dishAdapter = new SqlDataAdapter();
            dishAdapter.SelectCommand = SqlCommand;
            DataTable dishTable = new DataTable();
            dishAdapter.Fill(dishTable);
            comboBoxDish.DataSource = dishTable;
            comboBoxDish.DisplayMember = "Name";
            comboBoxDish.ValueMember = "Price";
        }

        private void GetDrinkFromDatabase()
        {
            SqlCommand = new SqlCommand("Select * from DrinkMenu", SqlConnection);
            SqlDataAdapter drinkAdapter = new SqlDataAdapter();
            drinkAdapter.SelectCommand = SqlCommand;
            DataTable drinkTable = new DataTable();
            drinkAdapter.Fill(drinkTable);
            comboBoxDrink.DataSource = drinkTable;
            comboBoxDrink.DisplayMember = "Name";
            comboBoxDrink.ValueMember = "Price";
            SqlConnection.Close();
        }
    }
}
