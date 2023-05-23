public class BankAccount
{
    static void Main(string[] args)
    {
        LogInAccount();
    }

    static void LogInAccount()
    {
        Console.WriteLine("Login or Create an account if you don't have an account");

        string choice = Console.ReadLine();

        if(choice == "Login" || choice == "login")
        {
            Console.Write("Username:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
        }
        else if(choice == "create" ||  choice == "Create")
        {
            CreateAccount();
        }
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
}