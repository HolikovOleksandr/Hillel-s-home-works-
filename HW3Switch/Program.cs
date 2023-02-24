namespace Switch
{
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

            switch (_login)
            {
                case "":
                    {
                        _finalAnswer = "Hello, Anonimus";
                        break;
                    }
                case "USER":
                    {
                        bool vetifyPassword = VerifyPassword();
                        _finalAnswer = vetifyPassword ? "Hello User" : _incorrectPassword;
                        break;
                    }
                case "ADMIN":
                    {
                        bool vetifyPassword = VerifyPassword();
                        _finalAnswer = vetifyPassword ? "Hello Administrator" : _incorrectPassword;
                        break;
                    }
                default:
                    {
                        _finalAnswer = _incorrectLogin;
                        break;
                    }
            }
            Console.WriteLine(_finalAnswer);

            Console.WriteLine("Press any button to exit the program");
            Console.ReadLine();
        }

        /// <summary>It asks to enter a password and confirm it</summary>
        /// <returns>Helper variable to Checks the success of password confirmation</returns>
        static bool VerifyPassword()
        {
            Console.WriteLine("Enter password: ");
            string? password = Console.ReadLine().ToUpper();

            bool result;
            return result = password != string.Empty
                ? (password == SEKRET_PASSWORD ? true : false)
                : false;
        }
    }
}

