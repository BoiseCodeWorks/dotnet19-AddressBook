using AddressBook.Models;

namespace AddressBook.Interfaces
{
  public interface IApp
  {
    ContactBook ContactBook { get; set; }
    bool UsingContactBook { get; set; }

    void Setup();

    void Run();

    void DisplayMenu();
  }
}