using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class EmployeeSortBasedOnName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.EName.CompareTo(y.EName);
        }
    }
}
