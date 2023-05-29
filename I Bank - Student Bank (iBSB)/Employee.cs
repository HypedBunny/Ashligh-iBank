using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Bank___Student_Bank__iBSB_
{
    internal class Employee
    {
        public List<Customer> customerList = new List<Customer>();


        public void ToListbox(ListBox listBox) //method to add each customer in the customerList to a Listbox
        {
            listBox.Items.Add($"First Name \t Surname \t Account Number \t Account Type \t Deposit Amount \r\n");
            foreach (Customer customer in customerList)
            {
                listBox.Items.Add(customer.ToString());
            }
        }
    }
}
