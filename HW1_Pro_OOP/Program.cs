public class Program
{
    public static bool showMenu = true;

    static void Main()
    {
        while (showMenu)
        {
            Menu.SayHelloAndStart();

            var firstUnit = Menu.AskFirstUnit();
            var value = Menu.AskValue();
            var pendingUnit = Menu.AskPendingUnit();

            Menu.ConvertAndPrint(firstUnit, pendingUnit, value);
        }
    }
}