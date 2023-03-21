using HomeWork.Interfaces;

namespace HW13Delegates
{
    public class ContactStore : BaseContactStore
    {
        public ContactStore(IContactProvider contactProvider) : base(contactProvider) { }

        public override void Create(IContact contact) => _contacts.Add(contact);

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

        public override bool Remove(int id)
        {
            IContact? contactById = null;

            foreach (var contact in _contacts)
                if (contact.Id == id) contactById = contact;

            return _contacts.Remove(contactById!);
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