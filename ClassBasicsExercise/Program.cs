using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasicsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bart = new Student(1234, "Bart", "Simpson", 'J');
            Student lisa = new Student(5678, "Lisa", "Simpon", 'M');

            string bartStudentInfo = bart.GetStudentInfo();
            string lisaStudentInfo = lisa.GetStudentInfo();

            Console.WriteLine(bartStudentInfo);
            Console.WriteLine(lisaStudentInfo);

            // using setter of LastName property
            lisa.LastName = "Simpson";

            // using getter of FullName property
            Console.WriteLine("Lisa's full name: " + lisa.FullName);

            Console.WriteLine(lisa.MiddleInitial);
            lisa.MiddleInitial = 'S';
            Console.WriteLine(lisa.MiddleInitial);
        }
    }
}
