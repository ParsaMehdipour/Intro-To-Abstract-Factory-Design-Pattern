using DemoLibrary.AbstractProducts;

namespace DemoLibrary.ConcreteProducts;

/// <summary>
/// Concrete Products are created by corresponding Concrete Factories(ClassicTruck -> ITruck).
/// </summary>
public class ClassicTruck : ITruck
{
    public string Haul()
    {
        return "Hauling with a classic truck.";
    }

    // The variant, ClassicTruck, is only able to work correctly with the
    // variant, ClassicCar. Nevertheless, it accepts any instance of
    // ICar as an argument.
    public string AskForACar(ICar car)
    {
        var result = car.Drive();

        return $"The work of the classic truck is done. Next task:{result}";
    }
}
