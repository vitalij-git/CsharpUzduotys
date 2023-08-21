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
    public partial class AddWorker : Form
    {
        ConnectToDatabase ConnectionToDatabase = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();   
        public AddWorker()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (workerFirstName.Text != "" && workerLastName.Text != "" && workerRole.Text != "" && workerUsername.Text != "" && workerPassword.Text != "" && workerCheckPassword.Text != "")
                {
                    SqlConnection = ConnectionToDatabase.Connection();
                    SqlCommand.CommandText = "Select * From Workers where Username = '"+workerUsername.Text+"'";
                    SqlCommand.Connection = SqlConnection;
                    SqlDataReader reader = null;
                    reader = SqlCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Toks prisijungimo vardas jau užimtas");
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        if (workerPassword.Text == workerCheckPassword.Text)
                        {
                            var command = new SqlCommand("insert into Workers(FirstName,LastName,Role,Username,Password) Values('" + workerFirstName.Text + "','" + workerLastName.Text + "','" + workerRole.Text + "','" + workerUsername.Text + "','" + workerPassword.Text + "')", SqlConnection);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Darbuotojas sekmingai pridėtas");
                            SqlConnection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Slaptažodžia nesutampa");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Liko tuščių laukų");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void workerRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetWorkerRole();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorMain adminMain = new AdministratorMain(); 
            adminMain.ShowDialog();
        }

        public void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRoleStatus.Text = userStatusList[1];
        }

        private void GetWorkerRole()
        {
            try
            {
                SqlConnection = ConnectionToDatabase.Connection();
                SqlCommand = new SqlCommand("Select ID,Name from WorkerRoles", SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = SqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                workerRole.DataSource = dt;
                workerRole.DisplayMember = "Name";
                workerRole.ValueMember = "ID";
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
