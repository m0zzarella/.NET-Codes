using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_exception
{
    internal class Savings : BankAccount
    {

        public Savings(int p_accNo, string p_accName, double p_accBalance):base(p_accNo, p_accName, p_accBalance)
        {
            
        }
        public override double Withdraw(int amount)
        {
            if (amount > 20000) 
            {
                throw new Exception("You cannot withdraw more than 20K in a transaction");
            }

            return base.Withdraw(amount);
        }
    }
}
