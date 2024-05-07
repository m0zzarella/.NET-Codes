using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankingSystem.Investment
{
    internal class Equity
    {
        public string BuyStock(int parameters, int stockID, double qty)
        {
            return "StockBuy Succesfull!";
        }
        public string SellStock(int parameters, int stockID, double qty)
        {
            return "StockSell Succesfull!";
        }

        public int GetInvenstmentValue()
        { return 0; }
    }
}
