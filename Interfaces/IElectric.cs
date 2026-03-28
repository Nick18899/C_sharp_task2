namespace CarApp.Interfaces;

public interface IElectric
{
    int BatteryCapacityKWh { get; }
    int RangeKm { get; }
    string EngineType => "электрический двигатель";
}
