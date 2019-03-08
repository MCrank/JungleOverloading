using JungleOverloading.Employees;
using System;
using System.Collections.Generic;

namespace JungleOverloading
{
    class Program
    {
        public static List<Employee> Employees { get; private set; } = new List<Employee>();

        //public List<Employee> Employees { get; set; } = new List<Employee>();

        static void Main(string[] args)
        {
            Employee marco = new Employee("Marco", "Crank");
            Employee shane = new Employee("Shane", "Wilson");
            Employee maggie = new Employee("Maggie", "Leavell");

            Employees.Add(marco);
            Employees.Add(shane);
            Employees.Add(maggie);

            Console.WriteLine("\n*** Overload #1 ****");
            marco.Eat();

            Console.WriteLine("\n*** Overload #2 ****");
            marco.Eat("Pizza");

            Console.WriteLine("\n*** Overload #3 ****");
            marco.Eat(Employees);

            Console.WriteLine("\n*** Overload #4 ****");
            marco.Eat("Tacos", Employees);

            Console.ReadLine();

        }
    }
}
