public class Book
{
    Title? _title = null;
    Author? _author = null;

    public string Author
    {
        get => _author!.Name;
        set { _author!.Name = value; }
    }

    public string Title
    {
        get => _title!.Content;
        set { _title!.Content = value; }
    }

    public Book(string title)
    {
        InitializeBook();
        Title = title;
    }

    /// <summary> Wright title and author name for this book </summary> 
    public void InitializeBook()
    {
        this._author = new Author();
        this._title = new Title();
    }

    /// <summary> Wright author name and book`s title in console </summary>
    public void Show()
    {
        this._author!.Show();
        this._title!.Show();
    }
}
