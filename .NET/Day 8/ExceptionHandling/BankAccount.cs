using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class BankAccount
    {
        public int accBalance { get; set; }

        public BankAccount(int p_accBalance) 
        {
            accBalance = p_accBalance;
        }
         public double Deposit (int amount)
        {  if (amount < 0)
                throw new Exception("Deposit Number Cannot Be Zero!");
            accBalance += amount;
            return accBalance;
        }
        public double Withdraw (int amount) 
        {
            accBalance -= amount;
            return accBalance;
        }
    }
}
