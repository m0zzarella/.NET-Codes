using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee
    {
        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermanent { get; set; }
        #endregion

        #region Methods
        public double CalculateBonus (double percentage)
        { double bonus = (percentage*empSalary / 100);
            return bonus;
        }

        public void changeDesignation (string designation) 
        {
            empDesignation = designation;
           
        }
        #endregion

        //parameterized constructor
        public Employee(int p_empNo, string p_empName, string p_empDesignation, double p_empSalary, bool p_empIsPermanent)
        { empNo = p_empNo;
            empName = p_empName;
            empDesignation = p_empDesignation;
            empSalary = p_empSalary;
            empIsPermanent = p_empIsPermanent;


        }


    }
}
