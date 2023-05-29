public class Account
{
    Transaction transaction = new Transaction();

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

            bool checker = CheckAccount(username, password);
            if (checker)
            {
                transaction.Menu();
            }
            else
            {
                LogInAccount();
            }
        }
        else if (choice == 2)
        {
            CreateAccount();
            transaction.Menu();
        }

    }

    bool CheckAccount(string username, string password)
    {
        bool isValid = true;

        string newUsername = File.ReadAllText("Accounts.txt");
        string newPassword = File.ReadAllText("Accounts.txt");

        if (newUsername != username)
        {
            Console.WriteLine("Invalid Username");
            isValid = false;
            Console.WriteLine("Would you like to try again");
        }
        else if (newPassword != password)
        {
            Console.WriteLine("Invalid Password");
            isValid = false;
            Console.WriteLine("Would you like to try again");
        }

        return isValid;
    }

    void CreateAccount()
    {
        Console.WriteLine("Hello, and Welcome to our Bank. Please input your desired Username and Password");

        Console.Write("Username:");
        string username = Console.ReadLine()!;
        File.AppendAllText("Accounts.txt", "Username: " + username + Environment.NewLine);

        Console.Write("Password:");
        string password = Console.ReadLine()!;
        File.AppendAllText("Accounts.txt", "Password: " + password + Environment.NewLine);

        Console.WriteLine("Thank you for creating your acount");
    }
}
