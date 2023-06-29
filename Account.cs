namespace BankAccount
{
    public class Account
    {
        Transaction transaction = new Transaction();

        public int balance = 0;
        public string? username;
        public string? password;
        public string? userFile;

        public void LogInAccount()
        {
            Console.WriteLine("Login or Create an account if you don't have an account");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Create");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Username:");
                    username = Console.ReadLine()!;
                    Console.Write("Password:");
                    password = Console.ReadLine()!;

                    userFile = username + ".txt";
                    bool checker = CheckAccount(username, password, userFile);
                    balance = CheckBalance(userFile);

                    if (checker)
                    {
                        transaction.Menu(balance, userFile);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username/password. Try again");
                        LogInAccount();
                    }
                    break;
                case 2:
                    username = CreateAccount();
                    userFile = username + ".txt";
                    transaction.Menu(balance, userFile);
                    break;
                default:
                    string nothing = " ";
                    Console.WriteLine("Invalid Input");
                    transaction.Menu(balance, nothing);
                    break;
            }
        }

        public bool CheckAccount(string username, string password, string file)
        {
            bool isValid = false;
            string line;

            if ((username + ".txt") == file)
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while ((line = sr.ReadLine()!) != null)
                    {
                        if (password == line)
                        {
                            isValid = true;
                            break;
                        }
                        if (password != line)
                        {
                            Console.WriteLine("Invalid Password");
                            LogInAccount();
                            break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Username");
                LogInAccount();
            }

            return isValid;
        }

        int CheckBalance(string file)
        {
            string line;

            using (StreamReader sr = new StreamReader(file))
            {
                while ((line = sr.ReadLine()!) != null)
                {
                    balance = int.Parse(sr.ReadLine()!);
                }
            }
            return balance;
        }

        string CreateAccount()
        {
            Console.WriteLine("Hello, and Welcome to our Bank. Please input your desired Username and Password");

            Console.Write("Username:");
            string username = Console.ReadLine()!;
            Console.Write("Password:");
            string password = Console.ReadLine()!;

            string userFile = username + ".txt";
            File.AppendAllText(userFile, password + Environment.NewLine);
            File.AppendAllText(userFile, balance + Environment.NewLine);

            Console.WriteLine("Thank you for creating your acount");

            return username;
        }
    }
}