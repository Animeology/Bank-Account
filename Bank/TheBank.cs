namespace Bank_Account
{
    using Tests;
    using Bank;

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