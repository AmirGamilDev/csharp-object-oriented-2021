using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(int employeeId, string firstName, string lastName, decimal annualSalary,
            string department) : base(employeeId, firstName, lastName, annualSalary)
        {
            this.Department = department;
        }

        public override string GetEmployeeInfo(string sep)
        {
            return base.GetEmployeeInfo(sep) + $"{sep}Department: {Department}";
        }
    }
}
