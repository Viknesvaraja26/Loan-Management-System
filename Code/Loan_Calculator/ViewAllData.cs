using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculator
{
    public partial class ViewAllData : Form
    {
        public ViewAllData()
        {
            InitializeComponent();
        }

        private void years_Click(object sender, EventArgs e)
        {

        }

        private void yearsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Check for enter key press
            {
                SqlConnection con1 = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con1.Open();
                string customerName = textBox1.Text.Trim();
                SqlCommand cmd1 = new SqlCommand("SELECT CustomerId, CustomerName, interest, principal, years, monthlyPayment, monthlyIncome, eligibility, typeofLoan FROM Table_LoanCal WHERE CustomerName=@CustomerName", con1);
                cmd1.Parameters.AddWithValue("CustomerName", customerName);
                SqlDataReader reader1;

                reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    cusId1.Text = reader1["CustomerId"].ToString();
                    cusName1.Text = reader1["CustomerName"].ToString();
                    monthlyIncome1.Text = reader1["monthlyIncome"].ToString();
                    eligibility1.Text = reader1["eligibility"].ToString();
                    eligibility1.Visible = true;
                    principal1.Text = reader1["principal"].ToString();
                    interest1.Text = reader1["interest"].ToString();
                    years1.Text = reader1["years"].ToString();
                    Instalment1.Text = reader1["monthlyPayment"].ToString();
                    loantype2.Text = reader1["typeofLoan"].ToString();
                    Instalment1.Visible= true;

                }
                else
                {
                    MessageBox.Show("Data Not found");
                }
                con1.Close();
            }
        }

        private void ViewAllData_Load(object sender, EventArgs e)
        {
            // Set up the AutoComplete feature
            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteCustomSource = suggestions;

            // Load suggestions from database
            SqlConnection con2 = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd2 = new SqlCommand("SELECT CustomerId, CustomerName, interest, principal, years, monthlyPayment, monthlyIncome, eligibility, typeofLoan FROM Table_LoanCal WHERE CustomerName=@CustomerName", con2);
            cmd2.Parameters.AddWithValue("@CustomerName", textBox1.Text);
            con2.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                suggestions.Add(reader2["CustomerName"].ToString());
            }
            reader2.Close();
            con2.Close();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filter suggestions based on user input
            textBox1.AutoCompleteCustomSource.Clear();
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT CustomerId, CustomerName, interest, principal, years, monthlyPayment, monthlyIncome, eligibility, typeofLoan FROM Table_LoanCal WHERE CustomerName LIKE @input", con);
            cmd.Parameters.AddWithValue("@input", textBox1.Text + "%");
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.AutoCompleteCustomSource.Add(reader["CustomerName"].ToString());
                cusId1.Text = reader["CustomerId"].ToString();
                cusName1.Text = reader["CustomerName"].ToString();
                monthlyIncome1.Text = reader["monthlyIncome"].ToString();
                eligibility1.Text = reader["eligibility"].ToString();
                eligibility1.Visible = true;
                principal1.Text = reader["principal"].ToString();
                interest1.Text = reader["interest"].ToString();
                years1.Text = reader["years"].ToString();
                loantype2.Text = reader["typeofLoan"].ToString();
                Instalment1.Text = reader["monthlyPayment"].ToString();
                Instalment1.Visible = true;
            }
            reader.Close();

            // Get the amortization data for the selected customer
            SqlCommand cmd2 = new SqlCommand("SELECT Data FROM View_data WHERE CustomerId=@CustomerId", con);
            cmd2.Parameters.AddWithValue("@CustomerId", cusId1.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                listBox1.Items.Add(reader2["Data"].ToString());
            }
            reader2.Close();

            con.Close();
        }



        private void delete1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Select a Customer");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM View_data WHERE CustomerId=@CustomerId", con);                
                    cmd2.Parameters.AddWithValue("@CustomerId", cusId1.Text);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Table_LoanCal WHERE CustomerId=@CustomerId", con);
                    cmd.Parameters.AddWithValue("@CustomerId", cusId1.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record deleted successfully!");
                }
            }
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Select a Customer");
                return;
            }
              // Get the data for the selected customer
              SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Loan_Calculator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
              SqlCommand cmd = new SqlCommand("SELECT * FROM Table_LoanCal WHERE CustomerName=@CustomerName", con);
              cmd.Parameters.AddWithValue("@CustomerName", textBox1.Text);
              con.Open();
              SqlDataReader reader = cmd.ExecuteReader();
              if (reader.Read())
              {
                  // Pass the data to the edit form and open it
                  EditCustomerForm editForm = new EditCustomerForm();
                  editForm.CustomerId = reader["CustomerId"].ToString();
                  editForm.CustomerName = reader["CustomerName"].ToString();
                 // editForm.MonthlyIncome = reader["monthlyIncome"].ToString();
                 // editForm.Eligibility = reader["eligibility"].ToString();
                 // editForm.Principal = reader["principal"].ToString();
                 // editForm.Interest = reader["interest"].ToString();
                 // editForm.Years = reader["years"].ToString();
                 // editForm.MonthlyPayment = reader["monthlyPayment"].ToString();
                 // editForm.loantypev1 = reader["typeofLoan"].ToString();
                  editForm.ShowDialog();
              }
              reader.Close();
              con.Close();
          
           // EditCustomerForm editForm = new EditCustomerForm();
            //editForm.ShowDialog();
        }

        private void ViewAllData_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Have you found what you want?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void eligibility1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
