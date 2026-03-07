using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Company
    {

        private Employee[] employees = new Employee[10];

        public Employee this[int index] {
            get
            {
                return employees[index];
            }set
            {
                employees[index] = value;
            }
        }


        public Employee[] Employees
        {
            get {  return employees; }
        }

    }
}
