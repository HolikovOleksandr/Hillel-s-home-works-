internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello! Write symbol and press ENTER: ");
        char symbol = char.Parse(Console.ReadLine());

        Console.WriteLine("Hello! Write ONLY odd number and press ENTER: ");
        int triangleWidth = int.Parse(Console.ReadLine());

        char[,] array = DrawTriangleInDoubleArray(triangleWidth, symbol);
        PrintArrayInConsole(array);

        Console.WriteLine("Press any key for leave from program");
        Console.Read();
    }

    /// <summary>
    /// Create char[,] array and saved them triangle of symbols;
    /// </summary>
    /// <param name="triangleWidth">Conut of symbols in triangle last row</param>
    /// <param name="symbol">Symbol for drawing triangle</param>
    /// <returns>char[,] array</returns>
    static char[,] DrawTriangleInDoubleArray(int triangleWidth, char symbol)
    {
        int size;
        if (triangleWidth % 2 == 1) size = triangleWidth;
        else size = triangleWidth++;

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
    /// Function writed in console char`s double array
    /// </summary>
    /// <param name="array">Array to be drawn</param>
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