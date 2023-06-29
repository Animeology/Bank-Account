using NUnit.Framework;

namespace BankAccountTests
{
    using BankAccount;

    public class BankTests
    {
        [Test]
        public void CheckAccountIfValid_ReturnFalse()
        {
            // Assign 
            string mockUser = "steven";
            string mockPassword = "anime";
            string mockFile = mockUser + ".txt";

            // Act
            bool isValid = mockAcc.CheckAccount(mockUser, mockPassword, mockFile);

            // Assert
            Assert.IsFalse(isValid);
        }


        Account mockAcc;
        [SetUp]
        public void SetUp()
        {
            mockAcc = new Account();
        }
    }
}