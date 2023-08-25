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
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();
        private ReadTableId TableId = new ReadTableId();
        private SqlDishMenuRepository SqlDishMenuRepository = new SqlDishMenuRepository();
        private SqlDrinkMenuRepository SqlDrinkMenuRepository = new SqlDrinkMenuRepository();
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
            DishComboBoxItem selectedDish = (DishComboBoxItem)comboBoxDish.SelectedItem;
            double price = selectedDish.Price;
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Insert into ClientOrder(name,Price,TableID) Values('" + comboBoxDish.Text + "','" + price + "','" + TableId.ReadTableFromFile() + "')", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show($"Patiekalas {comboBoxDish.Text}, sekmingai pridėtas prie užsakymo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }

        private void AddDrinkToOrder_Click(object sender, EventArgs e)
        {

            DrinkComboBoxItem selectedDrink = (DrinkComboBoxItem)comboBoxDrink.SelectedItem;
            double price = selectedDrink.Price;
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Insert into ClientOrder(Name,Price,TableID) Values('" + comboBoxDrink.Text + "','" + price + "','" + TableId.ReadTableFromFile() + "')", SqlConnection);
                SqlCommand.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show($"Patiekalas {comboBoxDrink.Text}, sekmingai pridėtas prie užsakymo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetDishFromDatabase()
        {
            var dishDictionary = SqlDishMenuRepository.GetAll();
            foreach ( var dish in dishDictionary )
            { 
                foreach( var dishList in dish.Value)
                {
                    var dishBox = new DishComboBoxItem()
                    {
                        Name = dishList.Name,
                        Price = dishList.Price,
                        Id = dishList.Id

                    };
                    comboBoxDish.Items.Add(dishBox);
                }
                if (comboBoxDish.Items.Count > 0)
                {
                    comboBoxDish.SelectedIndex = 0;
                }
            }


            //SqlConnection = Connection.Connection();
            //SqlCommand = new SqlCommand("Select * from DishMenu", SqlConnection);
            //SqlDataAdapter dishAdapter = new SqlDataAdapter();
            //dishAdapter.SelectCommand = SqlCommand;
            //DataTable dishTable = new DataTable();
            //dishAdapter.Fill(dishTable);
            //comboBoxDish.DataSource = dishTable;
            //comboBoxDish.DisplayMember = "Name";
            //comboBoxDish.ValueMember = "Price";
        }

        private void GetDrinkFromDatabase()
        {
            var drinkDictionary = SqlDrinkMenuRepository.GetAll();
            foreach( var drinks in drinkDictionary)
            {
                foreach (var drink in drinks.Value)
                {

                    var drinkBOx = new DrinkComboBoxItem()
                    {
                        Name = drink.Name,
                        Price = drink.Price,
                        Id = drink.Id

                    };
                    comboBoxDrink.Items.Add(drinkBOx);
                }
            }

            if (comboBoxDrink.Items.Count > 0)
            {
                comboBoxDrink.SelectedIndex = 0;
            }




            //SqlCommand = new SqlCommand("Select * from DrinkMenu", SqlConnection);
            //SqlDataAdapter drinkAdapter = new SqlDataAdapter();
            //drinkAdapter.SelectCommand = SqlCommand;
            //DataTable drinkTable = new DataTable();
            //drinkAdapter.Fill(drinkTable);
            //comboBoxDrink.DataSource = drinkTable;
            //comboBoxDrink.DisplayMember = "Name";
            //comboBoxDrink.ValueMember = "Price";
            //Connection.CloseConnection();
        }
    }
}
