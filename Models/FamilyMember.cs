using AddressBook.Interfaces;
using System;

namespace AddressBook.Models
{
  public class FamilyMember : IContact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + " " + LastName; } set { return; } }
    public string Address { get; set; }
    public string Relation { get; set; }

    public void DisplayContactDetails()
    {

    }

    public void EditContactInfo()
    {

    }
    public FamilyMember(string firstname, string lastname, string address, string relation)
    {
      FirstName = firstname;
      LastName = lastname;
      Address = address;
      Relation = relation;
    }
  }
}


