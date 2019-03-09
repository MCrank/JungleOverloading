using System;
using System.Collections.Generic;

namespace JungleOverloading.Employees
{
    class Employee
    {
        static Random rnd = new Random();

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<string> _restaurants = new List<string> { "Jimmy Johns", "Oscar's Tacos", "Jets Pizza", "J Alexanders" };

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private string GetRandomRestaurant()
        {
            int rando = rnd.Next(_restaurants.Count);
            return _restaurants[rando];
        }

        public void Eat()
        {
            var randomRestaurant = GetRandomRestaurant();
            Console.WriteLine($"I am currently at {randomRestaurant} geeting my grub on!");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I ate {food} in the office");
        }

        public void Eat(List<Employee> companions)
        {
            Eat();
            foreach (var employee in companions)
            {
                if (employee.FirstName.ToLower().Contains("marco") && employee.LastName.ToLower().Contains("crank"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{employee.FirstName} is with me.");
                }
            }
        }

        public void Eat(string food, List<Employee> companions)
        {
            Console.WriteLine($"I am eating {food}");
            Eat(companions);
        }
    }
}
