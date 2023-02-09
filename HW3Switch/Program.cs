namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _positiveAnswer = "Successful!";
            string _negativeAnswer = "Misstake!";
            string _finalAnswer;
            string? _login;
            bool _result;

            // Story 1
            Console.WriteLine("Story 1");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();
            _positiveAnswer = "Hello User";

            switch (_login)
            {
                case "USER":
                    {
                        _result = CreateAndConfirmPassword();
                        switch (_result)
                        {
                            case true:
                                {
                                    Console.WriteLine(_positiveAnswer);
                                    break;
                                }
                            case false:
                                {
                                    Console.WriteLine(_negativeAnswer);
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(_negativeAnswer);
                        break;
                    }
            }

            // Story 2
            Console.WriteLine("Story 2");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();
            _positiveAnswer = "Hello Administrator";

            switch (_login)
            {
                case "ADMIN":
                    {
                        _result = CreateAndConfirmPassword();
                        switch (_result)
                        {
                            case true:
                                {
                                    Console.WriteLine(_positiveAnswer);
                                    break;
                                }
                            case false:
                                {
                                    Console.WriteLine(_negativeAnswer);
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(_negativeAnswer);
                        break;
                    }
            }

            // Story 3
            Console.WriteLine("Story 3");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();
            _positiveAnswer = "Hello Anonimous";

            switch (_login)
            {
                case "":
                    {
                        Console.WriteLine(_positiveAnswer);
                        break;
                    }
            }


            // Story 4
            Console.WriteLine("Story 4");
            Console.WriteLine("Enter login: ");
            _login = Console.ReadLine().ToUpper();
            _positiveAnswer = "Hello User";
            _negativeAnswer = "Password is not correct";

            switch (_login)
            {
                case "ADMIN" or "USER" :
                    {
                        _result = CreateAndConfirmPassword();
                        switch (_result)
                        {
                            case true:
                                {
                                    Console.WriteLine(_positiveAnswer);
                                    break;
                                }
                            case false:
                                {
                                    Console.WriteLine(_negativeAnswer);
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine(_negativeAnswer);
                        break;
                    }
            }


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

