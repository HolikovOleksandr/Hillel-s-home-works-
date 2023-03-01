internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello! Write symbol and press ENTER: ");
        char symbol = char.Parse(Console.ReadLine());

        Console.WriteLine("Write ONLY ODD number and press ENTER: ");
        int triangleWidth = int.Parse(Console.ReadLine());

        char[,] array = TriangleInTwoDimensionalArray(symbol, triangleWidth);
        PrintArrayInConsole(array);

        Console.WriteLine("Press any key for leave from program");
        Console.Read();
    }

    /// <summary>
    /// Creates a two dimensional char`s array and stores a triangle of characters there
    /// </summary>
    /// <param name="triangleWidth">The number of characters in the bottom line of the triangle</param>
    /// <param name="symbol">Symbol for drawing a triangle</param>
    /// <returns>Еwo dimensional char`s array</returns>
    static char[,] TriangleInTwoDimensionalArray(char symbol, int triangleWidth)
    {
        int size;
        if (triangleWidth % 2 == 1) size = triangleWidth;
        else size = triangleWidth + 1;

        char[,] array = new char[size, size];
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                array[i, j] = ' ';

        int center = size / 2;
        for (int i = 0; i <= center; i++)
            for (int j = center - i; j <= center + i; j++)
                array[i, j] = symbol;

        return array;
    }

    /// <summary>
    /// Outputs data from a two-dimensional array to the console
    /// </summary>
    /// <param name="array">An array to display in the console</param>
    static void PrintArrayInConsole(char[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++) 
                Console.Write(array[i, j]);

            Console.WriteLine();
        }
    }
}