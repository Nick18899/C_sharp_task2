using CarApp.Cars;
using CarApp.Interfaces;

namespace CarApp;

public static class CarFactory
{
    private static readonly Dictionary<string, CarType> BrandMap = new(StringComparer.OrdinalIgnoreCase)
    {
        ["tesla"] = CarType.Tesla,
        ["nissan"] = CarType.Nissan,
        ["bmw"] = CarType.BMW,
        ["toyota"] = CarType.Toyota,
        ["mercedes"] = CarType.MercedesBenz,
        ["mercedes-benz"] = CarType.MercedesBenz,
        ["lada"] = CarType.Lada,
        ["ford"] = CarType.Ford
    };

    public static ICar Create(CarType type) => type switch
    {
        CarType.Tesla => new Tesla(),
        CarType.Nissan => new Nissan(),
        CarType.BMW => new BMW(),
        CarType.Toyota => new Toyota(),
        CarType.MercedesBenz => new MercedesBenz(),
        CarType.Lada => new Lada(),
        CarType.Ford => new Ford(),
        _ => throw new ArgumentException($"Неизвестный тип автомобиля: {type}")
    };

    public static bool TryParseCarType(string input, out CarType carType)
    {
        return BrandMap.TryGetValue(input.Trim(), out carType);
    }

    public static IEnumerable<string> GetAvailableBrands() => BrandMap.Keys;
}
