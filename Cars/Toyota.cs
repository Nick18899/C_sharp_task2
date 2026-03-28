namespace CarApp.Cars;

public class Toyota : MechanicalAutomaticCar
{
    public override string Brand => "Toyota";
    public override int Seats => 5;
    public override string InfoSystem => "Toyota Touch";
    public override double EngineVolume => 2.0;
    public override string FuelType => "бензин";
}
