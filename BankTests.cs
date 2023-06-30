using BankAccount;

namespace Bank_Account
{
    public class BankTests
    {
        static void CheckAccount_WrongPassword_ReturnFalse()
        {
            string username = "joseph";
            string password = "12345";
            string file = username + ".txt";

            Account mockAcc = new Account();

            bool isInvalid = mockAcc.CheckAccount(username, password, file);
            if(isInvalid)
            {
                Console.WriteLine("Test for CheckAccount_WrongPassword_ReturnFalse failed");
            }
            else
            {
                Console.WriteLine("Test for CheckAccount_WrongPassword_ReturnFalse succeeded");
            }
        }

        static void Main(string[] args)
        {
            CheckAccount_WrongPassword_ReturnFalse();
        }

    }
}
