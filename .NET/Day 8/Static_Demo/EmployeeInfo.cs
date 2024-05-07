using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Demo
{
    internal abstract class EmployeeInfo
    {
        static int sv_empID = 2023000;
        public string empNo { get; set; }
        public string empName { get; set; }

        public string empDesg { get; set; }

        public EmployeeInfo(string p_empName, string p_empDesg)
        {
            //empNo = p_empNo;
            empName = p_empName;
            empDesg = p_empDesg;
            sv_empID ++;
            empNo = (p_empDesg.Substring(0,2) + sv_empID).ToUpper();
            
        }
    }
}
