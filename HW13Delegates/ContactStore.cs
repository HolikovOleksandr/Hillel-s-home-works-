using HomeWork.Interfaces;

namespace HW13Delegates
{
    public class ContactStore : BaseContactStore
    {
        public ContactStore(IContactProvider contactProvider) : base(contactProvider) { }

        public override IContact GetById(int id)
        {
            IContact? contactById = null;

            foreach (var contact in _contacts)
                if (contact.Id == id) contactById = contact;

            return contactById!;
        }

        public override IEnumerable<IContact> GetByName(string name)
        {
            var list = new List<IContact>();

            foreach (var contact in _contacts)
                if (contact.Name == name) list.Add(contact);

            return list;
        }

        public override IEnumerable<IContact> GetByPhoneNumber(string phoneNumber)
        {
            var list = new List<IContact>();

            foreach (var contact in _contacts)
                if (contact.PhoneNumber == phoneNumber) list.Add(contact);

            return list;
        }

        public override void Create(IContact contact)
        {
            try
            {
                foreach (var item in _contacts)
                {
                    if (item.Name != contact.Name)
                    {
                        _contacts.Add(contact);
                        break;
                    }
                }
            }
            catch (DeniedOperationException e)
            {
                Exception exception = new DeniedOperationException($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
                Console.WriteLine(e.Message);
            }
        }

        public override bool Remove(int id)
        {
            IContact? contactById = null;

            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    return _contacts.Remove(contact);
                }
                else
                {
                    try
                    {
                        if (contactById.Id != id) ;
                    }
                    catch (DeniedOperationException e)
                    {
                        Exception exception = new DeniedOperationException($"Contact with {nameof(id)} {contactById.Id} is not exists");
                        Console.WriteLine(e.Message); ;
                    }
                }
            }
        }

        public override void Update(IContact contact)
        {
            IContact? contactToUpdate = null;

            foreach (var search in _contacts)
                if (search.Id == contact.Id) contactToUpdate = contact;

            contactToUpdate!.Name = contact.Name;
            contactToUpdate.PhoneNumber = contact.PhoneNumber;
        }
    }
}














// try
// {
//     foreach (var contact in _contacts)
//     {
//         if (contact.Id == id)
//         {
//             contactById = contact;
//             return _contacts.Remove(contact);
//         }
//     }
// }
// catch (DeniedOperationException e) when (id != contactById?.Id)
// {
//     Console.WriteLine(e.Message);
//     throw new DeniedOperationException($"Contact with {nameof(id)} {contactById?.Id} is not exists");
// }
