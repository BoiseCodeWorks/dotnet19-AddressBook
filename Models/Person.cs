using System;
using AddressBook.Interfaces;

namespace AddressBook.Models
{
  public abstract class Person
  {
    public void DisplayContactDetails()
    {
      Console.Clear();
      // NOTE 'this' refers to the object who invoked the prototype method
      IContact contact = (IContact)this;

      Console.WriteLine(contact.FullName);
      Console.WriteLine(contact.Address);

      if (contact is CoWorker)
      {
        CoWorker c = (CoWorker)contact;
        Console.WriteLine(c.Business);
        Console.WriteLine(c.Position);
      }
      if (contact is FamilyMember)
      {
        FamilyMember famMem = (FamilyMember)contact;
        Console.WriteLine(famMem.Relation);
      }
      if (contact is Friend)
      {
        Friend friend = (Friend)contact;
        Console.WriteLine(friend.NickName);
      }
      PersonMenu();
    }
    private void PersonMenu()
    {
      System.Console.WriteLine("-----------------------------------------------------------");
      System.Console.WriteLine("(E)dit contact");
      System.Console.WriteLine("(R)emove contact");
      System.Console.WriteLine("any other key to go back");
      switch (Console.ReadLine().ToUpper())
      {
        case "E":
        case "EDIT":
          EditContactInfo();
          break;
        case "R":
        case "REMOVE":
          //remove logic
          break;
        default:
          break;
      }
    }
    public void EditContactInfo()
    {
      IContact contact = (IContact)this;

    }
  }
}