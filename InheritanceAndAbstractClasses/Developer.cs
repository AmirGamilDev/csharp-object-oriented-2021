using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Developer : Employee
    {
        public string PrimaryProgramingLanguage { get; set; }

        public Developer(int employeeId, string firstName, string lastName, decimal annualSalary,
            string primaryProgrammingLanguage) : base(employeeId, firstName, lastName, annualSalary)
        {
            this.PrimaryProgramingLanguage = primaryProgrammingLanguage;
        }

        public override string GetEmployeeInfo(string sep)
        {
            return base.GetEmployeeInfo(sep) + $"{sep}Primary Programming Language: {PrimaryProgramingLanguage}";
        }
    }
}
