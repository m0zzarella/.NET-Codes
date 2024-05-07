using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Manager : IManager
    {
        public string empName { get; set; }
        public string empId { get; set; }
        public bool isApproved { get; set; }

        public int approveLeave(int days, bool isApproved, int empNo)
        {
            Console.WriteLine("Leave Status Updated");
            
            return empNo;
            //throw new NotImplementedException();
        }

        public string AssignTask(string taskname, int empNo)
        {
            Console.WriteLine("Task Assigned");
            return "Successful";
            //throw new NotImplementedException();
        }

        public string GetEmployeeDetails(int empNo)
        {
            throw new NotImplementedException();
        }

        //public int AddNewEmployee(string newEmpName)
        //{
        //    throw new NotImplementedException();
        //}

        //public int approveLeave(int days, bool isApproved, int empNo)
        //{
        //    throw new NotImplementedException();
        //}

        //public string AssignTask(string taskname, int empNo)
        //{
        //    throw new NotImplementedException();
        //}

        //public int DeleteEmployee(int empNo)
        //{
        //    Console.WriteLine("Employee Deleted");
        //    return empNo;
        //}

        //public string GetEmployeeDetails(int empNo)
        //{
        //    Console.WriteLine("details are: "); Console.WriteLine(empNo);
        //    return empName;
        //}

        //public int UpdateEmployee(int empNo, string newName)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
