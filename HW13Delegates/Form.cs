using HomeWork.Interfaces;

namespace HW13Delegates;
public class Form
{
    const string ASK_ID = "Enter Id";
    const string ASK_NAME = "Enter Name";
    const string ASK_PHONE = "Enter Phone number";

    public IContact FillContact()
    {
        var contact = new Contact();

        Console.WriteLine(ASK_ID);
        contact.Id = int.Parse(Console.ReadLine()!);

        Console.WriteLine(ASK_NAME);
        contact.Name = Console.ReadLine()!;

        Console.WriteLine(ASK_PHONE);
        contact.PhoneNumber = Console.ReadLine()!;

        return contact;
    }

    public int FillId()
    {
        Console.WriteLine(ASK_ID);
        var id = int.Parse(Console.ReadLine()!);

        return id;
    }
}
