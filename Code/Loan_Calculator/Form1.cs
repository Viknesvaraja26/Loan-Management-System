namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        double interest, monthlyInterestRate, monthlyPayment, balance, startingBalance, totalInterest, interestPaid, newBalance, principalPaid;
        int months;


        private void Instalmentv_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_Eligibility f2 = new Check_Eligibility(interest, allData.principal, allData.years, monthlyPayment, listBox1.Items.Cast<string>().ToList());
            f2.loanAmount = allData.principal;
            f2.interestRate = monthlyInterestRate;
            f2.tenure = months;
            f2.monthlyPaymentv = monthlyPayment;


            f2.Show();
        }

        public static class allData
        {
            public static double principal { get; set; }
            public static int years { get; set; }

        }

        public Form1()
        {
            InitializeComponent();

            principalv.KeyPress += principalv_KeyPress;
            interestv.KeyPress += interestv_KeyPress;
            yearsv.KeyPress += yearsv_KeyPress;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllData f3 = new ViewAllData();
            f3.Show();
        }

        private void principalv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Allow only up to two decimal places
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') == -1)
            {
                if ((sender as TextBox).Text.Length == 0 || (sender as TextBox).SelectionStart == 0)
                {
                    e.Handled = true;
                }
            }

            if (char.IsDigit(e.KeyChar))
            {
                // Allow only up to two decimal places
                int dotPosition = (sender as TextBox).Text.IndexOf('.');
                if (dotPosition > -1 && (sender as TextBox).SelectionStart > dotPosition + 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void interestv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Allow only up to two decimal places
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') == -1)
            {
                if ((sender as TextBox).Text.Length == 0 || (sender as TextBox).SelectionStart == 0)
                {
                    e.Handled = true;
                }
            }

            if (char.IsDigit(e.KeyChar))
            {
                // Allow only up to two decimal places
                int dotPosition = (sender as TextBox).Text.IndexOf('.');
                if (dotPosition > -1 && (sender as TextBox).SelectionStart > dotPosition + 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void yearsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearsv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            principalv.Clear();
            interestv.Clear();
            yearsv.Clear();
            Instalmentv.Clear();
            listBox1.Items.Clear();
            Instalmentv.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(principalv.Text) || string.IsNullOrEmpty(interestv.Text) || string.IsNullOrEmpty(yearsv.Text))
            {
                MessageBox.Show("All fields must not be empty!");
            }
            else
            {
                interest = Convert.ToDouble(interestv.Text);
                allData.principal = Convert.ToDouble(principalv.Text);
                allData.years = Convert.ToInt32(yearsv.Text);

                months = allData.years * 12;
                monthlyInterestRate = interest / 100 / 12;
                monthlyPayment = allData.principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months)) / (Math.Pow(1 + monthlyInterestRate, months) - 1);

                // Display the monthly payment
                String monthlypayread = Convert.ToString(monthlyPayment);
                monthlypayread = String.Format("{0:C}", monthlyPayment);
                Instalmentv.Text = monthlypayread;
                Instalmentv.Visible = true;

                // Calculate and display the amortization schedule
                balance = allData.principal;
                startingBalance = balance;
                totalInterest = 0;
                for (int i = 1; i <= months; i++)
                {
                    interestPaid = balance * monthlyInterestRate;
                    principalPaid = monthlyPayment - interestPaid;
                    balance -= principalPaid;
                    newBalance = balance;
                    totalInterest += interestPaid;

                    // Table
                    listBox1.Items.Add(String.Format("{0,-26} {1,-30} {2,-30} {3,-35} {4,-30} {5,-30} {6,-35}",
                    i.ToString("D3").PadLeft(10), startingBalance.ToString("c"),
                    monthlyPayment.ToString("c"),
                    principalPaid.ToString("c"),
                    interestPaid.ToString("c"),
                    totalInterest.ToString("c"),
                    newBalance.ToString("c")));


                    startingBalance = newBalance;
                }
            }

        }





        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}