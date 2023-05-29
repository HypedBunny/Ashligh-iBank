using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Bank___Student_Bank__iBSB_
{
    public partial class Form4 : Form
    {
        Employee employee = new Employee();
        Customer customer = new Customer();

        public Form4()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string accNumber = txtAccNumber.Text;
            bool foundMatch = false;

            foreach (Customer customer in employee.customerList)
            {
                if (customer.AccNumber.Equals(accNumber))
                {
                    this.Hide();
                    Form5 form5 = new Form5(customer.initialDeposit);
                    form5.Show();
                    foundMatch = true;
                    break; //if a customer logs in with an account number and it matches with one of the account numbers stored in the customerList, the form5 opens
                }
            }

            if (!foundMatch)
            {
                MessageBox.Show("Invalid account number. Please try again or sign up for an account.");//if the accountNumber is not found, this messageBox opens
            }
        }
    }
}
