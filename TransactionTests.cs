using BankAccount;

namespace Bank_Account
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
            if(actualBalance == expectedBalance)
            {
                Console.WriteLine("Deposit_Test succeeded");
            }
            else
            {
                Console.WriteLine("Deposit_Test failed");
            }
        }





        static string CreateMockFile(float balance)
        {
            string mockUser = "MockAccount";
            string mockPass = "MockPassword";
            string mockFile = mockUser + ".txt";

            File.AppendAllText(mockFile, mockPass + Environment.NewLine);
            File.AppendAllText(mockFile, balance + Environment.NewLine);

            return mockFile;
        }

        static void Main(string[] args)
        {
            Deposit_Test();
        }
    }
}
