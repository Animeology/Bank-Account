public class Transaction
{
    int balance = 0;

    int Deposit(int balance)
    {
        Console.WriteLine("How much do you want to deposit?");

        Console.Write("$");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("${0} to deposit, Do you want to confirm that?", amount);
        Console.WriteLine("1: Yes");
        Console.WriteLine("2: No");

        int confirm = Convert.ToInt32(Console.ReadLine());

        if (confirm == 1)
        {
            balance += amount;
            Console.WriteLine("Would you like to deposit more?");
            confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                Deposit(balance);
            }
            else
            {
                ReturnToMenu(balance);
            }
        }
        else if (confirm == 2)
        {
            Console.WriteLine("Ok, would you like to deposit a different amount or quit?");
            Console.WriteLine("1: Deposit A Different Amount");
            Console.WriteLine("2: Quit");

            confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                Deposit(balance);
            }
            else
            {
                ReturnToMenu(balance);
            }
        }

        return balance;
    }

    int Withdraw(int balance)
    {
        Console.WriteLine("What amount would you like to withdraw from your account?");

        Console.Write("$");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("${0} to withdraw, Do you want to confirm that?", amount);

        string confirm = Console.ReadLine()!;

        if (confirm == "Yes" || confirm == "yes")
        {
            balance -= amount;
            Console.WriteLine("Would you like to withdraw more?");
            confirm = Console.ReadLine()!;
            if (confirm == "Yes" || confirm == "yes")
            {
                Withdraw(balance);
            }
            else
            {
                ReturnToMenu(balance);
            }
        }
        else if (confirm == "No" || confirm == "no")
        {
            Console.WriteLine("Ok, would you like to withdraw a different amount or quit?");
            confirm = Console.ReadLine()!;
            if (confirm == "Yes" || confirm == "yes")
            {
                Withdraw(balance);
            }
            else
            {
                ReturnToMenu(balance);
            }
        }

        return balance;
    }

    void Balance(int balance)
    {
        Console.WriteLine("Your current balance is ${0}", balance);

        Console.WriteLine("Would you like to deposit or withdraw?");

        string choice = Console.ReadLine()!;

        if (choice == "Deposit" || choice == "deposit")
        {
            Deposit(balance);
        }
        else if (choice == "Withdraw" || choice == "withdraw")
        {
            Withdraw(balance);
        }
        else
        {
            ReturnToMenu(balance);
        }
    }

    void Interest(int balance)
    {
        float interestRate = 4.5f;

        Console.WriteLine("Input how many years do you want us to calculate your total money with the current interest rate.");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your total will be {0} in {1} year(s)", balance * interestRate, years);

        Console.WriteLine("Would you like to calculate again?");
        string choice = Console.ReadLine()!;

        if (choice == "Yes" || choice == "yes")
        {
            Interest(balance);
        }
        else
        {
            ReturnToMenu(balance);
        }
    }

    void Quit()
    {
        Console.WriteLine("Thank you for choosing our bank! We hope to see you again!");
    }

    void ReturnToMenu(int balance)
    {
        Console.WriteLine("Ok, returning back to the menu");
        Menu();
    }

    public void Menu()
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
                Deposit(balance);
                break;
            case 2:
                Withdraw(balance);
                break;
            case 3:
                Balance(balance);
                break;
            case 4:
                Interest(balance);
                break;
            case 5:
                Quit();
                break;
            default:
                Console.WriteLine("Invalid Choice, Please select a valid choice");
                Menu();
                break;
        }

    }
}
