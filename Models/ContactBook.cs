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
      switch (group)
      {
        case "COWORKERS":
          // logic
          break;
        case "FRIENDS":
          // logic
          break;
        case "FAMILYMEMBERS":
          // logic
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
      }
    }
    public ContactBook(string ownersName)
    {
      OwnersName = ownersName;
      Contacts = new List<IContact>();
    }
  }
}