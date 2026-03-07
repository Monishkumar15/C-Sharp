using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Office
    {
        private List<Employee> employees = new List<Employee>();

        public Employee this[int index]
        {
            get { return employees[index]; }
            set
            {
                if (index < employees.Count)
                    employees[index] = value;
                else
                    employees.Add(value);
            }
        }

        public List<Employee> Employees => employees;
    }
}
