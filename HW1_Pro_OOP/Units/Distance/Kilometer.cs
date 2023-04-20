public class Kilometer : Unit
{
    public override double ConvertUnitTo(Units unit, double value)
    {
        switch (unit)
        {
            case Units.Centimeter:
                return value * 100000;
            case Units.Meter:
                return value * 1000;
            case Units.Kilometer:
                return value;
            case Units.Mile:
                return value * 0.6214;
            default:
                throw new Exception($"Cannot convert from {GetType().Name} to {unit}");
        }
    }
}
