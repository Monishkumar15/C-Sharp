using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Employee : IComparable<Employee>
    {
        public Employee() { }
        public Employee(int EId, string EName, string EDepartment, long EPhone, string EAddress)
        {
            this.EId = EId;
            this.EName = EName;
            this.EDepartment = EDepartment;
            this.EPhone = EPhone;
            this.EAddress = EAddress;
        }
        public int EId{ get; set; }
        public string EName { get; set; }
        public string EDepartment { get; set; }
        public long EPhone { get; set; }
        public string EAddress { get; set; }

        public int CompareTo(Employee e)
        {
            if (e.EId < this.EId)
                return 1;
            else if(e.EId > this.EId)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            return $"Employee: [EId: {this.EId}, EName:{this.EName}, EDepartment: {this.EDepartment}, EPhone: {this.EPhone}, EAddress: {this.EAddress} ]";
        }
    }
}
