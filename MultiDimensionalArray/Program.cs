namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a 3x3 Array
            int[,] mArray = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            // Print the Array
            Console.WriteLine("My Multi Dimensional Array:");
            for (int i = 0; i < mArray.GetLength(0); i++)
            {
                for (int j = 0; j < mArray.GetLength(1); j++)
                {
                    Console.Write(mArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
