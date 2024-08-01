using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList circularList = new CircularLinkedList();

            // Add nodes to the list
            circularList.AddToEnd(1);
            circularList.AddToEnd(2);
            circularList.AddToEnd(3);
            circularList.AddToEnd(4);

            Console.WriteLine("Circular Linked List:");
            circularList.PrintList();  // Print the list

            // Delete a node and print the list again
            circularList.DeleteNode(3);
            Console.WriteLine("List after deleting node with data 3:");
            circularList.PrintList();

            // Delete another node and print the list again
            circularList.DeleteNode(1);
            Console.WriteLine("List after deleting node with data 1:");
            circularList.PrintList();
            Console.ReadKey();
        }
    }
}
