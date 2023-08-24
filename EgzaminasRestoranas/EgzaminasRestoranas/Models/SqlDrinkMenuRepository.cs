
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class SqlDrinkMenuRepository : IDatabaseRepository<DrinkMenu>
    {
        private ConnectToDatabase Connection { get; set; } = new ConnectToDatabase();
        private SqlCommand Command { get; set; } = new SqlCommand();
        private SqlConnection SqlConnection { get; set; } = new SqlConnection();
        public void Add(DrinkMenu drink)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Insert into DrinkMenu(Name,Price) " +
                    $"Values(@Name,@Price)";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@Name", drink.Name);
                Command.Parameters.AddWithValue("@Price", drink.Price);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"delete from DrinkMenu where ID ='{id}'";
                Command = new SqlCommand(query, SqlConnection);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Gėrimas sėkmingai ištrintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<int, List<DrinkMenu>> GetAll()
        {
            Dictionary<int, List<DrinkMenu>> drinkMenuDictionary = new Dictionary<int, List<DrinkMenu>>();
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from DrinkMenu";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        DrinkMenu drinkMenu = new DrinkMenu
                        {
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDouble((reader["Price"])),
                            Id = Convert.ToInt32(reader["ID"])
                        };
                        if (!drinkMenuDictionary.ContainsKey(id))
                        {
                            drinkMenuDictionary[id] = new List<DrinkMenu>();
                        }
                        drinkMenuDictionary[id].Add(drinkMenu);
                    }
                }
                Connection.CloseConnection();
                return drinkMenuDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DrinkMenu GetById(int id)
        {
            DrinkMenu drinkMenu = new DrinkMenu();   
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Select * from DrinkMenu where ID  = '{id}'";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    reader.Read();
                    drinkMenu.Name = reader["Name"].ToString();
                    drinkMenu.Price = Convert.ToDouble(reader["Price"]);
                }
                Connection.CloseConnection();
                return drinkMenu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void Update(DrinkMenu drink, int id)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Update DrinkMenu Set Name = @Name, Price = @Price Where ID = {id}";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@Name", drink.Name);
                Command.Parameters.AddWithValue("@Price", drink.Price);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Gėrimas sėkmingai atnaujintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}