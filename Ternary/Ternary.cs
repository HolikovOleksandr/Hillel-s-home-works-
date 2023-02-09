namespace Ternary
{
    internal class Ternary
    {
        static void Main(string[] args)
        {
            // TERNARY
            string _positiveAnswer = "Successful!";
            string _negativeAnswer = "Misstake!";
            string _finalAnswer;
            string? _login;
            bool result;


            // Story 1
            _positiveAnswer = "Hello User";

            Console.WriteLine("Story 1");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();

            if (_login == "USER")
            {
                result = CreateAndConfirmPassword();
                _finalAnswer = result ? _positiveAnswer : _negativeAnswer;
                Console.WriteLine(_finalAnswer);
            }
            else Console.WriteLine(_negativeAnswer);


            // Story 2
            _positiveAnswer = "Hello Administrator";

            Console.WriteLine("Story 2");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();

            if (_login == "ADMIN")
            {
                result = CreateAndConfirmPassword();
                _finalAnswer = result ? _positiveAnswer : _negativeAnswer;
                Console.WriteLine(_finalAnswer);
            }
            else Console.WriteLine(_negativeAnswer);


            // story 3
            _positiveAnswer = "Hello Anonimous";

            Console.WriteLine("Story 3");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine();

            _finalAnswer = _login == "" ? _positiveAnswer : _negativeAnswer;
            Console.WriteLine(_finalAnswer);


            // Story 4
            _negativeAnswer = "Password is not correct";

            Console.WriteLine("Story 4");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();

            if (_login == "ADMIN" || _login == "USER")
            {
                result = CreateAndConfirmPassword();
                _finalAnswer = result ? _positiveAnswer : _negativeAnswer;
                Console.WriteLine(_finalAnswer);
            }
            else Console.WriteLine(_negativeAnswer);

            Console.WriteLine(_negativeAnswer);
        }



        static bool CreateAndConfirmPassword()
        {
            Console.WriteLine("Enter password: ");
            string? password = Console.ReadLine();

            Console.WriteLine("Confirm password: ");
            string? confirmPassword = Console.ReadLine();

            bool result = password == confirmPassword ? true : false;
            return result;
        }

    }
}