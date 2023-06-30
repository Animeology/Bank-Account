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
            string password = "nguyen";
            string file = username + ".txt";
            int expectedBalance = 1000;

            // Act
            Account mockAcc = new Account();
            mockAcc.CheckAccount(username, password, file);
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

        static void Main(string[] args)
        {
            CheckAccount_WrongPassword_ReturnFalse();
            CheckAccount_CorrectPassword_ReturnTrue();
            CheckBalance_CorrectBalance_ReturnTrue();
        }
    }
}
