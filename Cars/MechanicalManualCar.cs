using CarApp.Interfaces;

namespace CarApp.Cars;

public abstract class MechanicalManualCar : ACar, IMechanical, IManual
{
    public abstract double EngineVolume { get; }
    public abstract string FuelType { get; }
    public abstract int Gears { get; }

    protected override string GetEngineInfo()
        => ((IMechanical)this).EngineType;

    protected override string GetTransmissionInfo()
        => ((IManual)this).TransmissionType;
}
