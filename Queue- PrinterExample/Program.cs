using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<PrintJob> printerQueue = new Queue<PrintJob>();

        Console.WriteLine("Printer Queue Simulation");

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add print job to queue");
            Console.WriteLine("2. Print job");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter job name: ");
                        string jobName = Console.ReadLine();
                        printerQueue.Enqueue(new PrintJob(jobName));
                        Console.WriteLine($"{jobName} added to the queue.");
                        break;
                    case 2:
                        if (printerQueue.Count > 0)
                        {
                            PrintJob nextJob = printerQueue.Dequeue();
                            Console.WriteLine($"Printing: {nextJob.Name}");
                        }
                        else
                        {
                            Console.WriteLine("No jobs in the queue.");
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

class PrintJob
{
    public string Name { get; }

    public PrintJob(string name)
    {
        Name = name;
    }
}
