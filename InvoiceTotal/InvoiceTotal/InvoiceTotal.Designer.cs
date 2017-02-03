namespace InvoiceTotal
{
    partial class InvoiceTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subTotal = new System.Windows.Forms.Label();
            this.dicountPercent = new System.Windows.Forms.Label();
            this.discountAmount = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.lblNumberofInvoices = new System.Windows.Forms.Label();
            this.txtNumberofInvoices = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalOfInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.lblSmallestInvoice = new System.Windows.Forms.Label();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.lblLargestInvoice = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(52, 50);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(60, 17);
            this.subTotal.TabIndex = 0;
            this.subTotal.Text = "&Subtotal";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dicountPercent
            // 
            this.dicountPercent.AutoSize = true;
            this.dicountPercent.Location = new System.Drawing.Point(52, 87);
            this.dicountPercent.Name = "dicountPercent";
            this.dicountPercent.Size = new System.Drawing.Size(120, 17);
            this.dicountPercent.TabIndex = 0;
            this.dicountPercent.Text = "Discount Percent:";
            this.dicountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountAmount
            // 
            this.discountAmount.AutoSize = true;
            this.discountAmount.Location = new System.Drawing.Point(52, 123);
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.Size = new System.Drawing.Size(119, 17);
            this.discountAmount.TabIndex = 0;
            this.discountAmount.Text = "Discount Amount:";
            this.discountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(52, 159);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(40, 17);
            this.total.TabIndex = 0;
            this.total.Text = "Total";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(178, 50);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(178, 87);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 22);
            this.txtDiscountPercent.TabIndex = 1;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(178, 120);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscountAmount.TabIndex = 1;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(311, 204);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(512, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(407, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Totals";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.AutoSize = true;
            this.lblEnterSubtotal.Location = new System.Drawing.Point(52, 13);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(98, 17);
            this.lblEnterSubtotal.TabIndex = 5;
            this.lblEnterSubtotal.Text = "Enter Subtotal";
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Location = new System.Drawing.Point(178, 13);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // lblNumberofInvoices
            // 
            this.lblNumberofInvoices.AutoSize = true;
            this.lblNumberofInvoices.Location = new System.Drawing.Point(312, 13);
            this.lblNumberofInvoices.Name = "lblNumberofInvoices";
            this.lblNumberofInvoices.Size = new System.Drawing.Size(133, 17);
            this.lblNumberofInvoices.TabIndex = 7;
            this.lblNumberofInvoices.Text = "Number of Invoices:";
            // 
            // txtNumberofInvoices
            // 
            this.txtNumberofInvoices.Location = new System.Drawing.Point(464, 18);
            this.txtNumberofInvoices.Name = "txtNumberofInvoices";
            this.txtNumberofInvoices.ReadOnly = true;
            this.txtNumberofInvoices.Size = new System.Drawing.Size(100, 22);
            this.txtNumberofInvoices.TabIndex = 1;
            this.txtNumberofInvoices.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total of Invoices:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Invoice Average:";
            // 
            // txtTotalOfInvoices
            // 
            this.txtTotalOfInvoices.Location = new System.Drawing.Point(464, 50);
            this.txtTotalOfInvoices.Name = "txtTotalOfInvoices";
            this.txtTotalOfInvoices.ReadOnly = true;
            this.txtTotalOfInvoices.Size = new System.Drawing.Size(100, 22);
            this.txtTotalOfInvoices.TabIndex = 1;
            this.txtTotalOfInvoices.TabStop = false;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Location = new System.Drawing.Point(464, 84);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(100, 22);
            this.txtInvoiceAverage.TabIndex = 1;
            this.txtInvoiceAverage.TabStop = false;
            // 
            // lblSmallestInvoice
            // 
            this.lblSmallestInvoice.AutoSize = true;
            this.lblSmallestInvoice.Location = new System.Drawing.Point(312, 123);
            this.lblSmallestInvoice.Name = "lblSmallestInvoice";
            this.lblSmallestInvoice.Size = new System.Drawing.Size(113, 17);
            this.lblSmallestInvoice.TabIndex = 11;
            this.lblSmallestInvoice.Text = "Smallest Invoice:";
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Location = new System.Drawing.Point(464, 122);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 22);
            this.txtSmallestInvoice.TabIndex = 12;
            // 
            // lblLargestInvoice
            // 
            this.lblLargestInvoice.AutoSize = true;
            this.lblLargestInvoice.Location = new System.Drawing.Point(312, 159);
            this.lblLargestInvoice.Name = "lblLargestInvoice";
            this.lblLargestInvoice.Size = new System.Drawing.Size(108, 17);
            this.lblLargestInvoice.TabIndex = 13;
            this.lblLargestInvoice.Text = "Largest Invoice:";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Location = new System.Drawing.Point(464, 159);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 22);
            this.txtLargestInvoice.TabIndex = 14;
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(615, 253);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.lblLargestInvoice);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.lblSmallestInvoice);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInvoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberofInvoices);
            this.Controls.Add(this.lblNumberofInvoices);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.discountAmount);
            this.Controls.Add(this.dicountPercent);
            this.Controls.Add(this.subTotal);
            this.Name = "InvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label dicountPercent;
        private System.Windows.Forms.Label discountAmount;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        protected internal System.Windows.Forms.TextBox txtDiscountAmount;
        protected internal System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label lblNumberofInvoices;
        private System.Windows.Forms.TextBox txtNumberofInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalOfInvoices;
        protected internal System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label lblSmallestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label lblLargestInvoice;
        private System.Windows.Forms.TextBox txtLargestInvoice;
    }
}

