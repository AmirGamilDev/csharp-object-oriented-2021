using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }

        public Employee(int employeeId, string firstName, string lastName, decimal annualSalary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = annualSalary;
        }

        public virtual string GetEmployeeInfo(string sep) =>
            $"Employee ID: {EmployeeId}{sep}First Name: {FirstName}{sep}Last Name: {LastName}{sep}Annual Salary: {AnnualSalary}";
    }
}
