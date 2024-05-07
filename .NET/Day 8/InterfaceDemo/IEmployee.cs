using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IEmployee
    {
        //methods
        string GetEmployeeDetails(int empNo);
        int AddNewEmployee(string newEmpName);
        int UpdateEmployee(int empNo, string newName);
        int DeleteEmployee(int empNo);
        string AssignTask(string taskname, int empNo);
        int approveLeave(int days, bool isApproved, int empNo);

    }
}
