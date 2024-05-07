using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_OOPs
{
    internal abstract class BankAccount
    {
        #region Properties
        public int accNo { get; set; }

        public string accFirstName  { get; set; }
        public string accLastName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        #endregion

        #region Methods
       public void Withdraw(double amount)
        {
            accBalance -= amount;

        }

        public void Deposit (double amount)
        {
            accBalance += amount;
        }
        #endregion

        //parameterized constructor
        public BankAccount(int p_accNo, string p_accFirstName, string p_accLastName, double p_accBalance, bool p_accIsActive) 
        { accNo = p_accNo;
          accFirstName = p_accFirstName;
          accLastName = p_accLastName;
          accBalance = p_accBalance;
          accIsActive = p_accIsActive;
        }

    }
}
