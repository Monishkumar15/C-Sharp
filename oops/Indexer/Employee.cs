using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public Employee()
        {

        }

        public Employee(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
        }

        //Indexer
        public Object this[int index]
        {
            get 
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
            }
            set
            {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)
                    Job = (string)value;
                else if (index == 3)
                    Salary = (double)value;
                else if (index == 4)
                    Dname = (string)value;
                else if(index == 5)
                    Location = (string)value;
            }
        }
        public override string ToString()
        {
            return $"Employee: [Eno:{this.Eno} , Ename:{this.Ename}, Job:{this.Job}, Salary:{this.Salary}, Dname:{this.Dname}, Location:{this.Location}]";
        }

    }
}
