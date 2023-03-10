class Title
{
    string? _content;

    public string Content
    {
        get => (_content != null) ? _content : "Заголовок відсутній.";
        set { _content = value; }
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Content);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
