using HW13Delegates;

internal class Program
{
    static InMemoryContactProvider contactProvider = new InMemoryContactProvider();
    static ContactStore contactBook = new ContactStore(contactProvider);
    static string divider = new string('*', 20);

    static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu) showMenu = MainMenu();
    }

    private static bool MainMenu()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Show contacts"); // Done
        Console.WriteLine("2) Add contact"); // Done
        Console.WriteLine("3) Remove contact by Id");
        Console.WriteLine("4) Exit"); // Done
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
                Show(contactBook);
                return true;
            case "2":
                NewContact(contactBook);
                return true;
            case "3":

                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }

    /// <summary> Create contact from user input </summary>
    static ContactStore NewContact(ContactStore contacts)
    {
        int id = 0;

        Console.WriteLine("Name: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Phone: ");
        string? phone = Console.ReadLine();

        var contact = new Contact
        {
            Id = id,
            Name = name,
            PhoneNumber = phone
        };

        contactBook.Create(contact);
        return contactBook;
    }

    /// <summary> Write to console each contacts from conact book </summary>
    static void Show(ContactStore contacts)
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact.ToString());
            Console.WriteLine(divider);
        }
    }

    /// <summary> Remove contact by ID </summary>
    static ContactStore RemoveContact()
    {
        Console.WriteLine("Id for delete: ");
        string? id = Console.ReadLine();
        bool tryParceId = int.TryParse(id, out int result);

        foreach (var contact in contactBook)
        {
            if (contact.Id == result) contactBook.Remove(result);
        }

        return contactBook;
    }
}