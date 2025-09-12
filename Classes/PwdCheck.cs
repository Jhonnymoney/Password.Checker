public class PwdCheck : IPwdCheck
{
    /// <summary>
    /// Check if the Password is strong enough and has no spaces
    /// </summary>
    public bool IsPasswordStrong(string pwd)
    {
        if (pwd.Length <= 8) return false;

        bool hasSpecial = false;
        bool hasCaps = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool noSpace = true;

        foreach (char c in pwd)
        {
            if (char.IsUpper(c)) hasCaps = true;
            if (char.IsDigit(c)) hasDigit = true;
            if (char.IsLower(c)) hasLower = true;
            if (!char.IsLetterOrDigit(c)) hasSpecial = true;
            if (char.IsWhiteSpace(c)) noSpace = false;
        }

        if (!(hasCaps && hasDigit && hasLower && hasSpecial )) return false;  

        return true;
    }
}