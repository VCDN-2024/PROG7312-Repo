using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public double Mark { get; set; }

    public Student(int id, string name, string subject, double mark)
    {
        ID = id;
        Name = name;
        Subject = subject;
        Mark = mark;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Subject: {Subject}, Mark: {Mark}";
    }
}

class Program
{
    static void Main()
    {
        SortedDictionary<int, Student> studentDictionary = new SortedDictionary<int, Student>();

        // Add student information to the sorted dictionary.
        studentDictionary.Add(10123, new Student(10123, "John", "Math", 88.5));
        studentDictionary.Add(10223, new Student(10223, "Brock", "Science", 55.0));
        studentDictionary.Add(10323, new Student(10323, "Mysterio", "Science", 45.5));
        studentDictionary.Add(10623, new Student(10623, "Bob", "Science", 65.0));

        // Display the sorted list of students and their information based on IDs.
        Console.WriteLine("Student Information:");
        foreach (var kvp in studentDictionary)
        {
            Console.WriteLine(kvp.Value);
        }

        

        // LINQ query for Search for students with a specific subject (e.g., "Science").
        string searchSubject = "Science";

        var studentsWithSubject = studentDictionary.Values.Where(student => student.Subject == searchSubject);

        Console.WriteLine($"\nStudents with Subject '{searchSubject}':");
        foreach (var student in studentsWithSubject)
        {
            Console.WriteLine(student);
        }

        // LINQ query to sort students by marks in descending order.
        var sortedStudents = studentDictionary.Values.OrderByDescending(student => student.Mark);
       
        Console.WriteLine("\nStudents Sorted by Marks (Descending Order):");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

    }
}
