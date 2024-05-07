using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Demo
{
    internal class Developer: EmployeeInfo
    {
        static int sv_autoNumDev = 900;
        public Developer(string p_empName, string p_empDesg) : base(p_empName, p_empDesg)
        {
            sv_autoNumDev++;
            empNo = (p_empDesg.Substring(0, 2) + sv_autoNumDev).ToUpper();
        }
    }
}
