using HomeWork.Interfaces;

/// <summary> Represent interface for managing contacts </summary>
public interface IManageable
{
    /// <summary> Creates contact </summary>
    void Create(IContact contact);

    /// <summary> Removes contacts </summary>
    /// <returns>If contact has been removed returns true</returns>
    bool Remove(int id);

    /// <summary> Gets contact by id </summary>
    /// <returns>If contact didn't find returns null</returns>
    IContact GetById(int id);

    /// <summary> Gets contact by name </summary>
    /// <returns>If contact didn't find returns null</returns>
    IEnumerable<IContact> GetByName(string name);

    /// <summary> Gets contact by phoneNumber </summary>
    /// <returns>If contact didn't find returns null</returns>
    IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);

    /// <summary> Updates contact </summary>
    void Update(IContact contact);
}