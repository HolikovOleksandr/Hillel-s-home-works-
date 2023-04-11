using HomeWork.Interfaces;

public class PersistentContactProvider : IContactSaveable, IContactProvider
{
    /// <summary> Reads text from a file and converts it into a collection of contacts </summary>
    /// <returns>List of contacts</returns>
    public IEnumerable<IContact> Get()
    {
        var contacts = new List<IContact>();
    
        try
        {
            using (StreamReader file = new StreamReader("contacts.txt"))
            {
                string line;
                while ((line = file.ReadLine()!) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        int id = int.Parse(parts[0].Trim().Substring(7));
                        string name = parts[1].Trim().Substring(5);
                        string phone = parts[2].Trim().Substring(7);

                        contacts.Add(new Contact { Id = id, Name = name, PhoneNumber = phone, });
                    }
                }
            }
            return contacts;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading contacts: " + ex.Message);
            return null;
        }
    }


    /// <summary> Saves a collection of contacts to a file </summary>
    /// <param name="items">List of contacts</param>
    public bool Save(IEnumerable<IContact> items)
    {
        try
        {
            using (StreamWriter file = new StreamWriter("contacts.txt"))
            {
                foreach (IContact contact in items)
                {
                    file.WriteLine($"Id: {contact.Id},\tName: {contact.Name},\tPhone: {contact.PhoneNumber},");
                }
            }
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving contacts: " + ex.Message);
            return false;
        }
    }

}
