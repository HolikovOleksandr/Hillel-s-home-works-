public class GoodPupil : Pupil
{
    public override void Relax() 
    {
        Console.WriteLine($"I`m a {nameof(GoodPupil)}.{nameof(Relax)}");
    }
    public override void Studi() 
    {
        Console.WriteLine($"I`m a {nameof(GoodPupil)}.{nameof(Studi)}");
    }
    public override void Read() 
    {
        Console.WriteLine($"I`m a {nameof(GoodPupil)}.{nameof(Read)}");
    }
    public override void Write() 
    {
        Console.WriteLine($"I`m a {nameof(GoodPupil)}.{nameof(Write)}");
    }
}
