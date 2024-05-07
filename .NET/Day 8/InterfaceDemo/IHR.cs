using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IHR
    {
        int AddNewEmployee(string newEmpName);
        int UpdateEmployee(int empNo, string newName);
        int DeleteEmployee(int empNo);
    }
}
