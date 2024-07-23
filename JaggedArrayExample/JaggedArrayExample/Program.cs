public class JaggedArrayExample
{
    public static void Main()
    {
        // Define a jagged array to store student scores in different subjects
        int[][] studentScores = new int[3][];

        // Assign scores for each student (different number of subjects for each student)
        studentScores[0] = new int[] { 90, 85, 92 }; // Student 1 has scores in 3 subjects
        studentScores[1] = new int[] { 78, 88 };    // Student 2 has scores in 2 subjects
        studentScores[2] = new int[] { 95, 91, 87, 89 }; // Student 3 has scores in 4 subjects

        // Display student scores
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.Write("Student " + (i + 1) + " scores: ");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

}