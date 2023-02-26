internal class Program
{
    static int n;

    private static void Main(string[] args)
    {

        Console.WriteLine("Enter the number: ");
        n = int.Parse(Console.ReadLine());

        string result;
        if (n <= -1) result = "Неприпустиме значення аргументу";
        else result = SumTo(n).ToString();

        Console.WriteLine(result);

        Console.WriteLine("Press any key to exit the program");
        Console.ReadKey();
    }

    static int SumTo(int n)
    {
        return n = (n == 0 || n == 1) ? 1 : n + SumTo(n - 1);
    }
}