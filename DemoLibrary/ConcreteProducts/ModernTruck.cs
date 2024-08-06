using DemoLibrary.AbstractProducts;

namespace DemoLibrary.ConcreteProducts;

/// <summary>
/// Concrete Products are created by corresponding Concrete Factories(ModernTruck -> ITruck).
/// </summary>
public class ModernTruck : ITruck
{
    public string Haul()
    {
        return "Hauling with a modern truck.";
    }

    // The variant, ModernTruck, is only able to work correctly with the
    // variant, ModernCar. Nevertheless, it accepts any instance of
    // ICar as an argument.
    public string AskForACar(ICar car)
    {
        var result = car.Drive();

        return $"The work of the modern truck is done. Next task: {result}";
    }
}
