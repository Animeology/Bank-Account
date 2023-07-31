namespace Bank_Account
{
    using Bank;
    using Tests;

    public class TheBank
    {
        static void Main(string[] args)
        {
            TransactionTests.AllTransactionTests();
            AccountTests.AllAccountTests();

            Account account = new Account();
            account.LogInAccount();
        }
    }

}