using HW13Delegates;

internal class Program
{
    private static void Main(string[] args)
    {
        var contactProvider = new InMemoryContactProvider();
        var contactBook = new ContactStore(contactProvider);

        contactBook.Create
        (
            new Contact
            {
                Id = 1,
                Name = "Oleksandr",
                PhoneNumber = "0123456789"
            }
        );
        contactBook.Create
        (
            new Contact
            {
                Id = 2,
                Name = "NeOleksandr",
                PhoneNumber = "9876543210"
            }
        );

        foreach (var conact in contactBook)
        {
            Console.WriteLine(conact);
        }
    }
}