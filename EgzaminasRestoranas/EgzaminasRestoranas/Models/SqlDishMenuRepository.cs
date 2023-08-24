
using EgzaminasRestoranas.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class SqlDishMenuRepository : IDatabaseRepository<DishMenu>
    {
        private ConnectToDatabase Connection { get; set; } = new ConnectToDatabase();
        private SqlCommand Command { get; set; } = new SqlCommand();
        private SqlConnection SqlConnection { get; set; } = new SqlConnection();
        public void Add(DishMenu dish)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Insert into DishMenu(Name,Price) " +
                    $"Values(@Name,@Price)";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@Name", dish.Name);
                Command.Parameters.AddWithValue("@Price", dish.Price);
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
                string query = $"delete from DishMenu where ID ='{id}'";
                Command = new SqlCommand(query, SqlConnection);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Patiekalas sėkmingai ištrintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<int, List<DishMenu>> GetAll()
        {
            Dictionary<int, List<DishMenu>> dishMenuDictionary = new Dictionary<int, List<DishMenu>>();
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from DishMenu";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        DishMenu dishMenu = new DishMenu
                        {
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDouble((reader["Price"])),
                            Id = Convert.ToInt32(reader["ID"])

                        };
                        if (!dishMenuDictionary.ContainsKey(id))
                        {
                            dishMenuDictionary[id] = new List<DishMenu>();
                        }
                        dishMenuDictionary[id].Add(dishMenu);
                    }
                }
                Connection.CloseConnection();
                return dishMenuDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DishMenu GetById(int id)
        {
            DishMenu dishMenu = new DishMenu();
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Select * from DishMenu where ID  = '{id}'";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    reader.Read();
                    dishMenu.Name = reader["Name"].ToString();
                    dishMenu.Price = Convert.ToDouble(reader["Price"]);
                }
                Connection.CloseConnection();
                return dishMenu;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void Update(DishMenu dish, int id)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Update DishMenu Set Name = @Name, Price = @Price Where ID = {id}";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@Name", dish.Name);
                Command.Parameters.AddWithValue("@Price", dish.Price);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Patiekalas sėkmingai atnaujintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}