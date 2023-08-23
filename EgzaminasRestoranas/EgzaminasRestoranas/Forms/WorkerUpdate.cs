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
    public partial class WorkerUpdate : Form
    {
        ConnectToDatabase Connection = new ConnectToDatabase();
        SqlConnection SqlConnection = new SqlConnection();
        SqlCommand SqlCommand = new SqlCommand();
        private Worker Worker = new Worker();
        public int WorkerId { get; set; }
        private SqlWorkerRepository WorkerRepository { get; set; } = new SqlWorkerRepository();
        public WorkerUpdate(int workerId)
        {
            InitializeComponent();
            WorkerId = workerId;
        }

        private void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void WorkerUpdate_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            GetWorkerRole();
            GetWorkerInfo();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            BackToWorkersMenu();
        }

        private void GetWorkerInfo()
        {
            Worker = WorkerRepository.GetById(WorkerId);
            if (Worker != null)
            {
                workerFirstName.Text = Worker.FirstName;
                workerLastName.Text = Worker.LastName;
                workerUsername.Text = Worker.Username;
                workerPassword.Text = Worker.Password;  
                workerCheckPassword.Text = Worker.Password;
            }
            SelectedWorkerRole(Worker.Role);

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
                workerRoleComboBox.DataSource = dt;
                workerRoleComboBox.DisplayMember = "Name";
                workerRoleComboBox.ValueMember = "ID"; 
                
                Connection.CloseConnection();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SelectedWorkerRole(string workerRole)
        {
            int selectedIndex = workerRoleComboBox.FindString(workerRole);
            if (selectedIndex != -1)
            {
                workerRoleComboBox.SelectedIndex = selectedIndex;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (workerFirstName.Text != "" && workerLastName.Text != "" && workerRole.Text != "" && workerUsername.Text != "" && workerPassword.Text != "" && workerCheckPassword.Text != "")
            {
                Worker workerNewValues = new Worker();
                workerNewValues.FirstName = workerFirstName.Text;
                workerNewValues.LastName = workerLastName.Text;
                workerNewValues.Role = workerRoleComboBox.Text; 
                workerNewValues.Username = workerUsername.Text;
                workerNewValues.Password = workerPassword.Text;
                if(workerUsername.Text != Worker.Username && workerPassword.Text==workerCheckPassword.Text)
                {
                    SqlDataReader reader = WorkerRepository.CheckUsernameWithDatabase(workerUsername.Text);
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Toks prisijungimo vardas jau užimtas");
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        WorkerRepository.Update(workerNewValues, WorkerId);
                        BackToWorkersMenu();


                    }
                }
                else if (workerUsername.Text == Worker.Username && workerPassword.Text == workerCheckPassword.Text)
                {

                    WorkerRepository.Update(workerNewValues, WorkerId);
                    BackToWorkersMenu();
                }
                else
                {
                    MessageBox.Show("Slaptažodžiai nesutampa");
                }
            }
            else
            {
                MessageBox.Show("Yra tuščių laukų");
            }
        }

        private void BackToWorkersMenu()
        {
            Workers workers = new Workers();
            this.Hide();
            workers.Show();
        }
    }
}
