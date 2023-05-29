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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label3.Text = $" With a current account you get \r\n easy access to your money for \r\n day-to-day expenses. Depending on \r\n your income bracket, you'll \r\n receive a particular card. If you're \r\n looking for a basic start-up account,\r\n we'd recommend a current account.";//displays information on a current account
            label4.Text = $" With a savings account, you can \r\n keep your savings separate from \r\n your everyday bank account. By using\r\n a savings account, you'll\r\n earn interest on the amount you save \r\n every month. If you're looking to earn\r\n interest on your monthly savings,but still\r\n want automatic access to your \r\n savings, we'd recommend a \r\n savings account.";//displays information on a savings account
            label5.Text = $" When opening a fixed deposit, you \r\n earn more interest the longer \r\n you save! With a fixed deposit, you \r\n can only access your money after\r\n giving a certain amount of days notice.\r\n If you're looking to earn maximum \r\n interest on your savings, we'd \r\n recommend a fixed deposit.";//displays information on a fixed deposit
        }
    }
}
