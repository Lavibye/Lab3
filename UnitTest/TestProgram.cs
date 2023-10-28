using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace UnitTest
{
    class Program
    {
        static void Main()
        {
            Bird[] birds = new Bird[]
            {
            new Sparrow { Name = "Sparrow1", L = 500 },
            new Sparrow { Name = "Sparrow2", L = 1000 },
            new Crow { Name = "Crow1", L = 100 },
            new Crow { Name = "Crow2", L = 200 },
            new Sparrow { Name = "Sparrow3", L = 1500 }
            };

            foreach (var bird in birds)
            {
                if (bird is Sparrow sparrow)
                {
                    Console.WriteLine($"Name: {sparrow.Name}, L: {sparrow.L}, FoodRequired: {sparrow.FoodRequired}");
                }
                else if (bird is Crow crow)
                {
                    Console.WriteLine($"Name: {crow.Name}, L: {crow.L}, Height: {crow.Height}");
                }
            }
        }
    }

}
