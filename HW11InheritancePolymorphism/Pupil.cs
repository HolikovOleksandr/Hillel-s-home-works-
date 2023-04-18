public class Pupil
{
    public virtual void Studi() { Console.WriteLine($"I can {nameof(Studi)}."); }  
    public virtual void Read() { Console.WriteLine($"I can {nameof(Read)}."); } 
    public virtual void Write() { Console.WriteLine($"I can {nameof(Write)}."); }
    public virtual void Relax() { Console.WriteLine($"I can {nameof(Relax)}."); }    
}
