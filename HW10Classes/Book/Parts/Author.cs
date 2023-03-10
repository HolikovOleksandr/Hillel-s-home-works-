class Author
{
    private string? _name;

    public string Name
    {
        get => (_name != null) ? _name : "Ім'я автора відсутнє.";
        set { _name = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Name);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}