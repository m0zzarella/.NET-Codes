using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    internal class Savings
    {
        public string WhoAmI()
        {
            return "I am a Savings account";
        }
    }
    internal class Current
    {
        public string WhoAmI()
        {
            return "I am a Current account";
        }
    }
    internal class PF
    {
        public string WhoAmI()
        {
            return "I am a PF account";
        }
    }
}

namespace Investment
{
    internal class FD
    {
        public string WhoAmI()
        {
            return "I am a FD account";
        }
    }
    internal class GOLD
    {
        public string WhoAmI()
        {
            return "I am a GOLD account";
        }
    }
    internal class MutualFunds
    {
        public string WhoAmI()
        {
            return "I am a MutualFunds  account";
        }
    }
    internal class Equity
    {
        public string WhoAmI()
        {
            return "I am a Equity account";
        }

    }
}

namespace Transaction
{
    internal class Transfer
    {
        public string WhoAmI()
        {
            return "I am a Transfer  account";
        }
    }
    internal class Deposit
    {
        public string WhoAmI()
        {
            return "I am a Deposit account";
        }
    }
    internal class Withdraw
    {
        public string WhoAmI()
        {
            return "I am a Withdraw account";
        }
    }
    internal class Billpay
    {
        public string WhoAmI()
        {
            return "I am a Billpay account";
        }

    }
}

namespace Services
{
    internal class Request
    {
        public string WhoAmI()
        {
            return "I am Request Option";
        }
    }
    internal class CallBack
    {
        public string WhoAmI()
        {
            return "I am CallBack Option";
        }
    }
    internal class UpgradeAccount
    {
        public string WhoAmI()
        {
            return "I am UpgradeAccount Option";
        }
    }
}
