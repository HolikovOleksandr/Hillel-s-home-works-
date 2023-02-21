class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. Please enter the first integer: ");
        string? firstInput = Console.ReadLine();
        int firstValue = int.Parse(firstInput);

        Console.WriteLine("And second integer: ");
        string? secondInput = Console.ReadLine();
        int secondValue = int.Parse(secondInput);

        Console.WriteLine("What we wil do with those integers?");
        Console.WriteLine("Press +, -, *, / or ^");
        char @operator = char.Parse(Console.ReadLine());

        int answer = 0;
        if (@operator == '+') answer = Addition(firstValue, secondValue);
        if (@operator == '-') answer = Subtraction(firstValue, secondValue);
        if (@operator == '*') answer = Multiplication(firstValue, secondValue);
        if (@operator == '^') answer = Exponentiation(firstValue, secondValue);
        if (@operator == '/')
        {
            if (secondValue == 0) Console.WriteLine("I can`t divide by zero");
            else answer = Division(firstValue, secondValue);
        }
        Console.WriteLine($"Answer is: {answer}");

        Console.WriteLine("Press any button for close program");
        Console.ReadKey();
    }

    static int Addition(int firstValue, int secondValue) => firstValue + secondValue;
    static int Subtraction(int firstValue, int secondValue) => firstValue - secondValue;
    static int Multiplication(int firstValue, int secondValue) => firstValue * secondValue;
    static int Division(int firstValue, int secondValue) => firstValue / secondValue;
    static int Exponentiation(int firstValue, int secondValue)
    {
        int result = 1;
        for (int i = 0; i < secondValue; i++) result *= secondValue;
        return result;
    }
}