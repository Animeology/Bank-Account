using System.Text.RegularExpressions;

namespace BankAccount
{
    public class Transaction
    {
        bool isTesting = true;

        public float amount;
        public float balance;

        public float rate;
        public int years;
        public float total;


        public float Deposit(float balance, string file)
        {
            if (isTesting)
            {
                balance += amount;
                WriteBalanceBackToFile(balance, file);
                return balance;
            }

            Console.WriteLine("How much do you want to deposit?");

            Console.Write("$");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{amount} to deposit, Do you want to confirm that?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");

            int confirm = Convert.ToInt32(Console.ReadLine());
            switch (confirm)
            {
                case 1:
                    balance += amount;
                    Console.WriteLine("Would you like to deposit more?");
                    Console.WriteLine("1: Yes");
                    Console.WriteLine("2: No");

                    confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm == 1)
                    {
                        Deposit(balance, file);
                    }
                    else
                    {
                        ReturnToMenu(balance, file);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ok, would you like to deposit a different amount or quit?");
                    Console.WriteLine("1: Deposit A Different Amount");
                    Console.WriteLine("2: Quit");

                    confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm == 1)
                    {
                        Deposit(balance, file);
                    }
                    else
                    {
                        ReturnToMenu(balance, file);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Deposit(balance, file);
                    break;
            }

            WriteBalanceBackToFile(balance, file);

            return balance;
        }

        public float Withdraw(float balance, string file)
        {
            if (isTesting)
            {
                balance -= amount;
                WriteBalanceBackToFile(balance, file);
                return balance;
            }

            Console.WriteLine("What amount would you like to withdraw from your account?");

            Console.Write("$");
            amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{amount} to withdraw, Do you want to confirm that?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");

            int confirm = Convert.ToInt32(Console.ReadLine());

            switch (confirm)
            {
                case 1:
                    balance -= amount;
                    Console.WriteLine("Would you like to withdraw more?");
                    Console.WriteLine("1: Yes");
                    Console.WriteLine("2: No");

                    confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm == 1)
                    {
                        Withdraw(balance, file);
                    }
                    else
                    {
                        ReturnToMenu(balance, file);
                    }
                    break;
                case 2:
                    Console.WriteLine("Ok, would you like to withdraw a different amount or quit?");
                    Console.WriteLine("1: Withdraw A Different Amount");
                    Console.WriteLine("2: Quit");

                    confirm = Convert.ToInt32(Console.ReadLine());
                    if (confirm == 1)
                    {
                        Withdraw(balance, file);
                    }
                    else
                    {
                        ReturnToMenu(balance, file);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Withdraw(balance, file);
                    break;
            }

            WriteBalanceBackToFile(balance, file);

            return balance;
        }

        void Balance(float balance, string file)
        {
            Console.WriteLine("Your current balance is ${0}", balance);

            Console.WriteLine("Would you like to deposit or withdraw?");
            Console.WriteLine("1: Deposit");
            Console.WriteLine("2: Withdraw");
            Console.WriteLine("3: Quit");

            int confirm = Convert.ToInt32(Console.ReadLine());

            switch (confirm)
            {
                case 1:
                    Deposit(balance, file);
                    break;
                case 2:
                    Withdraw(balance, file);
                    break;
                case 3:
                    ReturnToMenu(balance, file);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Balance(balance, file);
                    break;
            }
        }

        public float Interest(float balance, string file)
        {
            if(isTesting)
            {
                total = (balance * rate) * years;
                return total;
            }

            Console.WriteLine("What is your Interest Rate?");
            Console.Write("Rate: ");
            rate = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Input how many years do you want us to calculate your total money with the current interest rate.");
            Console.Write("Years: ");
            years = Convert.ToInt32(Console.ReadLine());

            total = (balance * rate) * years;

            Console.WriteLine($"Your total will be {total} in {years} year(s)");

            Console.WriteLine("Would you like to calculate again?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Interest(balance, file);
                    break;
                case 2:
                    ReturnToMenu(balance, file);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Interest(balance, file);
                    break;
            }

            return total;
        }
        static void WriteBalanceBackToFile(float balance, string file)
        {
            string path = "C:\\Users\\josep\\GitHub\\source\\Bank-Account\\bin\\Debug\\net7.0\\" + file;
            string pattern = @"\d+";

            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();
            }

            Regex regex = new Regex(pattern);

            using (StreamWriter sw = new StreamWriter(path))
            {
                string content = regex.Replace(line, balance.ToString());
                sw.Write(content);
            }
        }

        public void Menu(float balance, string file)
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
                    Deposit(balance, file);
                    break;
                case 2:
                    Withdraw(balance, file);
                    break;
                case 3:
                    Balance(balance, file);
                    break;
                case 4:
                    Interest(balance, file);
                    break;
                case 5:
                    Quit();
                    break;
                default:
                    Console.WriteLine("Invalid Choice, Please select a valid choice");
                    Menu(balance, file);
                    break;
            }
        }

        void Quit()
        {
            Console.WriteLine("Thank you for choosing our bank! We hope to see you again!");
        }

        void ReturnToMenu(float balance, string file)
        {
            Console.WriteLine("Ok, returning back to the menu");
            Menu(balance, file);
        }
    }
}
