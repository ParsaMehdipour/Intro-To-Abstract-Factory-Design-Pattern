using DemoLibrary.AbstractProducts;

namespace DemoLibrary.ConcreteProducts;

/// <summary>
/// Concrete Products are created by corresponding Concrete Factories(ClassicCar -> ICar).
/// </summary>
public class ClassicCar : ICar
{
    public string Drive()
    {
        return "Driving a classic car.";
    }
}
