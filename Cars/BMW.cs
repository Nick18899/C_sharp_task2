namespace CarApp.Cars;

public class BMW : MechanicalAutomaticCar
{
    public override string Brand => "BMW";
    public override int Seats => 5;
    public override string InfoSystem => "iDrive";
    public override double EngineVolume => 3.0;
    public override string FuelType => "бензин";
}
