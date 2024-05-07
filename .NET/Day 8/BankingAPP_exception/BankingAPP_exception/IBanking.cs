using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_exception
{
    internal interface IBanking
    {
        public double Withdraw(int amount);
        public double Deposit (int amount);
    }
}
