namespace Loan_Calculator
{
    partial class ViewAllData
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthlyIncome1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusName1 = new System.Windows.Forms.TextBox();
            this.cusId1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eligibility1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Instalment1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.interest1 = new System.Windows.Forms.TextBox();
            this.years1 = new System.Windows.Forms.TextBox();
            this.principal1 = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.Label();
            this.intrestRate = new System.Windows.Forms.Label();
            this.principal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.delete1 = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Button();
            this.loanTypev = new System.Windows.Forms.Label();
            this.loantype2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(17, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search for Customers";
            this.textBox1.Size = new System.Drawing.Size(346, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // monthlyIncome1
            // 
            this.monthlyIncome1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlyIncome1.Location = new System.Drawing.Point(210, 176);
            this.monthlyIncome1.Name = "monthlyIncome1";
            this.monthlyIncome1.ReadOnly = true;
            this.monthlyIncome1.Size = new System.Drawing.Size(150, 32);
            this.monthlyIncome1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "Monthly Income";
            // 
            // cusName1
            // 
            this.cusName1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusName1.Location = new System.Drawing.Point(210, 127);
            this.cusName1.Name = "cusName1";
            this.cusName1.ReadOnly = true;
            this.cusName1.Size = new System.Drawing.Size(150, 32);
            this.cusName1.TabIndex = 37;
            // 
            // cusId1
            // 
            this.cusId1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusId1.Location = new System.Drawing.Point(210, 77);
            this.cusId1.Name = "cusId1";
            this.cusId1.ReadOnly = true;
            this.cusId1.Size = new System.Drawing.Size(175, 32);
            this.cusId1.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(436, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Eligibility";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eligibility1
            // 
            this.eligibility1.BackColor = System.Drawing.SystemColors.Control;
            this.eligibility1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eligibility1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eligibility1.Location = new System.Drawing.Point(665, 277);
            this.eligibility1.Name = "eligibility1";
            this.eligibility1.ReadOnly = true;
            this.eligibility1.Size = new System.Drawing.Size(150, 29);
            this.eligibility1.TabIndex = 33;
            this.eligibility1.Visible = false;
            this.eligibility1.TextChanged += new System.EventHandler(this.eligibility1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Customer ID";
            // 
            // Instalment1
            // 
            this.Instalment1.BackColor = System.Drawing.SystemColors.Control;
            this.Instalment1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instalment1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instalment1.Location = new System.Drawing.Point(665, 235);
            this.Instalment1.Name = "Instalment1";
            this.Instalment1.ReadOnly = true;
            this.Instalment1.Size = new System.Drawing.Size(150, 25);
            this.Instalment1.TabIndex = 47;
            this.Instalment1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(436, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "Monthly Instalment";
            // 
            // interest1
            // 
            this.interest1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interest1.Location = new System.Drawing.Point(590, 130);
            this.interest1.Name = "interest1";
            this.interest1.ReadOnly = true;
            this.interest1.Size = new System.Drawing.Size(150, 32);
            this.interest1.TabIndex = 45;
            // 
            // years1
            // 
            this.years1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.years1.Location = new System.Drawing.Point(590, 179);
            this.years1.Name = "years1";
            this.years1.ReadOnly = true;
            this.years1.Size = new System.Drawing.Size(150, 32);
            this.years1.TabIndex = 44;
            this.years1.TextChanged += new System.EventHandler(this.yearsv_TextChanged);
            // 
            // principal1
            // 
            this.principal1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.principal1.Location = new System.Drawing.Point(590, 80);
            this.principal1.Name = "principal1";
            this.principal1.ReadOnly = true;
            this.principal1.Size = new System.Drawing.Size(150, 32);
            this.principal1.TabIndex = 43;
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.years.Location = new System.Drawing.Point(436, 176);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(68, 32);
            this.years.TabIndex = 42;
            this.years.Text = "Years";
            this.years.Click += new System.EventHandler(this.years_Click);
            // 
            // intrestRate
            // 
            this.intrestRate.AutoSize = true;
            this.intrestRate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intrestRate.Location = new System.Drawing.Point(436, 127);
            this.intrestRate.Name = "intrestRate";
            this.intrestRate.Size = new System.Drawing.Size(148, 32);
            this.intrestRate.TabIndex = 41;
            this.intrestRate.Text = "Interest Rate";
            // 
            // principal
            // 
            this.principal.AutoSize = true;
            this.principal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.principal.Location = new System.Drawing.Point(436, 77);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(104, 32);
            this.principal.TabIndex = 40;
            this.principal.Text = "Principal";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 358);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(835, 319);
            this.listBox1.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(716, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "New Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(590, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Total Interest";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(468, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Interest Paid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(335, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Principal Paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(200, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Monthly Pymt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(86, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Starting Bal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(10, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 32);
            this.label13.TabIndex = 48;
            this.label13.Text = "Amortization Table";
            // 
            // delete1
            // 
            this.delete1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete1.Location = new System.Drawing.Point(777, 23);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(83, 38);
            this.delete1.TabIndex = 57;
            this.delete1.Text = "Delete";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // edit1
            // 
            this.edit1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit1.Location = new System.Drawing.Point(665, 23);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(83, 38);
            this.edit1.TabIndex = 58;
            this.edit1.Text = "Edit";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // loanTypev
            // 
            this.loanTypev.AutoSize = true;
            this.loanTypev.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanTypev.Location = new System.Drawing.Point(19, 229);
            this.loanTypev.Name = "loanTypev";
            this.loanTypev.Size = new System.Drawing.Size(152, 32);
            this.loanTypev.TabIndex = 87;
            this.loanTypev.Text = "Type of Loan";
            // 
            // loantype2
            // 
            this.loantype2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loantype2.Location = new System.Drawing.Point(210, 232);
            this.loantype2.Name = "loantype2";
            this.loantype2.ReadOnly = true;
            this.loantype2.Size = new System.Drawing.Size(150, 32);
            this.loantype2.TabIndex = 88;
            // 
            // ViewAllData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 688);
            this.Controls.Add(this.loantype2);
            this.Controls.Add(this.loanTypev);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Instalment1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interest1);
            this.Controls.Add(this.years1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.years);
            this.Controls.Add(this.intrestRate);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.monthlyIncome1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusName1);
            this.Controls.Add(this.cusId1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eligibility1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ViewAllData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllData_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox monthlyIncome1;
        private Label label4;
        private TextBox cusName1;
        private TextBox cusId1;
        private Label label3;
        private Label label2;
        private TextBox eligibility1;
        private Label label1;
        private TextBox Instalment1;
        private Label label5;
        private TextBox interest1;
        private TextBox years1;
        private TextBox principal1;
        private Label years;
        private Label intrestRate;
        private Label principal;
        private ListBox listBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button delete1;
        private Button edit1;
        private Label loanTypev;
        private TextBox loantype2;
    }
}