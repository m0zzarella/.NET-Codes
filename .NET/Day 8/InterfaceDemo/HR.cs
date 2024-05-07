using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class HR : IHR
    {
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
        //    throw new NotImplementedException();
        //}

        //public string GetEmployeeDetails(int empNo)
        //{
        //    throw new NotImplementedException();
        //}

        //public int UpdateEmployee(int empNo, string newName)
        //{
        //    throw new NotImplementedException();
        //}
        public int AddNewEmployee(string newEmpName)
        {
            Console.WriteLine("Add Employee Succesful!");
            return 1;
            //throw new NotImplementedException();
        }

        public int DeleteEmployee(int empNo)
        {
            Console.WriteLine("Delete Employee Succesful!");
            return empNo;
            throw new NotImplementedException();
        }

        public int UpdateEmployee(int empNo, string newName)
        {
            Console.WriteLine("Update Employee Succesful!");
            return empNo;
            throw new NotImplementedException();
        }
    }
}
