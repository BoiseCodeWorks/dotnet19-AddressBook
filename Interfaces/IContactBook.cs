using System.Collections.Generic;

namespace AddressBook.Interfaces
{
    public interface IContactBook
    {
        string OwnersName { get; set; }
        List<IContact> Contacts { get; set; }

        void CreateContact();
        
        void ListContacts();

        IContact GetContactByName();

        void DeleteContact();
    }
}