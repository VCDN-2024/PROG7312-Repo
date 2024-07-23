namespace StudentResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create and initialize a 2D array to store results
            int[,] results = {//Comma indicates this is a multi dimensional array
            { 85, 90, 88 }, // Grades for Student 1
            { 78, 82, 91 }, // Grades for Student 2
            { 92, 87, 84 }, // Grades for Student 3
            { 88, 91, 89 }, // Grades for Student 4
            { 76, 85, 90 }  // Grades for Student 5
        };
            //or
            //results[0, 0] = 85; results[0, 1] = 90; results[0, 2] = 88; // Student 1
            //results[1, 0] = 78; results[1, 1] = 82; results[1, 2] = 91; // Student 2
            //results[2, 0] = 92; results[2, 1] = 87; results[2, 2] = 84; // Student 3
            //results[3, 0] = 88; results[3, 1] = 91; results[3, 2] = 89; // Student 4
            //results[4, 0] = 76; results[4, 1] = 85; results[4, 2] = 90; // Student 5




            // 2. Display results
            Console.WriteLine("Student Results:");
            PrintResults(results);

            // 3. Calculate and display average grades for each student
            Console.WriteLine("\nAverage Grades for Each Student:");
            CalculateStudentAverages(results);

            // 4. Calculate and display average grades for each subject
            Console.WriteLine("\nAverage Grades for Each Subject:");
            CalculateSubjectAverages(results);
        }

        // Method to print the results
        static void PrintResults(int[,] results)
        {
            int students = results.GetLength(0);
            int subjects = results.GetLength(1);

            for (int i = 0; i < students; i++)
            {
                Console.Write("Student " + (i + 1) + ": ");
                for (int j = 0; j < subjects; j++)
                {
                    Console.Write(results[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Method to calculate and print average grades for each student
        static void CalculateStudentAverages(int[,] results)
        {
            int students = results.GetLength(0);
            int subjects = results.GetLength(1);

            for (int i = 0; i < students; i++)
            {
                int sum = 0;
                for (int j = 0; j < subjects; j++)
                {
                    sum += results[i, j];
                }
                double average = (double)sum / subjects;
                Console.WriteLine("Student " + (i + 1) + " Average: " + average);
            }
        }

        // Method to calculate and print average grades for each subject
        static void CalculateSubjectAverages(int[,] results)
        {
            int students = results.GetLength(0);
            int subjects = results.GetLength(1);

            for (int j = 0; j < subjects; j++)
            {
                int sum = 0;
                for (int i = 0; i < students; i++)
                {
                    sum += results[i, j];
                }
                double average = (double)sum / students;
                Console.WriteLine("Subject " + (j + 1) + " Average: " + average);
            }
        }
    }
    
}
