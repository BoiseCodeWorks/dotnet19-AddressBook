using System;
using System.Collections.Generic;
using AddressBook.Interfaces;

namespace AddressBook.Models
{
  public class ContactBook : IContactBook
  {
    public string OwnersName { get; set; }
    public List<IContact> Contacts { get; set; }



    public void CreateContact()
    {
      System.Console.WriteLine("Enter First Name:");
      string userFirst = Console.ReadLine();
      System.Console.WriteLine("Enter Last Name:");
      string userLast = Console.ReadLine();
      System.Console.WriteLine("Enter Address:");
      string userAddress = Console.ReadLine();
      System.Console.WriteLine("Type of contact\n1. CoWorker\n2. Family Member\n3. Friend");
      switch (Console.ReadLine())
      {
        case "1":
          System.Console.WriteLine("Enter Business: ");
          string userBusiness = Console.ReadLine();
          System.Console.WriteLine(("Enter Position: "));
          string userPosition = Console.ReadLine();
          CoWorker c = new CoWorker(userFirst, userLast, userAddress, userBusiness, userPosition);
          Contacts.Add(c);
          break;
        case "2":
          System.Console.WriteLine("Enter Relation: ");
          string userRelation = Console.ReadLine();
          FamilyMember fm = new FamilyMember(userFirst, userLast, userAddress, userRelation);
          Contacts.Add(fm);
          break;
        case "3":
          System.Console.WriteLine("Enter NickName: ");
          string userNickName = Console.ReadLine();
          Friend f = new Friend(userFirst, userLast, userAddress, userNickName);
          Contacts.Add(f);
          break;
        default:
          System.Console.WriteLine("Not a valid option");
          break;
      }
    }

    public void DeleteContact()
    {

    }

    public IContact GetContactByName()
    {
      // TODO make me work
      return null;
    }

    public void ListContacts(string group = "")
    {
      List<IContact> contactList = Contacts;
      if (group == "4") return;
      switch (group)
      {
        case "1":
          // logic
          contactList = Contacts.FindAll(c => c is CoWorker);
          break;
        case "2":
          // logic
          contactList = Contacts.FindAll(c => c is Friend);
          break;
        case "3":
          // logic
          contactList = Contacts.FindAll(c => c is FamilyMember);
          break;
        case "":
          //NOTE do nothing
          break;
        default:
          Console.WriteLine("If specifying group must enter either CoWorkers, Friends, or FamilyMembers");
          break;
      }

      foreach (IContact contact in contactList)
      {
        //NOTE 'is' is a type check that returns true/false
        if (contact is CoWorker)
        {
          //NOTE below is syntax to cast from data type IContact to data type CoWorker
          CoWorker c = (CoWorker)contact;
          System.Console.WriteLine(c.FullName + " " + c.Business);
        }

        if (contact is FamilyMember)
        {
          FamilyMember c = (FamilyMember)contact;
          System.Console.WriteLine(c.Relation + ": " + c.FullName);
        }

        if (contact is Friend)
        {
          Friend c = (Friend)contact;
          System.Console.WriteLine(c.NickName + ": " + c.FullName);
        }
      }
    }
    public ContactBook(string ownersName)
    {
      OwnersName = ownersName;
      Contacts = new List<IContact>();
    }
  }
}