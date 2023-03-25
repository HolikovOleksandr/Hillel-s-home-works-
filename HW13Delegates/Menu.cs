using System.Text;

public class Menu
{
    const string CONTENT = "1. Show contacts\n2. Create new contact\n3. Delete contact by id\n4. Exit";
    const string ASK_OPTION = "Enter option";

    public void Show()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine(CONTENT);
    }

    public string FillOption()
    {
        Console.WriteLine(ASK_OPTION);
        var option = Console.ReadLine();
        return option!;
    }
}
