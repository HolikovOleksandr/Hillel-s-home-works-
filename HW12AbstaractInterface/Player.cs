public class Player : IPlayable, IRecordable
{
    public void Pause()
    {
        Console.WriteLine("Pause");
    }

    public void Play()
    {
        Console.WriteLine("Started to play track");
    }

    public void Record()
    {
        Console.WriteLine("Started to record sounds");
    }

    public void Stop()
    {
        Console.WriteLine("Stop");
    }
}