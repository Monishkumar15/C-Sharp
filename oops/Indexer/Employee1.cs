using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Employee1
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;

        public Employee1()
        {

        }

        public Employee1(int Eno, string Ename, string Job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
        }

        //Indexer
        public Object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return Eno;
                else if (name.ToUpper() == "ENAME")
                    return Ename;
                else if (name.ToUpper() == "JOB")
                    return Job;
                else if (name.ToUpper() == "SALARY")
                    return Salary;
                else if (name.ToUpper() == "DNAME")
                    return Dname;
                else if (name.ToUpper() == "LOCATION")
                    return Location;
                return null;
            }
            set
            {
                if (name.ToLower() == "eno")
                    Eno = Convert.ToInt32(value);
                else if (name.ToLower() == "ename")
                    Ename = value.ToString();
                else if (name.ToLower() == "job")
                    Job = value.ToString();
                else if (name.ToLower() == "salary")
                    Salary = Convert.ToDouble(value);
                else if (name.ToLower() == "dname")
                    Dname = value.ToString();
                else if (name.ToLower() == "location")
                    Location = value.ToString();
            }
        }
        public override string ToString()
        {
            return $"[Eno:{this.Eno} , Ename:{this.Ename}, Job:{this.Job}, Salary:{this.Salary}, Dname:{this.Dname}, Location:{this.Location}]";
        }
    }
}
