namespace CarApp.Cars;

public class Nissan : ElectricAutomaticCar
{
    public override string Brand => "Nissan Leaf";
    public override int Seats => 5;
    public override string InfoSystem => "NissanConnect";
    public override int BatteryCapacityKWh => 40;
    public override int RangeKm => 270;
}
