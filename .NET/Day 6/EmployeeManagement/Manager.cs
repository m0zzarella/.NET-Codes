using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Manager  : Employee 
    {
        public Manager(int p_empNo, string p_empName, string p_empDesignation, double p_empSalary, bool p_empIsPermanent) :base(p_empNo, p_empName, p_empDesignation, p_empSalary, p_empIsPermanent)
        {

        }
    }
}
