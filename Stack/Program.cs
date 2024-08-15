using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a stack
        Stack<int> stack = new Stack<int>();

        // Pushing elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Popping elements from the stack
        int poppedItem = stack.Pop(); // Removes and returns 3
        Console.WriteLine("Popped item: " + poppedItem);

        // Peeking at the top item without removing it
        int topItem = stack.Peek(); // Returns 2
        Console.WriteLine("Top item: " + topItem);

        // Checking if the stack is empty
        bool isEmpty = (stack.Count == 0);

        // Iterating through the stack
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
