using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_OOPS
{
    internal abstract class BankAccount
    {
        public double accBalance { get; set; }

        //savings can withdraw max 20000, Current can withdraw at max 100000
        //savings can only withdraw from balance
        public virtual double Withdraw (double amount)
        {
            accBalance -= amount;
            return accBalance;
        }

        public double Deposit (double amount)
        {
            accBalance += amount;
            return accBalance;
        }

        public string Greet ()
        {
            return "Hello and Welcome!";
        }
    }
}
