public class Meter : Unit
{
    public override double ConvertUnitTo(Units unit, double value)
    {
        switch (unit)
        {
            case Units.Centimeter:
                return value * 100;
            case Units.Meter:
                return value;
            case Units.Kilometer:
                return value / 1000;
            case Units.Mile:
                return value / 1609.34;
            default:
                throw new Exception($"Cannot convert from {GetType().Name} to {unit}");
        }
    }
}