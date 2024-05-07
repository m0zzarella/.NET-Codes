using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBankingSystem.Services
{
    internal class BillPayService
    {

        public string PayElectricityBill(double amt)
        {
            return "Electricity Bill Paid";
        }

        public string PayGasBill(double amt)
        {
            return "Gas Bill Paid";
        }
    }
}
