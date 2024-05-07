using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Demo
{
    internal class Manager : EmployeeInfo
    {
        static int sv_autoNumMan = 500;
        public Manager(string p_empName, string p_empDesg) : base(p_empName, p_empDesg)
        {
            sv_autoNumMan++;
            empNo = (p_empDesg.Substring(0, 2) + sv_autoNumMan).ToUpper();
        }
    }
}
