namespace HomeWork.Interfaces;

/// <summary> Represents contact model </summary>
public interface IContact : IIdentity
{       
    string Name { get; set; }
    string PhoneNumber { get; set; }
}