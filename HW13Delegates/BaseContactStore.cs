using System.Collections;
using HomeWork.Interfaces;

/// <summary> Implements base functionality for contact store </summary>
public abstract class BaseContactStore : IEnumerable<IContact>, IManageable
{
    // ======================== IENUREBLE ===============================

    /// <summary> Provides source for contact collection </summary>
    private readonly IContactProvider _contactProvider;

    /// <summary> Contact collection </summary>
    protected List<IContact> _contacts;

    /// <summary> Creates base contact store with contact provider injected </summary>
    protected BaseContactStore(IContactProvider contactProvider)
    {
        _contactProvider = contactProvider;
        _contacts = _contactProvider.Get().ToList();
    }

    /// <summary> Enumerator for using collection in the foreach </summary>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary> Enumerator for using contact generic collection in the foreach </summary>
    public IEnumerator<IContact> GetEnumerator() => _contacts.GetEnumerator();

    // =====================================================================


    // ======================== IMANAGEABLE ================================

    public abstract void Create(IContact contact);

    public abstract void Update(IContact contact);

    public abstract bool Remove(int id);

    public abstract IContact GetById(int id);

    public abstract IEnumerable<IContact> GetByName(string name);

    public abstract IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);
    // =====================================================================
}