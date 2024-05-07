﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement
{
    internal class LifeInsurance : InsuranceInfo
    {
        public LifeInsurance(int p_age, double p_InsuranceValue) : base(p_age, p_InsuranceValue)
        {


        }
        public override double CalculateRenewalPremium(int age, double insuranceValue)
        {

            if (insuranceValue < 10000 || insuranceValue > 2000000)
                throw new Exception("Insurance value cannot be less than 10000 or more than 2000000");
          

            if (age >= 1 && age <= 30)
                insuranceValue = 0.08 * insuranceValue;
            if (age > 30 && age <= 60)
                insuranceValue = 0.2 * insuranceValue;
            if (age > 60 && age <= 75)
                insuranceValue = 0.4 * insuranceValue;
            if (age > 75)
                throw new Exception("Sorry cannot insure over age 75");
            return base.CalculateRenewalPremium(age, insuranceValue);
        }

    }
}