using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace I_Bank___Student_Bank__iBSB_
{
    internal class Customer
    {
        private string _Fname;
        private string _Lname;
        private double _deposit;
        private string _accType;
        private double _withdraw;
        private string _accNumber;
        private double _balance;
        private double _initialDeposit;//objects of the class

       

        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }           
        }

        public string Lname
        {
            get { return _Lname; }
            set { _Lname = value; }
        }

        public double Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }         
        }

        public string AccType
        {
            get { return _accType; }
            set { _accType = value; }
        }

        public double Withdraw
        { 
            get { return _withdraw; }
            set { _withdraw = value; }
        }

        public string AccNumber
        { 
            get { return _accNumber; }
            set { _accNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public double initialDeposit
        {
            get { return _initialDeposit; }
            set { _initialDeposit = value; }
        }

        public Customer()
        {
        }

        public double ShowBalance(double initialDeposit, double deposit, double withdraw)
        {
            if (initialDeposit > 0)
            {
                _balance += initialDeposit;
            }

            if (deposit > 0)
            {
                _balance += deposit;
            }

            if (withdraw > 0)
            {
                _balance -= withdraw;
            }

            this._deposit = deposit;
            this._withdraw = withdraw;
            return _balance; //method to get the updated balance
        }

        public Customer(string fName, string lName, string accNumber, String accType, double balance) //parameterized constructor
        {
            this._Fname = fName;
            this._Lname = lName;
            this._accType = accType;
            this._accNumber = accNumber;
            this._balance = balance;
        }

        public override string ToString() 
        {
            return $"{_Fname} \t {_Lname} \t {_accNumber} \t {_accType} \t {_balance}";
        }



    }
}
