using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SortedDictionary for a bookstore's inventory
            SortedDictionary<string, decimal> bookstoreInventory = new SortedDictionary<string, decimal>();

            // Add some books (ISBN as key, price as value)
            bookstoreInventory.Add("978-3-16-148410-0", 29.99m);  // Book 1
            bookstoreInventory.Add("978-0-262-13472-9", 39.99m);  // Book 2
            bookstoreInventory.Add("978-1-4028-9462-6", 19.99m);  // Book 3

            // Display sorted inventory
            foreach (var book in bookstoreInventory)
            {
                Console.WriteLine($"ISBN: {book.Key}, Price: R{book.Value}");
            }
            Console.ReadKey();
        }
    }
}
