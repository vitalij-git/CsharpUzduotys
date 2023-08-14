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
        public CLientOrder()
        {
            InitializeComponent();
        }

        private void CLientOrder_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();   
                SqlConnection.Open();
                SqlCommand = new SqlCommand("Select * from DishMenu", SqlConnection);
                SqlDataAdapter dishAdapter = new SqlDataAdapter();
                dishAdapter.SelectCommand = SqlCommand;
                DataTable dishTable = new DataTable();
                dishAdapter.Fill(dishTable);
                comboBoxDish.DataSource = dishTable;
                comboBoxDish.DisplayMember = "Name";
                comboBoxDish.ValueMember = "Price";

                SqlCommand = new SqlCommand("Select * from DrinkMenu", SqlConnection);
                SqlDataAdapter drinkAdapter = new SqlDataAdapter();
                drinkAdapter.SelectCommand = SqlCommand;
                DataTable drinktTable = new DataTable();
                drinkAdapter.Fill(drinktTable);
                comboBoxDrink.DataSource = drinktTable; 
                comboBoxDrink.DisplayMember = "Name";
                comboBoxDrink.ValueMember = "Price";    
                SqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Back_Click(object sender, EventArgs e)
        {
            WaiterMain waitermain = new WaiterMain();
            this.Hide();
            waitermain.Show();  
        }

        private void AddDishToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                SqlConnection.Open();
                SqlCommand = new SqlCommand("Insert into ClientOrder(name,Price) Values('" + comboBoxDish.Text + "','" + comboBoxDish.ValueMember + "')", SqlConnection);
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
                SqlConnection.Open();
                SqlCommand = new SqlCommand("Insert into ClientOrder(name,Price) Values('" + comboBoxDrink.Text + "','" + comboBoxDrink.ValueMember + "')", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                MessageBox.Show($"Patiekalas {comboBoxDrink.Text}, sekmingai pridėtas prie užsakymo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
