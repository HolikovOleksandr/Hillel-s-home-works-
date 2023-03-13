public class BadPupil : Pupil
{
    public override void Relax() 
    {
        Console.WriteLine($"I`m a {nameof(BadPupil)}.{nameof(Relax)}");
    }
    public override void Studi() 
    {
        Console.WriteLine($"I`m a {nameof(BadPupil)}.{nameof(Studi)}");
    }
    public override void Read() 
    {
        Console.WriteLine($"I`m a {nameof(BadPupil)}.{nameof(Read)}");
    }
    public override void Write() 
    {
        Console.WriteLine($"I`m a {nameof(BadPupil)}.{nameof(Write)}");
    }
}
