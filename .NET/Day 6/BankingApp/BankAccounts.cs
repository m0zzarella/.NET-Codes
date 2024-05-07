using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BankAccounts
{
    internal class BankAccounts
    {   //normal way of initializing variables  

        #region Previous property Initialization
        //int v_accNo;
        //string v_accName;
        //string v_accType;
        //double v_accBalance;
        //bool v_empIsPermenant;

        //public int accNo
        //{
        //    get { return v_accNo; }
        //    set { v_accNo = value; }
        //}
        //public string accName
        //{
        //    get { return v_accName; }
        //    set { v_accName = value; }
        //}

        //public string accType
        //{
        //    get { return v_accType; }
        //    set { v_accType = value; }
        //}

        //public double accBalance
        //{  get { return v_accBalance; }
        //    set { v_accBalance = value; } 
        //}
        //bool accIsActive;
        #endregion



        #region Properties
        public int accNo { get; set; }
        public string accName { get; set; }
        public string accType { get; set; }
        public double accBalance { get; set; }
        public bool accIsActive { get; set; }
        #endregion

        //methods

        public double Withdraw(int amount)
        {
            accBalance -= amount;
            return accBalance;
        }

        public double Deposit(int amount)
        {
            accBalance += amount;
            return accBalance;
        }


    }
}
