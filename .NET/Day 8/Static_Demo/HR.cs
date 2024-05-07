using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Demo
{
    internal class HR : EmployeeInfo
    {
        static int sv_autoNumHR = 100;
        public HR(string p_empName, string p_empDesg): base(p_empName, p_empDesg)
        {
            sv_autoNumHR++;
            empNo = (p_empDesg.Substring(0,2) + sv_autoNumHR).ToUpper();
            
        }
    }
}
