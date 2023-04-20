public class Centimeter : Unit
{
    public override double ConvertUnitTo(Units unit, double value)
    {
        switch (unit)
        {
            case Units.Centimeter:
                return value;
            case Units.Meter:
                return value / 100;
            case Units.Kilometer:
                return value / 100000;
            case Units.Mile:
                return value / 160934.4;
            default:
                throw new Exception($"Cannot convert from {GetType().Name} to {unit}");
        }
    }
}