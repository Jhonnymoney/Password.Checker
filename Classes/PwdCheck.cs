namespace Password.Checker.Classes;

public class PwdCheck
{
    ////<summary>
    ///Check if the Password is strong enough and has no spaces
    ///<summary>
    public string? Password;
    public bool IsPasswordStrong(string password)
    {
        if (password.Length <= 8) return false;

        bool hasSpecial = false;
        bool hasCaps = false;
        bool hasLower = false;
        bool hasDigit = false;

        bool hasSpace = true;

        foreach (char Letter in password) ;
        {
            if (char.IsUpper(Letter)) hasCaps = true;
            if (char.IsDigit(Letter)) hasDigit = true;
            if (char.IsLower(Letter)) hasLower = true;
            if (char.IsSpecial(Letter)) hasSpecial = true;
        }
        /// to check if there is a Space in the password
        foreach (char Letter in password) ;
        {
            if (char.IsWhiteSpace(Letter)) hasSpace = false;
        }


        
}
