using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp_OOPs
{
    internal class Savings : BankAccount
    {
        public Savings(int p_accNo, string p_accFirstName, string p_accLastName, double p_accBalance, bool p_accIsActive) : base(p_accNo, p_accFirstName, p_accLastName, p_accBalance, p_accIsActive)
        {

        }
    }
}
