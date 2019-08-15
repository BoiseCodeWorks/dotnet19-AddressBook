using AddressBook.Interfaces;
using AddressBook.Models;
using System;

namespace AddressBook
{
  public class App : IApp
  {
    public ContactBook ContactBook { get; set; }
    public bool UsingContactBook { get; set; }

    public void DisplayMenu()
    // Welcome to your address book.
    // ----------------------------------
    // 1. View all contacts
    //     1a. View Contact Details
    //         1aa. Update Contact
    //         1ab.Remove Contact
    // 2. View only specific group of contacts (eg, CoWorkers, Friends, FamilyMembers)
    //     2a. View Contact Details
    //         2aa. Update Contact
    //         2ab.Remove Contact
    // 3. Get Contact by name
    // 4. Add new Contact
    // 5. Quit the application
    {
      Console.WriteLine("Welcome to the Contact Book!");
      System.Console.WriteLine("-----------------------------------");
      System.Console.WriteLine("What would you like to do?");
      System.Console.WriteLine(("1. View all Contacts\n2. View Specific Group\n3.Search Contact\n4. Add New Contact\n5. Quit!"));
      switch (Console.ReadLine())
      {
        case "1":
          ContactBook.ListContacts();
          break;
        case "2":
          Console.WriteLine("Which Group\n1 - Coworkers\n2 - Friends\n3 - Family Members\n4 - Go Back");
          ContactBook.ListContacts(Console.ReadLine());
          break;
        case "3":
          Console.WriteLine("Enter Name:");
          ContactBook.GetContactByName();
          break;
        case "4":
          ContactBook.CreateContact();
          break;
        case "5":
          UsingContactBook = false;
          break;
        default:
          Console.WriteLine("Invalid Entry");
          break;
      }
    }

    public void Run()
    {
      while (UsingContactBook)
      {
        DisplayMenu();
      }
    }

    public void Setup()
    {
      UsingContactBook = true;

      ContactBook = new ContactBook("CodeWorks");

      Friend friend1 = new Friend("Tom", "Jones", "Boise", "Tommy");
      FamilyMember familyMember1 = new FamilyMember("Peter", "Parker", "Queens", "Spidey");
      CoWorker coWorker1 = new CoWorker("Charles", "Xavier", "Manhattan", "School of Gifted Students", "Professor");

      friend1.DisplayContactDetails();

      ContactBook.Contacts.Add(friend1);
      ContactBook.Contacts.Add(familyMember1);
      ContactBook.Contacts.Add(coWorker1);
    }
  }
}


