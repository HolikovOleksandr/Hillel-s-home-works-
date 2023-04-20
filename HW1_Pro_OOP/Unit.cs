public abstract class Unit
{
    /// <summary>Converts a unit to another</summary>
    /// <param name="unit">Selects the final unit from the enum</param>
    /// <param name="value">The number of the base unit for conversion</param>
    public abstract double ConvertUnitTo(Units unit, double value);

    /// <summary>Receives a copy of himself selected from enam</summary>
    /// <param name="unit">Enum of units</param>
    public static Unit GetUnit(Units unit)
    {
        switch (unit)
        {
            case Units.Centimeter:
                return new Centimeter();
            case Units.Mile:
                return new Mile();
            case Units.Meter:
                return new Meter();
            case Units.Kilometer:
                return new Kilometer();
            default: throw new Exception($"Unknown unit '{unit}'");
        }
    }
}
