using HomeWork.Interfaces;

namespace HW13Delegates
{
    public class ContactStore : BaseContactStore, INotifiable
    {
        public ContactStore(IContactProvider contactProvider) : base(contactProvider) { }
        
        public event SaveDelegate SaveEvent;

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
            var message = $"Contact with {nameof(contact.Name)} {contact.Name} is already exists";

            foreach (var existedContact in _contacts)
            {
                if (existedContact.Name == contact.Name)
                {
                    throw new DeniedOperationException(message);
                }

                _contacts.Add(contact);
            }

            SaveEvent.Invoke(_contacts);
        }

        public override bool Remove(int id)
        {
            var contactToRemove = GetById(id);
            var message = $"Contact with {nameof(id)} {contactToRemove.Id} is not exists";

            if (contactToRemove == null) throw new DeniedOperationException(message);
            return _contacts.Remove(contactToRemove);

            SaveEvent.Invoke(_contacts);
        }

        public override void Update(IContact contact)
        {
            IContact? contactToUpdate = null;

            foreach (var search in _contacts)
                if (search.Id == contact.Id) contactToUpdate = contact;

            contactToUpdate!.Name = contact.Name;
            contactToUpdate.PhoneNumber = contact.PhoneNumber;

            SaveEvent.Invoke(_contacts);
        }
    }
}