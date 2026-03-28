namespace CarApp.Interfaces;

public interface IMechanical
{
    double EngineVolume { get; }
    string FuelType { get; }
    string EngineType => $"ДВС {EngineVolume}л ({FuelType})";
}
