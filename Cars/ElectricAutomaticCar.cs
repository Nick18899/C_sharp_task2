using CarApp.Interfaces;

namespace CarApp.Cars;

public abstract class ElectricAutomaticCar : ACar, IElectric, IAutomatic
{
    public abstract int BatteryCapacityKWh { get; }
    public abstract int RangeKm { get; }

    protected override string GetEngineInfo()
        => $"электрокар (батарея {BatteryCapacityKWh} кВт·ч, запас хода {RangeKm} км)";

    protected override string GetTransmissionInfo()
        => ((IAutomatic)this).TransmissionType;
}
