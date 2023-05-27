public class Bank
{
    static void Main(string[] args)
    {
        Account account = new Account();
        Transaction transaction = new Transaction();

        account.LogInAccount();
        transaction.Menu();
    }
}