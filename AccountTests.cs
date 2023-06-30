using BankAccount;

namespace Bank_Account
{
    public class AccountTests
    {
        static void CheckAccount_WrongPassword_ReturnFalse()
        {
            // Assign
            string username = "joseph";
            string password = "12345";
            string file = username + ".txt";

            // Act
            Account mockAcc = new Account();
            bool isInvalid = mockAcc.CheckAccount(username, password, file);

            // "Assert"
            if(isInvalid)
            {
                Console.WriteLine("Test for CheckAccount_WrongPassword_ReturnFalse failed");
            }
            else
            {
                Console.WriteLine("Test for CheckAccount_WrongPassword_ReturnFalse succeeded");
            }
        }

        static void CheckAccount_CorrectPassword_ReturnTrue()
        {
            // Assign
            string username = "joseph";
            string password = "nguyen";
            string file = username + ".txt";

            // Act
            Account mockAcc = new Account();
            bool isValid = mockAcc.CheckAccount(username, password, file);

            // "Assert"
            if (isValid)
            {
                Console.WriteLine("Test for CheckAccount_CorrectPassword_ReturnTrue succeeded");
            }
            else
            {
                Console.WriteLine("Test for CheckAccount_CorrectPassword_ReturnTrue failed");
            }
        }

        static void CheckBalance_CorrectBalance_ReturnTrue()
        {
            // Assign
            string username = "joseph";
            string file = username + ".txt";
            int expectedBalance = 1000;

            // Act
            Account mockAcc = new Account();
            int actualBalance = mockAcc.CheckBalance(file);

            // Assert
            if(actualBalance == expectedBalance)
            {
                Console.WriteLine("Test for CheckBalance_CorrectBalance_ReturnTrue succeeded");
            }
            else
            {
                Console.WriteLine("Test for CheckBalance_CorrectBalance_ReturnTrue failed");
            }
        }

        static void CreateAccount_ValidUsername_ReturnTrue()
        {
            // Assign
            string username = "animeology";

            // Act
            Account mockAcc = new Account();
            string actualUser = mockAcc.CreateAccount();

            // Assert
            if(actualUser == username)
            {
                Console.WriteLine("Test for CreateAccount_ValidUsername_ReturnTrue succeeded");
            }
            else
            {
                Console.WriteLine("Test for CreateAccount_ValidUsername_ReturnTrue failed");
            }
        }

        static void CreateAccount_InValidUsername_ReturnFalse()
        {
            // Assign
            string username = "animeology";

            // Act
            Account mockAcc = new Account();
            string actualUser = mockAcc.CreateAccount();

            // Assert
            if (actualUser != username)
            {
                Console.WriteLine("Test for CreateAccount_InValidUsername_ReturnFalse succeeded");
            }
            else
            {
                Console.WriteLine("Test for CreateAccount_InValidUsername_ReturnFalse failed");
            }
        }


        static void Main(string[] args)
        {
            CheckAccount_WrongPassword_ReturnFalse();
            Console.WriteLine();
            CheckAccount_CorrectPassword_ReturnTrue();
            Console.WriteLine();
            CheckBalance_CorrectBalance_ReturnTrue();
            Console.WriteLine();
            CreateAccount_ValidUsername_ReturnTrue();
            Console.WriteLine();
            CreateAccount_InValidUsername_ReturnFalse();
            Console.WriteLine();
        }
    }
}
