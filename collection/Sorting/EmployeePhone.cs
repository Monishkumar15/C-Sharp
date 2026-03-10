using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class EmployeePhone : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if (e1 == null || e2 == null) return 0;

            if (e1.EPhone < e2.EPhone)
                return -1;
            else if (e1.EPhone > e2.EPhone)
                return 1;
            return 0;
        }
    }
}
