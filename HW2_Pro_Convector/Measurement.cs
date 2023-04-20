public class Measurement
{   
    public Units Unit { get; set; }
    public double Amound { get; set; }

    public Measurement(Units unit, double amound)
    {
        Unit = unit;
        Amound = amound;
    }

    public void ChangeUnit(Unit anotherUnit)
    {
        anotherUnit.ConvertUnitTo(Unit, Amound);
    }
}
