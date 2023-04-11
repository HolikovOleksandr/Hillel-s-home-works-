public class Noah : BiblicallyCharacter
{
    public readonly int arkLenth = 300;
    public readonly int arkWidth = 56;
    public readonly int arkHeidht = 30;

    public string CollectBeastPairs()
    {
        return "all beasts pairs redy to loading onto the ark";
    }

    public string AskSonForHelp(Son son) 
    {   
        son.BuildArk();
        return $"{Name} asked for help {son.Name} his son";
    } 

    public string GetEveryoneOutOfArk()
    {
        if (ReleaseDove() == "Olive live")
        {
            return Introduce() + " brings all the survivors out of the ark and continue a life without frends";
        }
        else
        {
            return "Stay on ark and weihgt one more weak";
        }
    }

    public string ReleaseDove() => "Olive live";


    public int CalculateArkSpace(int width, int heght, int length)
    {
        int arkSpace;

        if (width == length && width == heght)
        {
            arkSpace = 6 * width ^ 2;
        }
        else
        {
            arkSpace = 2 * (width * length + width * heght + length * heght);
        }

        return arkSpace;
    }
}
