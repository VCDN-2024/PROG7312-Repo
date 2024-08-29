using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a queue
        Queue<int> queue = new Queue<int>();

        // Enqueuing elements into the queue
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Dequeuing elements from the queue
        int dequeuedItem = queue.Dequeue(); // Removes and returns 1
        Console.WriteLine("Dequeued item: " + dequeuedItem);

        // Peeking at the front item without removing it
        int frontItem = queue.Peek(); // Returns 2
        Console.WriteLine("Front item: " + frontItem);

        // Checking if the queue is empty
        bool isEmpty = (queue.Count == 0);

        // Iterating through the queue
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
