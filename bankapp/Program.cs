using System;

namespace bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var a1=Bank.CreateAccount("test@test.com", AccountType.Checking, 0);
             var a2 = Bank.CreateAccount("test2@test.com", AccountType.Saving, 100);


             Console.WriteLine($"AN:{a1.AccountNumber}, AT:{a1.AccountType}, EA:{a1.EmailAddress}, BL:{a1.Balance}, CD: {a1.CreatedDate}");
             Console.WriteLine($"AN:{a2.AccountNumber}, AT:{a2.AccountType}, EA:{a2.EmailAddress}, BL:{a2.Balance}, CD: {a2.CreatedDate}");
            */

            Console.WriteLine("******************");
            Console.WriteLine("Welcome to my bank!");
            Console.WriteLine("********************");

            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Creat an account");
                Console.WriteLine("2.Deposit");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Print my accounts");
                Console.Write("Select an option:");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bank!");
                        return;
                    case "1":
                        Console.Write("Email Address:");
                        var emailAddress = Console.ReadLine();

                        var accountTypes = Enum.GetNames(typeof(AccountType));
                        for (int i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}.{accountTypes[i]}");
                        }
                        Console.WriteLine("Choose your Account Type");
                        var accountType = Enum.Parse<AccountType>(Console.ReadLine());

                        Console.WriteLine("Amount to deposit:");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                        var a1 = Bank.CreateAccount(emailAddress, accountType, amount);
                        Console.WriteLine($"AN:{a1.AccountNumber}, AT:{a1.AccountType}, EA:{a1.EmailAddress}, BL:{a1.Balance}, CD: {a1.CreatedDate}");
                        return;
                    case "2":
                        Console.WriteLine("Amount to deposit?");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                    case "3":
                        Console.WriteLine("Amount to withdraw?");
                        var amount = Convert.ToDecimal(Console.ReadLine());
                    case "4":
                    default:
                        break;
                }

            }
        }
    }
}
