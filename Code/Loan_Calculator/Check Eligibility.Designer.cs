namespace Loan_Calculator
{
    partial class Check_Eligibility
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loanTypev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eligibility = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cusIdv = new System.Windows.Forms.TextBox();
            this.cusNamev = new System.Windows.Forms.TextBox();
            this.monthlyIncomev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Car Loan",
            "Personal Loan",
            "Housing Loan"});
            this.comboBox1.Location = new System.Drawing.Point(206, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loanTypev
            // 
            this.loanTypev.AutoSize = true;
            this.loanTypev.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loanTypev.Location = new System.Drawing.Point(15, 28);
            this.loanTypev.Name = "loanTypev";
            this.loanTypev.Size = new System.Drawing.Size(152, 32);
            this.loanTypev.TabIndex = 1;
            this.loanTypev.Text = "Type of Loan";
            this.loanTypev.Click += new System.EventHandler(this.loanTypev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // eligibility
            // 
            this.eligibility.BackColor = System.Drawing.SystemColors.Control;
            this.eligibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eligibility.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eligibility.Location = new System.Drawing.Point(131, 231);
            this.eligibility.Name = "eligibility";
            this.eligibility.ReadOnly = true;
            this.eligibility.Size = new System.Drawing.Size(150, 29);
            this.eligibility.TabIndex = 9;
            this.eligibility.Visible = false;
            this.eligibility.TextChanged += new System.EventHandler(this.eligibility_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 39);
            this.button4.TabIndex = 25;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 39);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 39);
            this.button2.TabIndex = 23;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Eligibility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer Name";
            // 
            // cusIdv
            // 
            this.cusIdv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusIdv.Location = new System.Drawing.Point(206, 78);
            this.cusIdv.Name = "cusIdv";
            this.cusIdv.Size = new System.Drawing.Size(175, 32);
            this.cusIdv.TabIndex = 28;
            // 
            // cusNamev
            // 
            this.cusNamev.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cusNamev.Location = new System.Drawing.Point(206, 128);
            this.cusNamev.Name = "cusNamev";
            this.cusNamev.Size = new System.Drawing.Size(150, 32);
            this.cusNamev.TabIndex = 29;
            // 
            // monthlyIncomev
            // 
            this.monthlyIncomev.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlyIncomev.Location = new System.Drawing.Point(206, 177);
            this.monthlyIncomev.Name = "monthlyIncomev";
            this.monthlyIncomev.Size = new System.Drawing.Size(150, 32);
            this.monthlyIncomev.TabIndex = 31;
            this.monthlyIncomev.TextChanged += new System.EventHandler(this.monthlyIncomev_TextChanged);
            this.monthlyIncomev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthlyIncomev_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Monthly Income";
            // 
            // Check_Eligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 343);
            this.Controls.Add(this.monthlyIncomev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusNamev);
            this.Controls.Add(this.cusIdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eligibility);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanTypev);
            this.Controls.Add(this.comboBox1);
            this.Name = "Check_Eligibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_Eligibility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_Eligibility_FormClosing);
            this.Load += new System.EventHandler(this.Check_Eligibility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label loanTypev;
        private Label label1;
        private TextBox eligibility;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox cusIdv;
        private TextBox cusNamev;
        private TextBox monthlyIncomev;
        private Label label4;
    }
}