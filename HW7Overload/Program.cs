internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Add(7, 3)); // Int
        Console.WriteLine(Add(6.5, 3.5)); // Double
        Console.WriteLine(Add("6.5", "3.5")); // String

        Console.WriteLine("Press any key to exit the program");
        Console.ReadKey();
    }

    static int Add(int a, int b) => a + b; // Int
    static double Add(double a, double b) => a + b; // Double
    static string Add(string a, string b) // String
    {
        bool successfulParce;
        double aDouble;
        double bDouble;
        double result;

        successfulParce = double.TryParse(a, out aDouble);
        successfulParce = double.TryParse(b, out bDouble);

        result = aDouble + bDouble;
        return result.ToString();
    }
}