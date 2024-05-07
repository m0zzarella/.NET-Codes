using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementOOPS
{
    internal class Manager : EmployeeInfo
    {
        public override double applyLeaves(int noDays)
        {
            if (availableLeaves < 0)
                throw new Exception("No leaves left!");
            if (noDays < 1)
                throw new Exception("Error: Applied no. of days cannot be less than 1 ");

            if (noDays > 4) throw new Exception("Error: Manager can only apply for max 4 days at a stretch!");
            return base.applyLeaves(noDays);
        }
    }
}
