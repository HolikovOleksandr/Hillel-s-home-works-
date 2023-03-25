using HW13Delegates;

internal class Program
{
    static string divider = new string('*', 20);

    static void Main(string[] args)
    {
        InMemoryContactProvider contactProvider = new InMemoryContactProvider();
        ContactStore contactBook = new ContactStore(contactProvider);

        contactBook.Create(new Contact { Id = 1, Name = "Oleksandr", PhoneNumber = "0983891691" });
        contactBook.Create(new Contact { Id = 2, Name = "Olha", PhoneNumber = "0500863359" });

        var menu = new Menu();
        var form = new Form();

        bool showMenu = true;
        while (showMenu)
        {
            menu.Show();
            var option = menu.FillOption();
            Console.Clear();
            
            try
            {
                switch (option)
                {
                    case "1":
                        {
                            foreach (var contact in contactBook)
                            {
                                Console.WriteLine(contact);
                            }
                            Console.WriteLine(divider);
                        }
                        break;
                    case "2":
                        {
                            var contact = form.FillContact();
                            contactBook.Create(contact);
                            Console.WriteLine($"Contact {contact} was created");
                            Console.WriteLine(divider);
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Id for delete: ");
                            var contactById = form.FillId();

                            foreach (var contact in contactBook)
                            {
                                if (contact.Id == contactById)
                                {
                                    contactBook.Remove(contactById);
                                }
                            }
                        }
                        break;
                    case "4":
                        {
                            showMenu = false;
                        }
                        break;
                }
            }
            catch (DeniedOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops... Something went wrong!");
            }
        }
    }
}