using System.Data.SqlClient;

namespace Loan_Calculator
{
    public partial class Check_Eligibility : Form
    {
        public double loanAmount { get; set; }

        public double monthlyPaymentv { get; set; }
        public double interestRate { get; set; }
        public int tenure { get; set; }

        //table-------------------------------------------------
        private double interest;
        private double principal;
        private int years;
        private double monthlyPayment;
        private List<string> amortizationData;

        //------------------------------------------------------


        public Check_Eligibility(double interest, double principal, int years, double monthlyPayment, List<string> amortizationData)
        {
            InitializeComponent();

            this.interest = interest;
            this.principal = principal;
            this.years = years;
            this.monthlyPayment = monthlyPayment;
            this.amortizationData = amortizationData;

            monthlyIncomev.KeyPress += monthlyIncomev_KeyPress;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Check_Eligibility_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you done checking?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //get values from user          
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(cusIdv.Text) || string.IsNullOrEmpty(cusNamev.Text) || string.IsNullOrEmpty(monthlyIncomev.Text))
            {
                MessageBox.Show("All fields must not be empty");

            }
            else
            {
                String loanType = comboBox1.SelectedItem.ToString();
                double monthlyIncome = Convert.ToDouble(monthlyIncomev.Text);

                // Calculate eligibility based on the loan type and monthly income
                double eligibilityAmount = 0.0;
                int eligibilityTenure = 0;
                double minimumInterestRate = 0.0;

                switch (loanType)
                {
                    case "Car Loan":
                        if (monthlyIncome * 0.2 >= 1200)
                        {
                            eligibilityAmount = 25000;
                            eligibilityTenure = 108;
                            minimumInterestRate = 0.03 + 0.064;
                        }
                        else if (monthlyIncome * 0.2 >= 700)
                        {
                            eligibilityAmount = 25000;
                            eligibilityTenure = 108;
                            minimumInterestRate = 0.03 + 0.064;
                        }
                        break;

                    case "Personal Loan":
                        if (monthlyIncome * 0.05 >= 300)
                        {
                            eligibilityAmount = 5000;
                            eligibilityTenure = 60;
                            minimumInterestRate = 0.055 + 0.064;
                        }
                        break;

                    case "Housing Loan":
                        if (monthlyIncome * 0.4 >= 100000)
                        {
                            eligibilityAmount = 100000;
                            eligibilityTenure = 300;
                            minimumInterestRate = 0.06 + 0.064;
                        }
                        break;

                    default:
                        MessageBox.Show("Invalid loan type selected.");
                        return;
                }

                double interestRatev = Math.Max(interestRate, minimumInterestRate);
                double monthlyPaymentvv = loanAmount * interestRatev / (1 - Math.Pow(1 + interestRatev, -tenure));

                // Check eligibility based on monthly payment and eligibility criteria
                bool eligible = false;


                if (loanAmount >= eligibilityAmount && tenure <= eligibilityTenure && monthlyPaymentv <= monthlyIncome * 0.3)
                {
                    eligible = true;
                }

                // Display eligibility status to the user
                if (eligible)
                {
                    MessageBox.Show("Congratulations! You are eligible for the " + loanType + " loan.");
                    eligibility.Visible = true;
                    eligibility.Text = "Eligible";
                }
                else if (eligibilityAmount > loanAmount)
                {
                    MessageBox.Show("Principal(Loan Amount) is too low.\nMinimum amount to borrow for " + loanType + " is : " + eligibilityAmount);
                }
                else
                {
                    MessageBox.Show("Sorry, you are not eligible for the " + loanType + " loan.");
                    eligibility.Visible = true;
                    eligibility.Text = "Not Eligible";
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            cusIdv.Clear();
            cusNamev.Clear();
            monthlyIncomev.Clear();
            eligibility.Clear();
        }

        private void loanTypev_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(cusIdv.Text) || string.IsNullOrEmpty(cusNamev.Text) || string.IsNullOrEmpty(monthlyIncomev.Text))
            {
                MessageBox.Show("All fields must not be empty");

            }
            else
            {
                String cusId = cusIdv.Text.ToString();
                String cusName = cusNamev.Text.ToString();
                String eligibilityStatus = eligibility.Text;
                String loanTypevv = comboBox1.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("insert into Table_LoanCal values (@CustomerId,@CustomerName, @interest, @principal, @years, @monthlyPayment, @monthlyIncome, @eligibility, @typeofLoan)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CustomerId", cusId);
                cmd.Parameters.AddWithValue("@CustomerName", cusName);
                cmd.Parameters.AddWithValue("@interest", interest);
                cmd.Parameters.AddWithValue("@principal", principal);
                cmd.Parameters.AddWithValue("@years", years);
                cmd.Parameters.AddWithValue("@monthlyPayment", monthlyPayment);
                cmd.Parameters.AddWithValue("@monthlyIncome", monthlyIncomev.Text);
                cmd.Parameters.AddWithValue("@eligibility", eligibilityStatus);
                cmd.Parameters.AddWithValue("@typeOfLoan", loanTypevv); 

                cmd.ExecuteNonQuery();

                // Save the amortization data to the SQL table
                foreach (string data in amortizationData)
                {
                    //SqlConnection con2 = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO [dbo].[View_data] ([CustomerId], [Data]) VALUES (@CustomerId, @data)", con);
                    cmd2.Parameters.AddWithValue("@CustomerId", cusId);
                    cmd2.Parameters.AddWithValue("@data", data);
                    cmd2.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Successfully Saved");
            }
        }

        private void monthlyIncomev_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthlyIncomev_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Check_Eligibility_Load(object sender, EventArgs e)
        {

        }

        private void eligibility_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

