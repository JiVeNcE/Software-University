//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Stefan";
        string middleName = "Nikolov";
        string lastName = "Angelov";        
        decimal amountOfMoney = 50324.33m;
        string bankName = "First Invest Bank";
        string iban = "BG23 TTBB9400 1234567893";

        ulong firstCreditCard, secondCreditCard, thirdCreditCard;

        firstCreditCard = 3453874984634678;
        secondCreditCard = 5469759675467544;
        thirdCreditCard = 5435385745434343;

        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Middle Name : {0}", middleName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Balance: {0} BGN", amountOfMoney);
        Console.WriteLine("Bank Name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit Cards: \n\t 1 - {0} \n\t 2 - {1} \n\t 3 - {2}", firstCreditCard, secondCreditCard, thirdCreditCard);
    }
}