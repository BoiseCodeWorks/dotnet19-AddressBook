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
          //NOTE below is syntax to cast from data type IContact to data type CoWorker
          FamilyMember c = (FamilyMember)contact;
          System.Console.WriteLine(c.Relation + ": " + c.FullName);
        }

        if (contact is Friend)
        {
          //NOTE below is syntax to cast from data type IContact to data type CoWorker
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