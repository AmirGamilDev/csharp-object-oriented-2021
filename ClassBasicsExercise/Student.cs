using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasicsExercise
{
    class Student
    {
        private int studentId;
        private string firstName;
        private string lastName;
        private char middleInitial;

        public Student(int studentId, string firstName, string lastName, char middleInitial)
        {
            this.studentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleInitial = middleInitial;
        }

        public int StudentId
        {
            get { return studentId; }
        }

        public string FirstName
        {
            get { return firstName; }

            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }

            set { this.lastName = value; }
        }

        // example of auto-implemented property
        public char MiddleInitial { get; set; }

        public string FullName
        {
            get { return FirstName + " " + MiddleInitial + " " + LastName; }
        }

        public string GetStudentInfo()
        {
            return this.studentId + ", " + FullName;
        }
    }
}
