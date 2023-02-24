using System.Security;

internal class Program
{
    const string SEKRET_PASSWORD = "PASSWORD";
    static string _incorrectPassword = "Password is not correct";
    static string _incorrectLogin = "Login is not correct";
    static string? _finalAnswer;
    static string? _login;

    static void Main(string[] args)
    {
        Console.WriteLine("Hi. Pleace, enter login: ");
        _login = Console.ReadLine()?.ToUpper();

        _finalAnswer = _login == string.Empty
            ? _finalAnswer = "Hello Anonimous"
            : _finalAnswer = (VerifyPassword()
                ? UserOrAdminChecking(_login)
                : _incorrectPassword);

        Console.WriteLine(_finalAnswer);

        Console.WriteLine("Press any button for close program");
        Console.ReadKey();
    }

    /// <summary>Checks was enter USER or ADMIN login </summary>
    /// <param name="result">A string variable entered by the user</param>
    /// <returns>Say hello to the user or administrator</returns>
    static string UserOrAdminChecking(string result)
    {
        if (result == "USER") return _login = "Hello User";
        else if (result == "ADMIN") return _login = "Hello Administrator";
        else return result = _incorrectLogin;
    }

    /// <summary>It asks to confirm password</summary>
    static bool VerifyPassword()
    {
        Console.WriteLine("Confirm password: ");
        string? password = Console.ReadLine().ToUpper();

        bool result;
        return result = password != string.Empty
            ? (password == SEKRET_PASSWORD ? true : false)
            : false;
    }

    // private static SecureString MaskInputString()
    // {
    //     System.Console.WriteLine("Confirm password: ");
    //     SecureString pass = new SecureString();
    //     ConsoleKeyInfo keyInfo;

    //     do
    //     {
    //         keyInfo = Console.ReadKey(true);
    //         if (!char.IsControl(keyInfo.KeyChar))
    //         {
    //             pass.AppendChar(keyInfo.KeyChar);
    //             Console.WriteLine("*");
    //         }
    //         else if (keyInfo.Key != ConsoleKey.Backspace && pass.Length > 0)
    //         {
    //             pass.RemoveAt(pass.Length - 1);
    //             Console.Write("\b \b");
    //         }
    //     }
    //     while (keyInfo.Key != ConsoleKey.Enter);
    //     {
    //         return pass;
    //     }
    // }
}