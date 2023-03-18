//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System;
using System.Data.SqlClient;

namespace Loan_Calculator
{
    public partial class EditCustomerForm : Form
    {
        public String CustomerId { get; set; }
        public String CustomerName { get; set; }
        /*public String MonthlyIncome { get; set; }
        public String Eligibility { get; set; }
        public String Principal { get; set; }
        public String Interest { get; set; }
        public String Years { get; set; }
        public String MonthlyPayment { get; set; }
        public String loantypev1 { get; set; }*/

        public EditCustomerForm()
        {
            InitializeComponent();

            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            /*this.MonthlyIncome = MonthlyIncome;
            this.Eligibility = Eligibility;
            this.Principal = Principal;
            this.Interest = Interest;
            this.Years = Years;
            this.MonthlyPayment = MonthlyPayment;*/

            years1.KeyPress += years1_KeyPress;
            monthlyIncome1.KeyPress += monthlyIncome1_KeyPress;
            principal1.KeyPress += principal1_KeyPress;
            interest1.KeyPress += interest1_KeyPress;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Table_LoanCal WHERE CustomerId=@CustomerId", con);
            cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cusId1.Text = reader["CustomerId"].ToString();
                cusName1.Text = reader["CustomerName"].ToString();
                monthlyIncome1.Text = reader["monthlyIncome"].ToString();
                eligibility1.Text = reader["eligibility"].ToString();
                principal1.Text = reader["principal"].ToString();
                interest1.Text = reader["interest"].ToString();
                years1.Text = reader["years"].ToString();
                Instalment1.Text = reader["monthlyPayment"].ToString();
                comboBox2.SelectedItem = reader["typeofLoan"].ToString();
                eligibility1.Visible = true;
                Instalment1.Visible= true;

                // Store the customer ID value in a variable
                String customerId = (String)reader["CustomerId"];

                // Get amortization data for the selected customer
                listBox1.Items.Clear();
                reader.Close(); // Close the previous reader
                SqlCommand cmd2 = new SqlCommand("SELECT Data FROM View_data WHERE CustomerId=@CustomerId", con);
                cmd2.Parameters.AddWithValue("@CustomerId", customerId);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    listBox1.Items.Add(reader2["Data"].ToString());
                }
                reader2.Close();
            }
            reader.Close();
            con.Close();
        }



        private void EditCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you done Editing?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void years1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric input, backspace, and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void interest1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void principal1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void monthlyIncome1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void calculate1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(principal1.Text) || string.IsNullOrEmpty(interest1.Text) || string.IsNullOrEmpty(years1.Text) || comboBox2.SelectedItem == null || string.IsNullOrEmpty(cusId1.Text) || string.IsNullOrEmpty(cusName1.Text) || string.IsNullOrEmpty(monthlyIncome1.Text))
            {
                MessageBox.Show("All fields must not be empty!");
            }
            else
            {
                double interest = Convert.ToDouble(interest1.Text);
                double principal = Convert.ToDouble(principal1.Text);
                int years = Convert.ToInt32(years1.Text);

                int months = years * 12;
                double monthlyInterestRate = interest / 100 / 12;
                double monthlyPayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months)) / (Math.Pow(1 + monthlyInterestRate, months) - 1);

                // Display the monthly payment
                String monthlypayread = Convert.ToString(Math.Round(monthlyPayment, 2));
               //monthlypayread = String.Format("{0:C}", monthlyPayment);
                Instalment1.Text = monthlypayread;
                Instalment1.Visible = true;

                // Calculate and display the amortization schedule
                double balance = principal;
                double startingBalance = balance;
                double totalInterest = 0;
                for (int i = 1; i <= months; i++)
                {
                    double interestPaid = balance * monthlyInterestRate;
                    double principalPaid = monthlyPayment - interestPaid;
                    balance -= principalPaid;
                    double newBalance = balance;
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

                String loanType = comboBox2.SelectedItem.ToString();
                double monthlyIncome = Convert.ToDouble(monthlyIncome1.Text);

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

                double interestRatev = Math.Max(monthlyInterestRate, minimumInterestRate);
                double monthlyPaymentvv = principal * interestRatev / (1 - Math.Pow(1 + interestRatev, -months));

                // Check eligibility based on monthly payment and eligibility criteria
                bool eligible = false;


                if (principal >= eligibilityAmount && months <= eligibilityTenure && monthlyPayment <= monthlyIncome * 0.3)
                {
                    eligible = true;
                }

                // Display eligibility status to the user
                if (eligible)
                {
                    //MessageBox.Show("Congratulations! You are eligible for the " + loanType + " loan.");
                    eligibility1.Visible = true;
                    eligibility1.Text = "Eligible";
                }
                else if (eligibilityAmount > principal)
                {
                    MessageBox.Show("Principal(Loan Amount) is too low.\nMinimum amount to borrow for " + loanType + " is : " + eligibilityAmount);
                }
                else
                {
                    //  MessageBox.Show("Sorry, you are not eligible for the " + loanType + " loan.");
                    eligibility1.Visible = true;
                    eligibility1.Text = "Not Eligible";
                }

            }
        }

        private void save1_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                using (SqlCommand cmd = new SqlCommand("UPDATE Table_LoanCal SET CustomerName=@CustomerName, monthlyIncome=@monthlyIncome, eligibility=@eligibility, principal=@principal, interest=@interest, years=@years, monthlyPayment=@monthlyPayment, typeofLoan=@typeofLoan WHERE CustomerId=@CustomerId", con))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", cusName1.Text.Trim());
                    cmd.Parameters.AddWithValue("@monthlyIncome", double.Parse(monthlyIncome1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@eligibility", eligibility1.Text.Trim());
                    cmd.Parameters.AddWithValue("@principal", double.Parse(principal1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@interest", double.Parse(interest1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@years", int.Parse(years1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@monthlyPayment", double.Parse(Instalment1.Text.Trim()));
                    cmd.Parameters.AddWithValue("@typeofLoan", comboBox2.SelectedItem.ToString().Trim());
                    cmd.Parameters.AddWithValue("@CustomerId", CustomerId);

                    try
                    {
                        con.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Customer data updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error updating customer data");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating customer data: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                using (SqlCommand cmd2 = new SqlCommand("UPDATE [dbo].[View_data] SET [Data]=@data WHERE [CustomerId]=@CustomerId", con))
                {
                    try
                    {
                        con.Open();

                        // loop through the items in the ListBox and execute the SqlCommand to update each item
                        foreach (string data in listBox1.Items.Cast<string>().ToList())
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("@CustomerId", CustomerId);
                            cmd2.Parameters.AddWithValue("@data", data);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating amortization data: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

    }
}
