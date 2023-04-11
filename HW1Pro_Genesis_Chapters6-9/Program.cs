public class Program
{
    static void Main(string[] args)
    {
        var noah = new Noah { Name = "Noah", SonOf = "Lamech", IsMerried = true };

        var sonHam = new Son { Name = "Ham", SonOf = noah.Name, IsMerried = true };

        var sonJapheth = new Son { Name = "Japheth", SonOf = noah.Name, IsMerried = true };

        var sonShem = new Son { Name = "Shem", SonOf = noah.Name, IsMerried = true };
        

        Console.WriteLine(noah.Introduce());
        Console.WriteLine(noah.BuildArk());

        Divider.WriteDivider();

        int arkSpace = noah.CalculateArkSpace(length: noah.arkLenth, heght: noah.arkHeidht, width: noah.arkWidth);
        Console.WriteLine($"Ark was {arkSpace} space");
        Console.WriteLine($"{noah.Name} understood that he could not cope on his own");
        Divider.WriteDivider();

        Console.WriteLine(noah.AskSonForHelp(sonHam));
        Console.WriteLine(sonHam.BuildArk());
        Divider.WriteDivider();

        Console.WriteLine(noah.AskSonForHelp(sonJapheth));
        Console.WriteLine(sonJapheth.BuildArk());
        Divider.WriteDivider();

        Console.WriteLine(noah.AskSonForHelp(sonShem));
        Console.WriteLine(sonShem.BuildArk());
        Divider.WriteDivider();

        Console.WriteLine($"When ark was created and {noah.CollectBeastPairs()}");
        Console.WriteLine(noah.InviteWifeIntoArk());
        Divider.WriteDivider();

        Console.WriteLine(sonHam.InviteWifeIntoArk());
        Divider.WriteDivider();

        Console.WriteLine(sonJapheth.InviteWifeIntoArk());
        Divider.WriteDivider();

        Console.WriteLine(sonShem.InviteWifeIntoArk());
        Divider.WriteDivider();

        Console.WriteLine("Later");
        Console.WriteLine(noah.Name + nameof(noah.ReleaseDove));
        Console.WriteLine(noah.GetEveryoneOutOfArk());
    }
}