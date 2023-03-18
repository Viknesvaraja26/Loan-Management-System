namespace Loan_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.principal = new System.Windows.Forms.Label();
            this.intrestRate = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.principalv = new System.Windows.Forms.TextBox();
            this.yearsv = new System.Windows.Forms.TextBox();
            this.interestv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Instalmentv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.AutoSize = true;
            this.principal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.principal.Location = new System.Drawing.Point(12, 16);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(104, 32);
            this.principal.TabIndex = 0;
            this.principal.Text = "Principal";
            this.principal.Click += new System.EventHandler(this.label1_Click);
            // 
            // intrestRate
            // 
            this.intrestRate.AutoSize = true;
            this.intrestRate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intrestRate.Location = new System.Drawing.Point(12, 57);
            this.intrestRate.Name = "intrestRate";
            this.intrestRate.Size = new System.Drawing.Size(148, 32);
            this.intrestRate.TabIndex = 1;
            this.intrestRate.Text = "Interest Rate";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.years.Location = new System.Drawing.Point(12, 98);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(68, 32);
            this.years.TabIndex = 2;
            this.years.Text = "Years";
            this.years.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // principalv
            // 
            this.principalv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.principalv.Location = new System.Drawing.Point(166, 19);
            this.principalv.Name = "principalv";
            this.principalv.Size = new System.Drawing.Size(150, 32);
            this.principalv.TabIndex = 3;
            this.principalv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.principalv_KeyPress);
            // 
            // yearsv
            // 
            this.yearsv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearsv.Location = new System.Drawing.Point(166, 101);
            this.yearsv.Name = "yearsv";
            this.yearsv.Size = new System.Drawing.Size(150, 32);
            this.yearsv.TabIndex = 4;
            this.yearsv.TextChanged += new System.EventHandler(this.yearsv_TextChanged);
            this.yearsv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearsv_KeyPress);
            // 
            // interestv
            // 
            this.interestv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.interestv.Location = new System.Drawing.Point(166, 60);
            this.interestv.Name = "interestv";
            this.interestv.Size = new System.Drawing.Size(150, 32);
            this.interestv.TabIndex = 5;
            this.interestv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.interestv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monthly Instalment";
            // 
            // Instalmentv
            // 
            this.Instalmentv.BackColor = System.Drawing.SystemColors.Control;
            this.Instalmentv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instalmentv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instalmentv.Location = new System.Drawing.Point(241, 167);
            this.Instalmentv.Name = "Instalmentv";
            this.Instalmentv.ReadOnly = true;
            this.Instalmentv.Size = new System.Drawing.Size(150, 25);
            this.Instalmentv.TabIndex = 8;
            this.Instalmentv.Visible = false;
            this.Instalmentv.TextChanged += new System.EventHandler(this.Instalmentv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amortization Table";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Starting Bal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(202, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Monthly Pymt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(337, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Principal Paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(470, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Interest Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(592, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Interest";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(718, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "New Balance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 20;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(617, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(14, 312);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(835, 319);
            this.listBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(861, 643);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Instalmentv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interestv);
            this.Controls.Add(this.yearsv);
            this.Controls.Add(this.principalv);
            this.Controls.Add(this.years);
            this.Controls.Add(this.intrestRate);
            this.Controls.Add(this.principal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label principal;
        private Label intrestRate;
        private Label years;
        private TextBox principalv;
        private TextBox yearsv;
        private TextBox interestv;
        private Label label1;
        private TextBox Instalmentv;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}