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

    }

    public void EditContactInfo()
    {

    }
  }
}