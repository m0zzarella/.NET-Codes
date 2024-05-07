using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement
{
    internal abstract class InsuranceInfo
    {
        public int age { get; set; }
        public double InsuranceValue {  get; set; }

        public InsuranceInfo (int p_age, double p_InsuranceValue)
        {
            age = p_age;
            InsuranceValue = p_InsuranceValue;
        }

        public virtual double CalculateRenewalPremium (int age, double insuranceValue)
        {
            return insuranceValue;
        }
    }
}
