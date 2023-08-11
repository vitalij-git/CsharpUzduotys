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
    public partial class WorkerLogin : Form
    {
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        public WorkerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Select count (*) as cnt from Workers where username=@username and password=@password", SqlConnection);
                SqlCommand.Parameters.Clear();
                SqlCommand.Parameters.Add("@username", username.Text);
                SqlCommand.Parameters.Add("@password", password.Text);
                SqlConnection.Open();
                if (SqlCommand.ExecuteScalar().ToString() == "1")
                {
                    SqlCommand = new SqlCommand($"Select * from Workers where username='{username.Text}' and password='{password.Text}'", SqlConnection);
                    SqlDataReader reader = SqlCommand.ExecuteReader();
                    reader.Read();
                    string workerFullName = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                    string workerRole = reader["Role"].ToString();
                    SqlConnection.Close();
                    if (workerRole == "Administratorius")
                    {
                        AdministratorMain administrator = new AdministratorMain();
                        administrator.WorkerFullName = workerFullName;
                        administrator.WorkerRole = workerRole;
                        this.Hide();
                        administrator.Show();
                    }
                    else if (workerRole == "Padavejas")
                    {

                    }
                }
                else
                {
                    MessageBox.Show("blogai ivesti duomenys");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
