namespace CarApp.Cars;

public class Ford : MechanicalManualCar
{
    public override string Brand => "Ford";
    public override int Seats => 5;
    public override string InfoSystem => "SYNC";
    public override double EngineVolume => 2.5;
    public override string FuelType => "бензин";
    public override int Gears => 6;
}
