using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_basics
{ internal class Leaves
    {

    }
    internal class Employee
    {      //by default private       - should be kept private
        int v_empNo;
        string v_empName;
        double v_empSalary;
        bool v_empIsPermanent;
        int v_empAge;

        public Employee() { 
        v_empNo = 101;
        v_empName = "Prayas";
        v_empSalary = 0;
        v_empIsPermanent = true;
        v_empAge = 22;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee no: " + v_empNo);
            Console.WriteLine("Employee name: " + v_empName);
            Console.WriteLine("Employee age: " + v_empAge);
            Console.WriteLine("Employee salary: " + v_empSalary);
            Console.WriteLine("Employee Is Permanent: " + v_empIsPermanent);



        }

        public void incrementSalary ()
        {
            DisplayEmployeeInfo();
            Console.WriteLine("Old Salary: " + v_empSalary);
            v_empSalary += 3000;
            Console.WriteLine("New Salary: " + v_empSalary);

        }
    }
}
