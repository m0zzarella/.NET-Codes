using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementOOPS
{
    internal abstract class EmployeeInfo
    {
        public int availableLeaves { get; set; }

        public virtual double applyLeaves (int noDays)
        {
            availableLeaves -= noDays;
            return availableLeaves;
        }
    }
}
