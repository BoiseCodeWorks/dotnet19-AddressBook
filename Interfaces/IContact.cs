namespace AddressBook.Interfaces
{
    public interface IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        string Address { get; set; }

        void DisplayContactDetails();

        void EditContactInfo();
    }
}