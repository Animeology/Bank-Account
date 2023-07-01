using BankAccount;

namespace Bank_Account
{
    public class AccountTests
    {
        static void CheckAccount_WrongPassword_ReturnFalse()
        {
            // Assign
            string expectedUsername = "anime";
            string expectedPassword = "12345";
            string expectedFile = expectedUsername + ".txt";

            // Act
            Account mockAcc = new Account();
            bool isInvalid = mockAcc.CheckAccount(expectedUsername, expectedPassword, expectedFile);

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
            string expectedUsername = "anime";
            string expectedPassword = "anime";
            string expectedFile = expectedUsername + ".txt";

            // Act
            Account mockAcc = new Account();
            bool isValid = mockAcc.CheckAccount(expectedUsername, expectedPassword, expectedFile);

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
            string expectedUsername = "anime";
            string expectedFile = expectedUsername + ".txt";
            int expectedBalance = 90;

            // Act
            Account mockAcc = new Account();
            int actualBalance = mockAcc.CheckBalance(expectedFile);

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
            string expectedUsername = "animeology";

            // Act
            Account mockAcc = new Account();
            string actualUser = mockAcc.CreateAccount();

            // Assert
            if(actualUser == expectedUsername)
            {
                Console.WriteLine("Test for CreateAccount_ValidUsername_ReturnTrue succeeded");
            }
            else
            {
                Console.WriteLine("Test for CreateAccount_ValidUsername_ReturnTrue failed");
            }

            DeleteMockFile(expectedUsername);
        }

        static void DeleteMockFile(string mockUsername)
        {
            string mockFile = mockUsername + ".txt";
            string filePath = Path.GetFullPath(mockFile);

            if(File.Exists(filePath))
            {
                File.Delete(filePath);
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
        }
    }
}
