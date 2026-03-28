namespace CarApp.Cars;

public class Tesla : ElectricAutomaticCar
{
    public override string Brand => "Tesla";
    public override int Seats => 5;
    public override string InfoSystem => "Android на борту";
    public override int BatteryCapacityKWh => 75;
    public override int RangeKm => 530;
}
