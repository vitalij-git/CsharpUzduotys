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
            DeleteEndedOrder delete = new DeleteEndedOrder();
            delete.DeleteOrderFromDatabase();
            this.Hide();
            Dialog dialog = new Dialog();
            dialog.CheckOrderTableStatus();
        }

        private void withReceipt_Click(object sender, EventArgs e)
        {
            OrderReceipt orderReceipt = new OrderReceipt(); 
            this.Hide();
            orderReceipt.Show();
        }
    }
}
