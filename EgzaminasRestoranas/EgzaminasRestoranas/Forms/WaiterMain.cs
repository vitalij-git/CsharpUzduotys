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
    public partial class WaiterMain : Form
    {
        public string WorkerFullName { get; set; }
        public string WorkerRole { get; set; }
        public WaiterMain()
        {
            InitializeComponent();
        }

        private void AddNewWorker_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sėkmingai atsijungėte");
            this.Hide();
            WorkerLogin workerLogin = new WorkerLogin();
            workerLogin.Show();
        }

        private void WaiterMain_Load(object sender, EventArgs e)
        {
            workerName.Text = WorkerFullName;
            workerRole.Text = WorkerRole;
        }

        private void Tables_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            this.Hide();
            tables.Show();
        }
    }
}
