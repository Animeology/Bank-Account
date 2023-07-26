using BankAccount;

namespace Bank_Account.Tests
{
    public class TransactionTests
    {
        static void Deposit_Test()
        {
            // Assign
            Transaction mockTransaction = new Transaction();

            float mockBalance = 100.0f;
            float mockAmount = 100.0f;
            mockTransaction.amount = mockAmount;
            mockTransaction.balance = mockBalance;

            float expectedBalance = 200.0f;

            // Act
            string mockFile = CreateMockFile(mockBalance);
            float actualBalance = mockTransaction.Deposit(mockBalance, mockFile);

            // Assert
            if (actualBalance != expectedBalance)
            {
                throw new Exception("Deposit_Test failed");
            }
            DeleteMockFile(mockFile);
        }

        static void Withdraw_Test()
        {
            // Assign
            Transaction mockTransaction = new Transaction();

            float mockBalance = 200.0f;
            float mockAmount = 100.0f;
            mockTransaction.amount = mockAmount;
            mockTransaction.balance = mockBalance;

            float expectedBalance = 100.0f;

            // Act
            string mockFile = CreateMockFile(mockBalance);
            float actualBalance = mockTransaction.Withdraw(mockBalance, mockFile);

            // Assert
            if (actualBalance != expectedBalance)
            {
                throw new Exception("Withdraw_Test failed");
            }

            DeleteMockFile(mockFile);
        }

        static void Interest_Test()
        {
            Transaction mockTransaction = new Transaction();

            float mockBalance = 100.0f;
            float mockRate = 4.5f;
            int mockYears = 5;

            mockTransaction.balance = mockBalance;
            mockTransaction.rate = mockRate;
            mockTransaction.years = mockYears;

            float expectedBalance = 2250.0f;

            // Act
            string mockFile = CreateMockFile(mockBalance);
            float actualBalance = mockTransaction.Interest(mockBalance, mockFile);

            // Assert
            if (actualBalance != expectedBalance)
            {
                throw new Exception("Interest_Test failed");
            }

            DeleteMockFile(mockFile);
        }

        public static void AllTransactionTests()
        {
            Deposit_Test();
            Withdraw_Test();
            Interest_Test();
        }

        static string CreateMockFile(float balance)
        {
            string mockUser = "MockAccount";
            string mockPass = "MockPassword";
            string mockFile = mockUser + ".txt";

            File.WriteAllText(mockFile, mockPass + Environment.NewLine);
            File.WriteAllText(mockFile, balance + Environment.NewLine);

            return mockFile;
        }

        static void DeleteMockFile(string mockUsername)
        {
            string mockFile = mockUsername + ".txt";
            string filePath = Path.GetFullPath(mockFile);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

    }
}
