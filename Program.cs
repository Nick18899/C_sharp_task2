using CarApp;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string available = string.Join(", ", CarFactory.GetAvailableBrands());
Console.WriteLine($"Доступные марки: {available}");
Console.WriteLine();

while (true)
{
    Console.Write("Введите марку автомобиля или done для остановки ввода: ");
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        continue;

    if (input.Trim().Equals("done", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if (CarFactory.TryParseCarType(input, out var carType))
    {
        var car = CarFactory.Create(carType);
        Console.WriteLine($"«{car.GetDescription()}»");
    }
    else
    {
        Console.WriteLine($"Марка \"{input.Trim()}\" не найдена. Доступные: {available}");
    }

    Console.WriteLine();
}
