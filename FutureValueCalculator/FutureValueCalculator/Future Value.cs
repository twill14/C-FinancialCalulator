using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class Future_Value : Form
    {
        public Future_Value()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Decimal.Parse(txtMontlyInvestment.Text);
            decimal yearlyInterestRate = Decimal.Parse(txtYearlyIntrestRate.Text);
            int years = Convert.ToInt32(txtNumberOfYears.Text);

            int months = years*12;
            decimal monthlyInterestRate = yearlyInterestRate/12/100;

            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)*(1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            txtMontlyInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
