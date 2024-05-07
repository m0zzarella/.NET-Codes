using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP_exception
{
    internal abstract class BankAccount : IBanking
    {

        public int accNo { get; set; }
        public string accName { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }


        public BankAccount(int p_accNo, string p_accName, double p_accBalance)
        { 
            if(p_accName.Length < 3)
            {
                throw new Exception("Account Not Created, Name should be minimum 3 characters");
            }
            else if(p_accBalance < 500)
            {
                throw new Exception("Account Not Created, We need minimum 500rs to open a new account");
            }
            accNo = p_accNo;
            accName = p_accName;
            accBalance = p_accBalance;
            accIsActive =true;

        }
       

        public virtual double Withdraw(int amount)
        {
            if(amount < 0) 
            {
                throw new Exception("You cannot withdraw a negaive amount");
            }
            else if(amount > 0 && amount < 100) 
            {
                throw new Exception("You need to withdraw minimum 100rs");
            }
            else 
            {
                accBalance = accBalance + amount;
                return accBalance; 
            }
        }

        public double Deposit(int amount)
        {
            if(amount < 0) 
            {
                throw new Exception("Please enter an amount more than 100");
            }
            accBalance = accBalance - amount;
                return accBalance;
        }

  
    }
}
