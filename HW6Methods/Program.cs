class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello. Please enter the first integer: ");
        string? firstInput = Console.ReadLine();
        int firstValue = int.Parse(firstInput);

        Console.WriteLine("Hello. Please enter the second integer: ");
        string? secondInput = Console.ReadLine();
        int secondValue = int.Parse(secondInput);

        Console.WriteLine("What we wil do with those integers?");
        Console.WriteLine("Press +, -, *, / or ^");
        char @operator = char.Parse(Console.ReadLine());
        
        if (@operator == '+'
            || @operator == '-'
            || @operator == '*'
            || @operator == '/'
            || @operator == '^')
        {

            switch (@operator)
            {
                case '+':
                    {
                        Console.WriteLine(Addition(firstValue, secondValue));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(Subtraction(firstValue, secondValue));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(Multiplication(firstValue, secondValue));
                        break;
                    }
                case '/':
                    {
                        if (secondValue == 0) Console.WriteLine("I can`t divide by zero");
                        else Console.WriteLine(Division(firstValue, secondValue));
                        break;
                    }
                case '^':
                    {
                        Console.WriteLine(Exponentiation(firstValue, secondValue));
                        break;
                    }
            }
        }
        else Console.WriteLine("I don't know this operation");

        Console.WriteLine("Press any button for close program");
        Console.ReadKey();
    }

    // Case +
    static int Addition(int firstValue, int secondValue) => firstValue + secondValue;

    // Case -
    static int Subtraction(int firstValue, int secondValue) => firstValue - secondValue;

    // Case *
    static int Multiplication(int firstValue, int secondValue) => firstValue * secondValue;

    // Case /
    static int Division(int firstValue, int secondValue) => firstValue / secondValue;

    //Case ^
    static int Exponentiation(int firstValue, int secondValue)
    {
        int result = 1;
        for (int i = 0; i < secondValue; i++) result *= secondValue;
        return result;
    }
}