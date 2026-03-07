using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Companies : IEnumerable<Employee>
    {
        private List<Employee> employees = new List<Employee>(2);

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

        //IEnumerable<Employee> (generic).
        public IEnumerator<Employee> GetEnumerator()
        {
            return employees.GetEnumerator();
        }

        //non-generic IEnumerable.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
