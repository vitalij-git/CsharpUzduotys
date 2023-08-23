using EgzaminasRestoranas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Forms
{
    public partial class Workers : Form
    {
        private SqlWorkerRepository WorkerRepository { get; set; } = new SqlWorkerRepository();
        public Workers()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdministratorMain adminMaain = new AdministratorMain();
            this.Hide();
            adminMaain.Show();
        }
        private void ShowWorkerStatus()
        {
            var workerStatus = new WorkerStatus();
            List<string> userStatusList = workerStatus.GetWorkerStatus();
            workerName.Text = userStatusList[0];
            workerRole.Text = userStatusList[1];
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            ShowWorkerStatus();
            WorkersOutput();
        }
        private void PrintToConsole(string message)
        {
            Font customFont = new Font("Times New Roman", 14);
            TextBox.SelectionFont = customFont;
            TextBox.SelectionColor = Color.Black;
            panel.Size = new Size(panel.Size.Width, TextBox.Height);
            TextBox.AppendText(message + Environment.NewLine);
        }

        private void WorkersOutput()
        {
            var workersDictionary = WorkerRepository.GetAll();
            foreach (var workers in workersDictionary)
            {
                int workerId = workers.Key;
                foreach(var worker in workers.Value)
                {
                    PrintToConsole($"{workerId}. Vardas: {worker.FirstName}  Pavarde: {worker.LastName} \nPareigos: {worker.Role}  Prisijungimo vardas: {worker.Username}");
                    string workerFullName = worker.FirstName + " " + worker.LastName;
                    var comboBoxItem = new WorkerComboBoxItem
                    {
                        WorkerId = workerId,
                        WorkerName = workerFullName
                    };
                    workersComboBox.Items.Add(comboBoxItem);
                }
            }
            if (workersComboBox.Items.Count > 0)
            {
                workersComboBox.SelectedIndex = 0;
            }
        }

        private void workerDelete_Click(object sender, EventArgs e)
        {

                WorkerComboBoxItem selectedWorker = (WorkerComboBoxItem)workersComboBox.SelectedItem;
                int workerId = selectedWorker.WorkerId;
                WorkerRepository.Delete(workerId);
            
        }

        private void workerUpdate_Click(object sender, EventArgs e)
        {
                WorkerComboBoxItem selectedWorker = (WorkerComboBoxItem)workersComboBox.SelectedItem;
                int workerId = selectedWorker.WorkerId;
                this.Hide();
                WorkerUpdate workerUpdate = new WorkerUpdate(workerId);
                workerUpdate.Show();
        }
    }
}
