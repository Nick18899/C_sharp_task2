namespace CarApp.Cars;

public class Lada : MechanicalManualCar
{
    public override string Brand => "Lada";
    public override int Seats => 5;
    public override string InfoSystem => "штатная магнитола";
    public override double EngineVolume => 1.6;
    public override string FuelType => "бензин";
    public override int Gears => 5;
}
