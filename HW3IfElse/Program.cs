namespace IfElse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string _incorrectPassword = "Password is not correct";
            string _incorrectLogin = "Login is not correct";
            string _finalAnswer = "";
            string _login;

            Console.WriteLine("Hi. Pleace, enter login: ");
            _login = Console.ReadLine().ToUpper();

            if (_login == string.Empty) _finalAnswer = "Hello Anonimous";
            else if (_login == "USER" || _login == "ADMIN")
            {
                Console.WriteLine("Enter password: ");
                string? password = Console.ReadLine();

                Console.WriteLine("Confirm password: ");
                string? confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    if (_login == "USER") _finalAnswer = "Hello User";
                    else if (_login == "ADMIN") _finalAnswer = "Hello Administrator";
                }
                else _finalAnswer = _incorrectPassword;
            }
            else _finalAnswer = _incorrectLogin;

            Console.WriteLine(_finalAnswer);

            Console.WriteLine("Press any button to exit the program");
            Console.ReadLine();
        }
    }
}