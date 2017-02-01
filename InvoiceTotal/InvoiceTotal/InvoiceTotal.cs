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
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // recieve subtotal from user
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            //initialize discountPercent and set decimal based on subtotal value
            decimal discountPercent = 0m;

            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            //calculate and assign values for the discountAmount and invoiceTotals

            decimal discountAmount = subtotal*discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;


            //format all form values
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");


            //move focus back to the subtotal text box
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
