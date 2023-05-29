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
    public partial class Form5 : Form
    {
        Customer customer = new Customer();
        Employee employee = new Employee();
        double deposit;
        double withdraw;
        double balance;


        public Form5(double initialDeposit)
        {
            InitializeComponent();
            customer = new Customer();
            txtBalance.Text = initialDeposit.ToString();
            double balance = customer.ShowBalance(initialDeposit, deposit, withdraw);
            txtBalance.Text = balance.ToString();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtBalance.Text = Convert.ToString(balance);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Double.TryParse(txtDeposit.Text, out deposit))
                {
                    throw new ArgumentException("Please enter a valid deposit amount.");//exception handling
                }

                if (!Double.TryParse(txtWithdraw.Text, out withdraw))
                {
                    throw new ArgumentException("Please enter a valid withdrawal amount.");//excpetion handling
                }

                balance = customer.ShowBalance(customer.initialDeposit, deposit, withdraw);
                txtBalance.Text = balance.ToString();

                if (balance - withdraw  < 0)
                {
                    MessageBox.Show("You cannot make another withdrawal until you deposit enough money to make your balance greater than zero.", "Balance below Zero"); //if a customer withdraws moeny which puts their balance below zero, this messagebox shows
                }

                if (balance < 0)
                {
                    MessageBox.Show(" Please make a deposit before withdrawing more money as you have less than R0.00 in your account");//if the user attempts to make another withdrawl whilst their balance is below zero, this messagebox shows and they are unable to make a withdrawl
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");//exception handling
            }
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();  //displays the print preview
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = $"Customer Summary \r\n\r\n Name: {customer.Fname} {customer.Lname} \r\n Account Number: {customer.AccNumber} \r\n Deposit Amount: {customer.Deposit}"; //what displays on the page
            Font printFont = new System.Drawing.Font
            ("Arial", 35, System.Drawing.FontStyle.Regular); //formatting

            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);  //draws the string onto the page
        }
    }
}
