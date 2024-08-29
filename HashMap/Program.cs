using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Dictionary, which is a type of Hash Map in C#
            Dictionary<string, int> hashMap = new Dictionary<string, int>();

            // Adding key-value pairs
            hashMap.Add("apple", 50);
            hashMap.Add("banana", 30);
            hashMap.Add("cherry", 75);

            // Retrieving values
            int appleValue = hashMap["apple"];
            Console.WriteLine($"The value for 'apple' is: {appleValue}");

            // Checking if a key exists
            if (hashMap.ContainsKey("banana"))
            {
                Console.WriteLine("Banana is in the hash map.");
            }

            // Iterating over the hash map
            foreach (var kvp in hashMap)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
