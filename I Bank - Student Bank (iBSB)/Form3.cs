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
    public partial class Form3 : Form
    {
        Customer customer = new Customer();
        Employee employee = new Employee();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RefreshData();         
        }

        private void lstReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            double totalDeposits = 0;

            foreach (Customer customer in employee.customerList)
            {
                totalDeposits += customer.initialDeposit - customer.Withdraw + customer.Deposit;//adds all customer deposits together
            }
            label3.Text = DateTime.Now.ToString("dd.MM.yyy"); //displays the current date without the time
            employee.ToListbox(lstReport);     //calls the ToListbox method and passes it to the lstReports list displayed in this form
            label4.Text = $"Today we opened {lstReport.Items.Count - 1} accounts with a total of R{totalDeposits}"; //displays the number of new accounts, and the totalDeposits
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshData();//refreshes each day, to show daily reports
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();  //displays the print preview
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = $"Report for {label3.Text} \r\n\r\n"; //what displays on the page
            Font printFont = new System.Drawing.Font
            ("Arial", 35, System.Drawing.FontStyle.Regular); //formatting
            foreach(Customer customer in lstReport.Items)
            {
                text += customer + "\n";//displays each customer in the list on a new line
            }
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);  //draws the string onto the page
        }
    }
}
