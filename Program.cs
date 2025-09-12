namespace Password.Checker;

class Program
{
    static void Main(string[] args)
    {
        PwdCheck pwdCheck = new PwdCheck();


        Console.WriteLine("Enter your new password");
        string pwd = Console.ReadLine()!;

        bool result = pwdCheck.IsPasswordStrong(pwd);

        if (result == false)
        {
            Console.Write("Your password is too weak or contain spaces");
        }
        else
        {
            Console.WriteLine("Your password is strong enough");
        }
    }
}
