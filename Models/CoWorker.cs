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

    public void EditContactInfo()
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

    // NOTE static members are only accessible from the class itself and not an instance of the class (that's a prototype member, not static)
    // public static void ExampleStaticMethod()
    // {
    //   System.Console.WriteLine("im a static");
    // }

  }
}