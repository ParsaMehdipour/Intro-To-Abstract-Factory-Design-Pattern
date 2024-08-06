using DemoLibrary.AbstractProducts;

namespace DemoLibrary.ConcreteProducts;

/// <summary>
/// Concrete Products are created by corresponding Concrete Factories(ModernCar -> ICar).
/// </summary>
public class ModernCar : ICar
{
    public string Drive()
    {
        return "Driving a modern car.";
    }
}
