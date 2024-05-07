using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_OOPS
{
    internal class Current : BankAccount
    {
        public override double Withdraw(double amount)
        {
            if (amount > 100000)
                throw new Exception("Error: You can withdraw max 100,000");
           
            //same as parent class
            //accBalance -= amount;
            //return accBalance;
            return base.Withdraw(amount);

        }
    }
}
