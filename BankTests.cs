using BankAccount;
using NUnit.Framework;

namespace Bank_Account
{
    public class BankTests
    {
        [Test]
        public void CheckIfAccountIsValid()
        {
            mockUsername = "anime";
            mockPassword = "anime";

            Assert.IsTrue(mockAccount?.CheckAccount(mockUsername, mockPassword, mockUserFile!));
        }

        protected Account? mockAccount;
        protected string? mockUsername;
        protected string? mockPassword;
        protected string? mockUserFile;

        [SetUp]
        public void SetUp() 
        {
            mockAccount = new Account();
            mockAccount.username = mockUsername;
            mockAccount.password = mockPassword;

            mockUserFile = mockAccount.username + ".txt";
            mockAccount.userFile = mockUserFile;

        }
    }
}
