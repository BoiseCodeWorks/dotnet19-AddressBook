using System;
using AddressBook.Interfaces;

namespace AddressBook.Models
{
  public class Friend : Person, IContact
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + " " + LastName; } set { return; } }
    public string Address { get; set; }

    public string NickName { get; set; }


    public Friend(string firstName, string lastName, string address, string nickName = "")
    {
      FirstName = firstName;
      LastName = lastName;
      Address = address;
      NickName = nickName;
    }
  }
}