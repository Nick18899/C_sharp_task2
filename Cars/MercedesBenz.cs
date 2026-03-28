namespace CarApp.Cars;

public class MercedesBenz : MechanicalAutomaticCar
{
    public override string Brand => "Mercedes-Benz";
    public override int Seats => 5;
    public override string InfoSystem => "MBUX";
    public override double EngineVolume => 2.0;
    public override string FuelType => "дизель";
}
