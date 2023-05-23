public class BankAccount
{
    static void Main(string[] args)
    {
        LogInAccount();
    }

    static void LogInAccount()
    {
        Console.WriteLine("Login or Create an account if you don't have an account");
        Console.WriteLine("1: Login");
        Console.WriteLine("2: Create");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Username:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
        }
        else if (choice == 2)
        {
            CreateAccount();
        }

        Transaction();
    }

    static void CreateAccount()
    {
        Console.WriteLine("Hello, and Welcome to our Bank. Please input your desired Username and Password");

        Console.Write("Username:");
        string username = Console.ReadLine();
        Console.Write("Password:");
        string password = Console.ReadLine();

        Console.WriteLine("Thank you for creating your acount");
    }

    static void Transaction()
    {
        Console.WriteLine("Would you like to Deposit, Withdraw, Check your Balance, or Interest rate");

        int balance = 0;

        Console.WriteLine("1: Deposit");
        Console.WriteLine("2: Withdraw");
        Console.WriteLine("3: Balance");
        Console.WriteLine("4: Interest Rate");
        Console.WriteLine("5: Quit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Deposit(balance);
                break;
            case 2:
                Withdraw(balance);
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                Console.WriteLine("Invalid Choice, Please select a valid choice");
                Transaction();
                break;
        }
    }

    static void Deposit(int balance)
    {
        Console.WriteLine("How much do you want to deposit?");

        Console.Write("$");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("${0} to deposit, Do you want to confirm that?", amount);

        string confirm = Console.ReadLine();

        if(confirm == "Yes" || confirm == "yes")
        {
            balance += amount;
            Console.WriteLine("Would you like to deposit more?");
            confirm = Console.ReadLine();
            if (confirm == "Yes" || confirm == "yes")
            {
                Deposit(balance);
            }
            else
            {
                Console.WriteLine("Ok, returning back to the menu");
                Transaction();
            }
        }
        else if(confirm == "No" || confirm == "no")
        {
            Console.WriteLine("Ok, would you like to deposit a different amount or quit?");
            confirm = Console.ReadLine();
            if (confirm == "Yes" || confirm == "yes")
            {
                Deposit(balance);
            }
            else
            {
                Console.WriteLine("Ok, returning back to the menu");
                Transaction();
            }
        }
    }

    static void Withdraw(int balance)
    {
        Console.WriteLine("What amount would you like to withdraw from your account?");

        Console.Write("$");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("${0} to withdraw, Do you want to confirm that?", amount);

        string confirm = Console.ReadLine();

        if (confirm == "Yes" || confirm == "yes")
        {
            balance += amount;
            Console.WriteLine("Would you like to withdraw more?");
            confirm = Console.ReadLine();
            if (confirm == "Yes" || confirm == "yes")
            {
                Withdraw(balance);
            }
            else
            {
                Console.WriteLine("Ok, returning back to the menu");
                Transaction();
            }
        }
        else if (confirm == "No" || confirm == "no")
        {
            Console.WriteLine("Ok, would you like to withdraw a different amount or quit?");
            confirm = Console.ReadLine();
            if (confirm == "Yes" || confirm == "yes")
            {
                Withdraw(balance);
            }
            else
            {
                Console.WriteLine("Ok, returning back to the menu");
                Transaction();
            }
        }

    }
}