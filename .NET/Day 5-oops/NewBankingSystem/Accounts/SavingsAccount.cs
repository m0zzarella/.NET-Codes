using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankingSystem.Accounts
{
	internal class SavingsAccount
	{

		public double Withdraw()
		{
			return 2000;

		}

		public double Deposit()
		{

			return 3000;

		}

		public double Transfer(int fromAcc, int toAcc)
		{

			double amt = fromAcc + toAcc;

			return amt;
		}

		public double checkBalance()
		{

			return 5000;
		}
	}
}
