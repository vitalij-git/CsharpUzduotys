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
    public partial class CashPay : Form
    {

        public double OrderSum { get; set; }
        private bool PayStatus =false;
        public CashPay()
        {
            InitializeComponent();
        }

        public CashPay(double orderSum)
        {
            OrderSum = orderSum;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            PayMethod payMethod = new PayMethod();
            this.Hide();
            payMethod.Show();
        }

        private void CheckField()
        {
            if (double.TryParse(MoneySum.Text, out double moneySum))
            {
                CheckMoneySum(moneySum);
            }
            else
            {
                MessageBox.Show("Įvedėte bloga skaičių");
            }
        }

        private void CheckMoneySum(double moneySum)
        {
            if(moneySum > 0 && moneySum < OrderSum)
            {
                MessageBox.Show("Įvedėte per maža suma pinigų");
                PayStatus = true;
            }
            else if(moneySum > OrderSum)
            {
                MessageBox.Show($"Jus gavote {moneySum}, klientui reikia gražintį {moneySum - OrderSum} eurų gražos");
            }
            else
            {
                MessageBox.Show("Įvedėte skaičiu su minusu");
            }
        }

        private void PayWithoutReceipt_Click(object sender, EventArgs e)
        {
            CheckField();
           if (PayStatus ==true) 
            {
                DeleteEndedOrder delete = new DeleteEndedOrder();
                delete.DeleteOrderFromDatabase();
                this.Hide();
                Tables tables = new Tables();
                tables.Show();
            }
        }
    }
}
