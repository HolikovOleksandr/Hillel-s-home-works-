public class Library
{
    Book[]? _books = null;

    /// <summary> Returns books count </summary>
    public int BooksCount
    {
        get => Books.Length;
    }

    /// <summary> Fills library by default programmers' books </summary>
    public void FillLibrary()
    {
        _books = new Book[]
        {
            new Book("CLR via C#") { Author = "Jeffrey Richter" },
            new Book("Code Complete") { Author = "Steve McConnell" },
            new Book("Windows Runtime Via C#") { Author = "Jeffrey Richter" },
        };
    }

    /// <summary> Find only one book by start title text </summary>
    public Book? FindBookByTitle(string bookTitle)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Title.StartsWith(bookTitle)) return Books[i];
        }

        return null;
    }

    /// <summary> Find set of books by start author name text </summary>
    public Book[] FindBooksByAuthor(string authorName)
    {
        int arraySize = 0;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Author.StartsWith(authorName)) arraySize++;
        }

        var resultArray = new Book[arraySize];
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Author.StartsWith(authorName))
            {
                resultArray[--arraySize] = Books[i];
            }
        }

        return resultArray;
    }

    Book[] Books
    {
        get => (_books == null) ? new Book[0] : _books;
    }
}