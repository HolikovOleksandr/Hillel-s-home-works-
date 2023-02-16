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

            Console.WriteLine("Hi. Pleace, enter login and press ENTER: ");
            _login = Console.ReadLine().ToUpper();

            if (_login == "") _finalAnswer = "Hello Anonimous";
            else if (_login == "USER" || _login == "ADMIN")
            {
                Console.WriteLine("Enter password and press ENTER: ");
                string? password = Console.ReadLine();

                Console.WriteLine("Confirm password and press ENTER: ");
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