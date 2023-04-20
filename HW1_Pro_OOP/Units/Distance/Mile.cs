public class Mile : Unit
{
    public override double ConvertUnitTo(Units unit, double value)
    {
        switch (unit)
        {
            case Units.Centimeter:
                return value * 160934.399;
            case Units.Meter:
                return value * 0.00062137;
            case Units.Kilometer:
                return value * 1.609344;
            case Units.Mile:
                return value;
            default:
                throw new Exception($"Cannot convert from {GetType().Name} to {unit}");
        }
    }
}
