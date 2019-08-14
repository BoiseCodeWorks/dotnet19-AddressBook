using AddressBook.Interfaces;

namespace AddressBook.Models
{
    public class CoWorker : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } set { return; } }
        public string Address { get; set; }
        public string Business { get; set; }
        public string Position { get; set; }

        public void DisplayContactDetails()
        {
            
        }
        public CoWorker(string first, string last, string address, string business, string position)
        {
            FirstName = first;
            LastName = last;
            Address = address;   
            Business = business;
            Position = position;
        }

    }
}