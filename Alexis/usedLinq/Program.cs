using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usedLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            var distinctNumbers = numbers.Distinct();

            Console.WriteLine("Números distintos:");
            foreach (var num in distinctNumbers)
            {
                Console.WriteLine(num);
            }

            List<string> fruits = new List<string> { "apple", "banana", "apple", "cherry", "banana", "date" };
            var distinctFruits = fruits.Distinct();

            Console.WriteLine("\nFrutas distintas:");
            foreach (var fruit in distinctFruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
