using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.WriteLine("Initial List:");
            list.PrintList();

            Console.ReadKey();
        }
    }
}
