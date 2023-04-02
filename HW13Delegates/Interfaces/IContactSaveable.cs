using HomeWork.Interfaces;

public interface IContactSaveable
{
    /// <summary> Saves contacts to any storage </summary>
    bool Save(IEnumerable<IContact> items);
}
