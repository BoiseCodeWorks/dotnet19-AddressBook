using AddressBook.Interfaces;
using System;

namespace AddressBook.Models
{
  public class FamilyMember : Person, IContact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + " " + LastName; } set { return; } }
    public string Address { get; set; }
    public string Relation { get; set; }

    public FamilyMember(string firstname, string lastname, string address, string relation)
    {
      FirstName = firstname;
      LastName = lastname;
      Address = address;
      Relation = relation;
    }
  }
}


