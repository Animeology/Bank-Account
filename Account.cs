public class Account
{
    Transaction transaction = new Transaction();

    int balance = 0;

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
            balance = CheckBalance();
            if (checker)
            {
                transaction.Menu(balance);
            }
            else
            {
                LogInAccount();
            }
        }
        else if (choice == 2)
        {
            CreateAccount();
            transaction.Menu(balance);
        }
    }

    string usernameFile = "Usernames.txt";
    string passwordFile = "Passwords.txt";

    bool CheckAccount(string username, string password)
    {
        bool isValid = false;
        string line;

        using (StreamReader sr = new StreamReader(usernameFile))
        {
            while ((line = sr.ReadLine()!) != null)
            {
                if (username == line)
                {
                    isValid = true;
                    break;
                }
                else if (username != line || line == null)
                {
                    Console.WriteLine("Invalid Username");
                    Console.WriteLine("Would you like to try again");
                    break;
                }
            }
        }

        using (StreamReader sr = new StreamReader(passwordFile))
        {
            while ((line = sr.ReadLine()!) != null)
            {
                if (line == password)
                {
                    isValid = true;
                    break;
                }
                else if (line != password || line == null)
                {
                    Console.WriteLine("Invalid Password");
                    Console.WriteLine("Would you like to try again");
                    break;
                }
            }
        }

        return isValid;
    }

    int CheckBalance()
    {
        string line;

        using (StreamReader sr = new StreamReader(usernameFile))
        {
            while ((line = sr.ReadLine()!) != null)
            {
                balance = int.Parse(sr.ReadLine()!);
            }
        }
        return balance;
    }

    void CreateAccount()
    {
        Console.WriteLine("Hello, and Welcome to our Bank. Please input your desired Username and Password");

        Console.Write("Username:");
        string username = Console.ReadLine()!;
        File.AppendAllText(usernameFile, username + Environment.NewLine);

        Console.Write("Password:");
        string password = Console.ReadLine()!;
        File.AppendAllText(passwordFile, password + Environment.NewLine);

        File.AppendAllText(usernameFile, Convert.ToString(balance) + Environment.NewLine);

        Console.WriteLine("Thank you for creating your acount");
    }
}
