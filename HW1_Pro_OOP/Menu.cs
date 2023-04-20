/// <summary>Static class-helper for user interaction with the program</summary>
public static class Menu
{
    static string divider = new string('#', 20);

    /// <summary>Greets the user and asks him for the first value to convert</summary>
    public static void SayHelloAndStart()
    {
        Console.WriteLine();
        Console.WriteLine(divider);
        Console.WriteLine("Hi! Lest`s some convert? :)");
        Console.WriteLine("Select the number of unit and hit <Enter>");
        ShowAllUnits();
    }

    /// <summary>
    /// Receives from the console the number corresponding to the unit
    /// of extinction that is planned to be converted
    /// </summary>
    public static Unit AskFirstUnit()
    {
        var answer = int.Parse(Console.ReadLine()!);
        var itemsLength = Enum.GetValues(typeof(Units)).Length;

        if (answer > itemsLength || answer < 0)
            throw new IndexOutOfRangeException("Invalid number.");
        else
            return Unit.GetUnit((Units)answer);
    }

    /// <summary>
    /// Asks the user how many units they wish to convert 
    /// and reads that amounfrom the console
    /// </summary>
    public static double AskValue()
    {
        Console.WriteLine();
        Console.WriteLine(divider);

        Console.WriteLine("How much of the selected unit you want to convert?");
        var answer = double.Parse(Console.ReadLine()!);

        Console.WriteLine();
        
        return answer;
    }

    /// <summary>Asks the user for the final unit of conversion</summary>
    public static Units AskPendingUnit()
    {
        Console.WriteLine(divider);
        Console.WriteLine("Choose pending unit and hit <Enter>");

        ShowAllUnits();

        var answer = int.Parse(Console.ReadLine()!);
        var itemsLength = Enum.GetValues(typeof(Units)).Length;

        if (answer > itemsLength || answer < 0)
            throw new IndexOutOfRangeException("Invalid number.");
        else
            return (Units)answer;
    }

    /// <summary>Converts one value to another, taking into account the quantity</summary>
    /// <param name="firstUnit">Base unit for convert</param>
    /// <param name="pendingUnit">Final unit</param>
    /// <param name="value">Number of base unit</param>
    public static void ConvertAndPrint(Unit firstUnit, Units pendingUnit, double value)
    {
        Console.WriteLine();
        Console.WriteLine(divider);

        double result = firstUnit.ConvertUnitTo(pendingUnit, value);
        Console.WriteLine($"{value} {firstUnit} = {result} {pendingUnit}");

        Console.WriteLine();
    }

    /// <summary>Output a list of units that can be converted to the console</summary>
    private static void ShowAllUnits()
    {
        int number = 0;
        var units = (Units[])Enum.GetValues(typeof(Units));

        Console.WriteLine();
        foreach (var unit in units)
            Console.WriteLine($"{number++} — {unit}");
    }
}