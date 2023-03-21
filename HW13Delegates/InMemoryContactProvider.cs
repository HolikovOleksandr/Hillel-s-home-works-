using HomeWork.Interfaces;

public class InMemoryContactProvider : IContactProvider
{
    public IEnumerable<IContact> Get() => new List<Contact>();
}
