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

        private int numberOfInvoices = 0;
        private decimal totalOfInvoices = 0m;
        private decimal invoiceAverage = 0m;
        private decimal largestInvoice = 0m;
        private decimal smallestInvoice = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal subTotal = Decimal.Parse(txtEnterSubtotal.Text);
            decimal discountPercent = .25m;
            decimal discountAmount = Math.Round(subTotal*discountPercent, 2);
            decimal invoiceTotal = subTotal - discountAmount;

            txtSubtotal.Text = subTotal.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            numberOfInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAverage = totalOfInvoices/numberOfInvoices;

            smallestInvoice = smallestInvoice != 0 ? Math.Min(invoiceTotal, smallestInvoice) : invoiceTotal;

            largestInvoice = Math.Max(invoiceTotal, largestInvoice);

            txtNumberofInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");
            txtSmallestInvoice.Text = smallestInvoice.ToString("c");
            txtLargestInvoice.Text = largestInvoice.ToString("c");

            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;
            largestInvoice = 0m;

            txtNumberofInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";
            txtSmallestInvoice.Text = "";
            txtLargestInvoice.Text = "";
            txtEnterSubtotal.Focus();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
