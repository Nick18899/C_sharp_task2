using CarApp.Interfaces;

namespace CarApp.Cars;

public abstract class ACar : ICar
{
    public abstract string Brand { get; }
    public abstract int Seats { get; }
    public abstract string InfoSystem { get; }

    protected abstract string GetEngineInfo();
    protected abstract string GetTransmissionInfo();

    public virtual string GetDescription()
    {
        return $"{Brand}: {GetEngineInfo()}, {GetTransmissionInfo()}, " +
               $"{Seats} мест, {InfoSystem}";
    }

    public override string ToString() => GetDescription();
}
