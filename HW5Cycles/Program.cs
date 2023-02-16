public class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Write symbol and press ENTER: ");
        // char _symbol = char.Parse(Console.ReadLine());
        char _symbol = '*';

        // Console.WriteLine("Write stroke count and press ENTER: ");
        // int _strokeCount = int.Parse(Console.ReadLine());
        int _strokeCount = 5;


        for (int i = 0; i < _strokeCount; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(_symbol);
                
                while (j == _strokeCount)
                {
                    for (int k = _strokeCount - 1; k > 0; k--) Console.Write(_symbol);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

        }

        Console.WriteLine("Press any key for leave from program");
        Console.Read();
    }
}