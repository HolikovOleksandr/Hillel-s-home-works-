using HomeWork.Interfaces;

/// <summary> Provides contact collection </summary>
public interface IContactProvider
{
    /// <summary> Gets contacts <see cref="IEnumerable{IContact}"/> </summary>
    IEnumerable<IContact> Get();
}