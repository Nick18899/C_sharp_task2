namespace CarApp.Interfaces;

public interface IManual
{
    int Gears { get; }
    string TransmissionType => $"механическая коробка передач ({Gears} ступеней)";
}
