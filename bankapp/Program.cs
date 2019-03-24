using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1=Bank.CreateAccount("test@test.com", "checking", 0);
            var a2 = Bank.CreateAccount("test2@test.com", "saveing", 100);
           

            Console.WriteLine($"AN:{a1.AccountNumber}, AT:{a1.AccountType}, EA:{a1.EmailAddress}, BL:{a1.Balance}, CD: {a1.CreatedDate}");
            Console.WriteLine($"AN:{a2.AccountNumber}, AT:{a2.AccountType}, EA:{a2.EmailAddress}, BL:{a2.Balance}, CD: {a2.CreatedDate}");
           
        }
    }
}
