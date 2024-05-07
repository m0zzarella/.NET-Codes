using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_OOPS
{
    internal class Savings : BankAccount
    {
        public override double Withdraw(double amount)
        {
            if (amount > 20000)
                throw new Exception("Error- You can withdraw max 20,000");
            if (amount > accBalance)
                throw new Exception("Insufficient Balance!");
            //same as parent class
            //accBalance -= amount;
            //return accBalance;
            return base.Withdraw(amount);

        }
    }
}
