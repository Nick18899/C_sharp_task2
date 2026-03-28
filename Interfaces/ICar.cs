namespace CarApp.Interfaces;

public interface ICar
{
    string Brand { get; }
    int Seats { get; }
    string InfoSystem { get; }
    string GetDescription();
}
