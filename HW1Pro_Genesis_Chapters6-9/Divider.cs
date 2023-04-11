public static class Divider
{   
    static char dividerSymbol = '*';
    static string dividerLine = new string(dividerSymbol, 25);

    public static void WriteDivider()
    {
        Console.WriteLine(dividerLine);
        Console.WriteLine();
    }
}
