using HomeWork.Interfaces;

public class Contact : IContact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString() => $"{Id}, {Name}, {PhoneNumber}";
}
