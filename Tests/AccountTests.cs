using Bank_Account.Bank;

namespace Bank_Account.Tests
{
    public class AccountTests
    {
        static void CheckAccount_WrongPassword()
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
                throw new Exception("Test for CheckAccount_WrongPassword_ReturnFalse failed");
            }
        }

        static void CheckAccount_CorrectPassword()
        {
            // Assign
            string expectedUsername = "anime";
            string expectedPassword = "anime";
            string expectedFile = expectedUsername + ".txt";

            // Act
            Account mockAcc = new Account();
            bool isValid = mockAcc.CheckAccount(expectedUsername, expectedPassword, expectedFile);

            // "Assert"
            if (!isValid)
            {
                throw new Exception("Test for CheckAccount_WrongPassword_ReturnFalse failed");
            }
        }

        static void CheckBalance_CorrectBalance()
        {
            // Assign
            string expectedUsername = "anime";
            string expectedFile = expectedUsername + ".txt";
            int expectedBalance = 90;

            // Act
            Account mockAcc = new Account();
            int actualBalance = mockAcc.CheckBalance(expectedFile);

            // Assert
            if(actualBalance != expectedBalance)
            {
                throw new Exception("Test for CheckBalance_CorrectBalance failed");
            }
        }

        static void CreateAccount_ValidUsername()
        {
            // Assign
            string expectedUsername = "animeology";

            // Act
            Account mockAcc = new Account();
            string actualUser = mockAcc.CreateAccount();

            // Assert
            if(actualUser != expectedUsername)
            {
                throw new Exception("Test for CreateAccount_ValidUsername failed");
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

        public static void AllAccountTests()
        {
            CheckAccount_WrongPassword();
            CheckAccount_CorrectPassword();
            CheckBalance_CorrectBalance();
            //CreateAccount_ValidUsername();
        }
    }
}
