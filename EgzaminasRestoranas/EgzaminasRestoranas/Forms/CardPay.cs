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
    public partial class CardPay : Form
    {
        public CardPay()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            PayMethod payMethod = new PayMethod();
            this.Hide();
            payMethod.Show();
        }

        private void withoutReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mokėjimas praėjo sekmingai");
            this.Hide();
            Tables tables = new Tables();
            tables.Show();
        }
    }
}
