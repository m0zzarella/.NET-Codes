using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IManager
    {
        string AssignTask(string taskname, int empNo);
        int approveLeave(int days, bool isApproved, int empNo);
        string GetEmployeeDetails(int empNo);

    }
}
