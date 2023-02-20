internal class Program
{
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
            : _finalAnswer = CreateAndVerifyPassword()
                ? UserOrAdminChecking(_login)
                : _incorrectPassword;

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

    /// <summary>It asks to enter a password and confirm it</summary>
    /// <returns>Helper variable to Checks the success of password confirmation</returns>
    static bool CreateAndVerifyPassword()
    {
        Console.WriteLine("Enter password: ");
        string? password = Console.ReadLine();

        Console.WriteLine("Confirm password: ");
        string? confirm = Console.ReadLine();

        bool result;

        return result = password != string.Empty && confirm != string.Empty
            ? password == confirm ? true : false 
            : false;
    }
}