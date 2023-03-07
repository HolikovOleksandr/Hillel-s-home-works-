class Program
{
    static void Main(string[] args)
    {
        #region Encoding
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        #endregion

        #region inputText
        string inputText = @"Містер Дурслі завмер. Його охопив жах. Він озирнувся на тих шептунів, наче хотів їм щось сказати, проте передумав.
        Він перебіг вулицю, поспіхом піднявся до кабінету, гукнув секретарці не турбувати його, схопив телефон і почав набирати свій домашній номер, аж раптом зупинився. Поклав слухавку й замислено погладив вуса. Та ні, яка дурниця. Виходить Поттер — не таке вже й рідкісне прізвище. Є безліч людей, які мають не тільки це прізвище, а й сина на ім'я Гаррі. Так міркуючи, Дурслі вже навіть не знав, чи його племінника справді звуть Гаррі. Він його ніколи й не бачив. Може, то Гарві. Або Гарольд. Не варто хвилювати місіс Дурслі, вона й так дратується на саму згадку про сестру. Він їй не докоряв: якби така сестра була в нього… А все ж оті люди в мантіях…
        Тепер Дурслі було значно важче зосередитися на свердлах і, виходячи о п'ятій пополудні з будинку, він був такий неуважний, що наскочив на когось біля самих дверей.";
        #endregion

        List<string> names = NamesFromTextToList(inputText);
        WriteEachItemsFromList(names);

        Console.WriteLine("Enter any button for close program");
        Console.ReadLine();
    }


    /// <summary> Save all names and surnames from text to list </summary>
    static List<string> NamesFromTextToList(string text)
    {
        List<string> sentences = TextToSentences(text).ToList();
        List<string> names = new List<string>();

        foreach (string sentence in sentences)
        {
            string[] words = sentence.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            words[0] = words[0].ToLower();

            foreach (string word in words)
                if (char.IsUpper(word[0]))
                    names.Add(word);
        }
        return RemoveDuplicateItems(names);
    }


    /// <summary> Splits text into array of sentences </summary>
    static string[] TextToSentences(string text)
    {
        char[] separators = { '…', '.', ',', '!', '?', ';' };
        string[] sentences = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        return sentences;
    }


    /// <summary> Remove duplicate items from list </summary>
    static List<string> RemoveDuplicateItems(List<string> list)
    {
        string[] uniqueItems = list.Distinct().ToArray();
        return uniqueItems.ToList();
    }


    /// <summary> Function will write in console each element from list </summary>
    static void WriteEachItemsFromList(List<string> list)
    {
        foreach (var item in list) Console.WriteLine(item);
    }
}