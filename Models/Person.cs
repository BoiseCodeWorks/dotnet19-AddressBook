using System;
using System.Threading;
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
      IContact c = (IContact)this;
      System.Console.WriteLine($"Edit the info for {c.FullName}:");
      bool editing = true;
      while (editing)
      {
        System.Console.WriteLine("1. First Name\n2. Last Name\n3. Address\n4. Finish editing and return.");
        switch (Console.ReadLine())
        {
          case "1":
            System.Console.Write("New First Name: ");
            c.FirstName = Console.ReadLine();
            break;
          case "2":
            System.Console.Write("New Last Name: ");
            c.LastName = Console.ReadLine();
            break;
          case "3":
            System.Console.Write("New Address: ");
            c.Address = Console.ReadLine();
            break;
          case "4":
            editing = false;
            foreach (var ltr in "Saving...")
            {
              System.Console.Write(ltr);
              Thread.Sleep(200);
            }
            Console.WriteLine();
            break;
          default:
            System.Console.WriteLine("Please enter a valid option.");
            break;
        }
      }
    }
  }
}