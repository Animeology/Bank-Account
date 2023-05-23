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


        Console.WriteLine("1: Deposit");
        Console.WriteLine("2: Withdraw");
        Console.WriteLine("3: Balance");
        Console.WriteLine("4: Interest Rate");
        Console.WriteLine("5: Quit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                break;
            case 2:
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
}