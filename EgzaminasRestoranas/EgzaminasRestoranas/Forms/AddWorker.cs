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
        private ConnectToDatabase Connection = new ConnectToDatabase();
        private SqlConnection SqlConnection = new SqlConnection();
        private SqlCommand SqlCommand = new SqlCommand();   
        private SqlWorkerRepository SqlWorkerRepository = new SqlWorkerRepository();
        private AdministratorMain AdminMain = new AdministratorMain();
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
                    SqlDataReader reader = SqlWorkerRepository.CheckUsernameWithDatabase(workerUsername.Text);
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
                            Worker worker = new Worker(workerFirstName.Text, workerLastName.Text, workerRole.Text, workerUsername.Text, workerPassword.Text);
                            SqlWorkerRepository.Add(worker);
                            MessageBox.Show("Darbuotojas sekmingai pridėtas");
                            this.Hide();
                            AdminMain.Show();

                        }
                        else
                        {
                            MessageBox.Show("Slaptažodžiai nesutampa");
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
            AdminMain.Show();
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
                SqlConnection = Connection.Connection();
                SqlCommand = new SqlCommand("Select ID,Name from WorkerRoles", SqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = SqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                workerRole.DataSource = dt;
                workerRole.DisplayMember = "Name";
                workerRole.ValueMember = "ID";
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
