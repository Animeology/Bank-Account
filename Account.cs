using System.IO;

public class Account
{
    public void LogInAccount()
    {
        Console.WriteLine("Login or Create an account if you don't have an account");
        Console.WriteLine("1: Login");
        Console.WriteLine("2: Create");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Username:");
            string username = Console.ReadLine()!;
            Console.Write("Password:");
            string password = Console.ReadLine()!;

            CheckAccount(username, password);
        }
        else if (choice == 2)
        {
            CreateAccount();
        }
    }

    int CheckAccount(string username, string password)
    {
        string line = File.ReadAllText("Accounts.txt");

        if(line != username)
        {
            Console.WriteLine("Invalid Username");
        }
        else if(line != password)
        {
            Console.WriteLine("Invalid Password");
        }

        return 0;
    }

    void CreateAccount()
    {
        Console.WriteLine("Hello, and Welcome to our Bank. Please input your desired Username and Password");

        Console.Write("Username:");
        string username = Console.ReadLine()!;
        Console.Write("Password:");
        string password = Console.ReadLine()!;

        File.WriteAllText("Accounts.txt", username);
        File.WriteAllText("Accounts.txt", password);

        Console.WriteLine("Thank you for creating your acount");
    }
}
