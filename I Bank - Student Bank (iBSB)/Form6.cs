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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label3.Text = $" In 2017 Tiffany Grey, a former UCT business student, was tasked with creating a brand which fulfilled a need in everyday life. \r\n Tiffany decided to create an online banking application focused on students' needs. She recognized the lack of student banking options across South Africa,\r\n and felt that creating a brand that places students as their main priority would fulfill an everyday need. That brand is known today as I Bank Student Banking (iBSB). \r\n iBSB is tailored to provide students with an affordable, streamlined banking experience. iBSB's immediate focus is building a relationship with students to \r\n understand their needs and goals better and empower them to take control of their money."; //displays information on how the I Bank business started
            label4.Text = $" I Banks goals are to empower students toreach their financial goals, to ensure a bright future with financial freedom. \r\n We aim to assist all our customers in helping them grow their money tree and maintain healthy spending habits. iBSB offers financial tips and tricks to students on \r\n a daily basis to promote money saving. We also allow student to create their own personal rewards schema which works in tandem with their schooling/university schedules. \r\n Overall, our goals are to highlight the importance of healthy spending habits during a time when we often find ourselves overspending on nonessentials"; //displays information on I Bank's goals
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
