public class ExcelentPupil : Pupil
{
    public override void Relax() 
    {
        Console.WriteLine($"I`m a {nameof(ExcelentPupil)}.{nameof(Relax)}");
    }

    public override void Studi() 
    {
        Console.WriteLine($"I`m a {nameof(ExcelentPupil)}.{nameof(Studi)}");
    }

    public override void Read() 
    {
        Console.WriteLine($"I`m a {nameof(ExcelentPupil)}.{nameof(Read)}");
    }
    
    public override void Write() 
    {
        Console.WriteLine($"I`m a {nameof(ExcelentPupil)}.{nameof(Write)}");
    }
}
