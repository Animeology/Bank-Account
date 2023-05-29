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
        string newUsername = File.ReadAllText("Accounts.txt");
        string newPassword = File.ReadAllText("Accounts.txt");

        if(newUsername != username)
        {
            Console.WriteLine("Invalid Username");
        }
        else if(newPassword != password)
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
        File.AppendAllText("Accounts.txt", username + Environment.NewLine);
        
        Console.Write("Password:");
        string password = Console.ReadLine()!;
        File.AppendAllText("Accounts.txt", password + Environment.NewLine);

        Console.WriteLine("Thank you for creating your acount");
    }
}
