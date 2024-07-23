class StudentScoresProgram
{
    static void Main(string[] args)
    {
        // Array to store student information (3 students and 3 subjects)
        string[,] studentData = new string[3, 4]; 
        // 3 students, 4 columns (Name, Math score, English score, Science score)

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Name of student " + (i + 1) + ":");
            studentData[i, 0] = Console.ReadLine();// Get User Name

            Console.WriteLine("Enter Math score for " + studentData[i, 0] + ":");
            studentData[i, 1] = Console.ReadLine();

            Console.WriteLine("Enter English score for " + studentData[i, 0] + ":");
            studentData[i, 2] = Console.ReadLine();

            Console.WriteLine("Enter Science score for " + studentData[i, 0] + ":");
            studentData[i, 3] = Console.ReadLine();
        }

        // Display student information
        Console.WriteLine("\nStudent Information:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Name: " + studentData[i, 0]);
            Console.WriteLine("Math Score: " + studentData[i, 1]);
            Console.WriteLine("English Score: " + studentData[i, 2]);
            Console.WriteLine("Science Score: " + studentData[i, 3]);
            Console.WriteLine("-----------------------");
        }
    }
}
