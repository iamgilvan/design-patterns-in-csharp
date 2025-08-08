// Polymorphism

// Poly = many

// Morph = forms

// Polymorphism  is the ability of an object to take many forms

using Design_Patterns_In_Csharp_Tutorials.Polymorphism;

List<object> vehicles = new List<object>();
vehicles.Add(new Car
{
    Brand = "Toyota",
    Model = "Camry",
    Year = 2020,
    NumberOfDoors = 4
});
vehicles.Add(new Motorcycle
{
    Brand = "Harley Davidson",
    Model = "Sportster",
    Year = 2021,
});

// Vehicle inspction
foreach (var vehicle in vehicles)
{
    // vehicle.Start();
    if (vehicle is Car)
    {
        var car = (Car)vehicle; ;
        car.Start();
    }
    else if (vehicle is Motorcycle)
    {
        var motor = (Car)vehicle;
        motor.Start();
    }
}