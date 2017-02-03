namespace InvoiceTotal
{
    partial class Future_Value
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
            this.lblMonthlyInvestment = new System.Windows.Forms.Label();
            this.txtMontlyInvestment = new System.Windows.Forms.TextBox();
            this.lblYearlyInterestRate = new System.Windows.Forms.Label();
            this.txtYearlyIntrestRate = new System.Windows.Forms.TextBox();
            this.lblNumberofyears = new System.Windows.Forms.Label();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonthlyInvestment
            // 
            this.lblMonthlyInvestment.AutoSize = true;
            this.lblMonthlyInvestment.Location = new System.Drawing.Point(9, 25);
            this.lblMonthlyInvestment.Name = "lblMonthlyInvestment";
            this.lblMonthlyInvestment.Size = new System.Drawing.Size(133, 17);
            this.lblMonthlyInvestment.TabIndex = 0;
            this.lblMonthlyInvestment.Text = "Monthly Investment:";
            // 
            // txtMontlyInvestment
            // 
            this.txtMontlyInvestment.Location = new System.Drawing.Point(156, 25);
            this.txtMontlyInvestment.Name = "txtMontlyInvestment";
            this.txtMontlyInvestment.Size = new System.Drawing.Size(100, 22);
            this.txtMontlyInvestment.TabIndex = 1;
            // 
            // lblYearlyInterestRate
            // 
            this.lblYearlyInterestRate.AutoSize = true;
            this.lblYearlyInterestRate.Location = new System.Drawing.Point(9, 69);
            this.lblYearlyInterestRate.Name = "lblYearlyInterestRate";
            this.lblYearlyInterestRate.Size = new System.Drawing.Size(137, 17);
            this.lblYearlyInterestRate.TabIndex = 2;
            this.lblYearlyInterestRate.Text = "Yearly Interest Rate:";
            // 
            // txtYearlyIntrestRate
            // 
            this.txtYearlyIntrestRate.Location = new System.Drawing.Point(156, 69);
            this.txtYearlyIntrestRate.Name = "txtYearlyIntrestRate";
            this.txtYearlyIntrestRate.Size = new System.Drawing.Size(100, 22);
            this.txtYearlyIntrestRate.TabIndex = 2;
            // 
            // lblNumberofyears
            // 
            this.lblNumberofyears.AutoSize = true;
            this.lblNumberofyears.Location = new System.Drawing.Point(9, 108);
            this.lblNumberofyears.Name = "lblNumberofyears";
            this.lblNumberofyears.Size = new System.Drawing.Size(122, 17);
            this.lblNumberofyears.TabIndex = 4;
            this.lblNumberofyears.Text = "Number Of Years:";
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.Location = new System.Drawing.Point(156, 108);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfYears.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Future Value:";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(156, 148);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(100, 22);
            this.txtFutureValue.TabIndex = 1;
            this.txtFutureValue.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(88, 209);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Future_Value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFutureValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfYears);
            this.Controls.Add(this.lblNumberofyears);
            this.Controls.Add(this.txtYearlyIntrestRate);
            this.Controls.Add(this.lblYearlyInterestRate);
            this.Controls.Add(this.txtMontlyInvestment);
            this.Controls.Add(this.lblMonthlyInvestment);
            this.Name = "Future_Value";
            this.Text = "Future_Value";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonthlyInvestment;
        private System.Windows.Forms.TextBox txtMontlyInvestment;
        private System.Windows.Forms.Label lblYearlyInterestRate;
        private System.Windows.Forms.TextBox txtYearlyIntrestRate;
        private System.Windows.Forms.Label lblNumberofyears;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}