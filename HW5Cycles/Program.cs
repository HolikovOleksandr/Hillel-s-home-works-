public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Write symbol and press ENTER: ");
        char _symbol = char.Parse(Console.ReadLine());

        Console.WriteLine("Hello! Write number and press ENTER: ");
        int _number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= _number; i++)
        {
            for (int j = 1; j <= _number - i; j++) Console.Write(" ");
            for (int j = 1; j <= 2 * i - 1; j++) Console.Write(_symbol);
            Console.WriteLine();
        }

        // for (int i = _number - 1; i >= 1; i--)
        // {
        //     for (int j = 1; j <= _number - i; j++) Console.Write(" ");
        //     for (int j = 1; j <= 2 * i - 1; j++) Console.Write(_symbol);
        //     Console.WriteLine();
        // }

        Console.WriteLine("Press any key for leave from program");
        Console.Read();
    }
}