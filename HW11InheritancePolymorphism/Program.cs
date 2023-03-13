internal class Program
{
    private static void Main()
    {   
        var pupils = new Pupil[4]
        {
            new BadPupil(),
            new BadPupil(),
            new GoodPupil(),
            new ExcelentPupil()
        };

        var classRoom = new ClassRoom(pupils);

        for (int i = 0; i < classRoom.Pupils.Length; i++)
        {
            classRoom.Pupils[i].Read();
            classRoom.Pupils[i].Relax();
            classRoom.Pupils[i].Write();
            classRoom.Pupils[i].Studi();
        }

        Console.ReadKey();
    }
}