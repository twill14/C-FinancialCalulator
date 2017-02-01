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
            this.SuspendLayout();
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(52, 35);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(60, 17);
            this.subTotal.TabIndex = 0;
            this.subTotal.Text = "&Subtotal";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dicountPercent
            // 
            this.dicountPercent.AutoSize = true;
            this.dicountPercent.Location = new System.Drawing.Point(52, 72);
            this.dicountPercent.Name = "dicountPercent";
            this.dicountPercent.Size = new System.Drawing.Size(120, 17);
            this.dicountPercent.TabIndex = 0;
            this.dicountPercent.Text = "Discount Percent:";
            this.dicountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // discountAmount
            // 
            this.discountAmount.AutoSize = true;
            this.discountAmount.Location = new System.Drawing.Point(52, 108);
            this.discountAmount.Name = "discountAmount";
            this.discountAmount.Size = new System.Drawing.Size(119, 17);
            this.discountAmount.TabIndex = 0;
            this.discountAmount.Text = "Discount Amount:";
            this.discountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(52, 144);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(40, 17);
            this.total.TabIndex = 0;
            this.total.Text = "Total";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(178, 35);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(178, 72);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(100, 22);
            this.txtDiscountPercent.TabIndex = 1;
            this.txtDiscountPercent.TabStop = false;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(178, 105);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscountAmount.TabIndex = 1;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(178, 144);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 205);
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
            this.btnExit.Location = new System.Drawing.Point(202, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(331, 253);
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
    }
}

