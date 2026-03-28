using CarApp.Interfaces;

namespace CarApp.Cars;

public abstract class MechanicalAutomaticCar : ACar, IMechanical, IAutomatic
{
    public abstract double EngineVolume { get; }
    public abstract string FuelType { get; }

    protected override string GetEngineInfo()
        => ((IMechanical)this).EngineType;

    protected override string GetTransmissionInfo()
        => ((IAutomatic)this).TransmissionType;
}
