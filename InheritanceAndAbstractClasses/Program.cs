using System;

namespace InheritanceAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Part 1 *****");

            Employee bart = new Employee(1234, "Bart", "Simpson", 25000);
            Developer lisa = new Developer(5678, "Lisa", "Simpson", 35000, "C#");
            Manager waylon = new Manager(1, "Waylon", "Smithers", 50000, "All");

            decimal bartSalaryInfo = bart.AnnualSalary;
            decimal lisaSalaryInfo = lisa.AnnualSalary;

            Console.WriteLine($"Bart's salary: {bartSalaryInfo}");
            Console.WriteLine($"Lisa's salary: {lisaSalaryInfo}");

            Console.WriteLine("\n");

            Console.WriteLine(bart.GetEmployeeInfo("\n"));
            Console.WriteLine("\n");
            Console.WriteLine(lisa.GetEmployeeInfo("\n"));
            Console.WriteLine("\n");
            Console.WriteLine(waylon.GetEmployeeInfo("\n"));

            Console.WriteLine("\n\n***** Part 2 *****");

            Square redSquare = new Square("Red", 3);
            Rectangle greenRectangle = new Rectangle("Green", 3, 4);
            Circle pinkCircle = new Circle("Pink", 4);

            Console.WriteLine($"Square info:\nColour: {redSquare.Colour}\nArea: {redSquare.Area}");
            Console.WriteLine($"\nRectangle info:\nColour: {greenRectangle.Colour}\nArea: {greenRectangle.Area}");
            Console.WriteLine($"\nCircle info:\nColour: {pinkCircle.Colour}\nArea: {pinkCircle.Area}");
        }
    }
}
