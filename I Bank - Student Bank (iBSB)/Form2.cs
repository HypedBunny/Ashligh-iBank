using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace I_Bank___Student_Bank__iBSB_
{
    public partial class Form2 : Form
    {
        Customer customer = new Customer();
        Employee employee = new Employee(); //creates an instance of the classes
        List<string> AccType = new List<string>();
        string accNumber;
        string gender;
        int numAcc;
        Random randomNumber = new Random();
        string nonVowels;
        int custNum;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AccType.Add("Current Account");
            AccType.Add("Savings Account");
            AccType.Add("Fixed Deposit"); //adds the various accTypes to the list

            foreach (string s in AccType)
            {
                lstAccType.Items.Add(s); //items are added to a specific listBox
            }

            accNumber = "";
            gender = null;
            numAcc = 0;
            randomNumber = new Random(); //new random number is generated whenever this form loads
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFname.Text) || string.IsNullOrEmpty(txtLname.Text))
                {
                    throw new ArgumentException("Please enter your first and last name.");
                }

                double initialDeposit;

                if (!double.TryParse(txtInitialDeposit.Text, out initialDeposit))
                {
                    throw new ArgumentException("Please enter a valid initial deposit amount.");
                }

                if (lstAccType.SelectedItem == null)
                {
                    throw new ArgumentException("Please select an account type.");//various exception handling
                }

                Customer newCustomer = new Customer(txtFname.Text, txtLname.Text, accNumber, lstAccType.SelectedItem.ToString(), Convert.ToDouble(txtInitialDeposit.Text)); //on button click, a new instance of a customer is created with the parameters
                employee.customerList.Add(newCustomer); //the new customer is added to the customerList

                customer.Lname = txtLname.Text.ToUpper();
                customer.Fname = txtFname.Text.ToUpper();
                customer.initialDeposit = Convert.ToDouble(txtInitialDeposit.Text);
                customer.AccType = lstAccType.SelectedItem.ToString();

                nonVowels = "";


                custNum = randomNumber.Next(1, 100); // random number between 1 and 99 is generated, which goes at the end of the accNumber

                for (int i = 0; i < customer.Lname.Length && nonVowels.Length < 2; i++)
                {
                    if ("AEIOU".IndexOf(customer.Lname[i]) < 0)
                    {
                        nonVowels += customer.Lname[i]; //takes the first two consonants from the customers last name
                    }
                }

                string firstName = customer.Fname.Substring(0, Math.Min(customer.Fname.Length, 3)); //takes the first three letters of the customers first name

                string accNumberName = $"{char.ToUpper(customer.Lname[0])}{nonVowels}{firstName}"; //strings together the first letter of the customers last name, the two consonants from their last name, and the first three letters of their first name


                if (rdFemale.Checked)
                {
                    gender += "01F";
                }
                else if (rdMale.Checked)
                {
                    gender += "02M";
                }
                else if (rdNeutral.Checked)
                {
                    gender += "03N"; //based on the customers gender this part of their accNumber varies
                }

                if (lstAccType.SelectedItem.ToString() == "Current Account")
                {
                    numAcc += 123;
                }
                else if (lstAccType.SelectedItem.ToString() == "Savings Account")
                {
                    numAcc += 456;
                }
                else if (lstAccType.SelectedItem.ToString() == "Fixed Deposit")
                {
                    numAcc += 789; //based on the selected accType, this part of their accNumber varies
                }
                else
                {
                    throw new ArgumentException("Invalid account type");//exception handling
                }

                accNumber = $"{accNumberName}{gender}{numAcc}{custNum}"; //strings together all the different parts of the constructed accNumber
                customer.AccNumber = accNumber; 

                MessageBox.Show($"Thank you for confirming your details, {customer.Fname} {customer.Lname}! \r\n\r\n You have selected the {customer.AccType} and your initial deposit which will activate this account is R{customer.initialDeposit}. \r\n\r\n YOUR GENERATE ACCOUNT NUMBER IS:   {customer.AccNumber} \r\n (Please take note and remember this account number, as it is the key to accessing your account). \r\n\r\n Thank you for choosing I Bank, we look forward to giving you a rewarding online banking experince!", "Account Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirms thatthe account has been opened, and shows the customers geenrated accNumber

                
                Form5 form5 = new Form5(customer.initialDeposit);
                form5.Show();
                this.Close();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred \r\n {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//exception handling
        }

        private void lstAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();//opens form4
            this.Close();
        }
    }
}
