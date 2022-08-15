// See https://aka.ms/new-console-template for more information
using System;
using AddressBook;
public class AddContact
{
    public Contacts AddContactm()
    {
        Contacts contact = new Contacts();
        Console.WriteLine("Enter Firstname");
        contact.FirstName = Console.ReadLine();
        Console.WriteLine("Enter Lastname");
        contact.LastName = Console.ReadLine();
        Console.WriteLine("Enter Address");
        contact.Address = Console.ReadLine();
        Console.WriteLine("Enter City");
        contact.City = Console.ReadLine();
        Console.WriteLine("Enter State");
        contact.State = Console.ReadLine();
        Console.WriteLine("Enter Zip-Code");
        contact.ZipCode = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter Phone number");
        contact.PhoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Ent'er E-mail");
        contact.Email = Console.ReadLine();
        return contact;

    }
}