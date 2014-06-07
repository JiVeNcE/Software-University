//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Company Name: ");
        string companyName = Console.ReadLine();     
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();     
        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();     
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();     
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();     
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();     
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();     
        Console.Write("Manager age: ");
        string managerAge = Console.ReadLine();     
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Company information: ");
        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("fax: {0}", faxNumber);
        Console.WriteLine("Web site : {0}", webSite);
        Console.WriteLine("Manager information: ");
        Console.WriteLine("{0} {1} (age: {2}, tel. {3})", firstName, lastName, managerAge, managerPhone);

    }
}
