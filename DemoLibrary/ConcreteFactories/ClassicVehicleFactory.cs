using DemoLibrary.AbstractFactories;
using DemoLibrary.AbstractProducts;
using DemoLibrary.ConcreteProducts;

namespace DemoLibrary.ConcreteFactories;

/// <summary>
/// Concrete Factories produce a family of products that belong to a single
/// variant(Here is classic). The factory guarantees that resulting products are compatible.
/// Note that signatures of the Concrete Factory's methods return an abstract
/// product, while inside the method a concrete product is instantiated.
/// </summary>
public class ClassicVehicleFactory : IVehicleFactory
{
    public ICar CreateCar()
    {
        return new ClassicCar();
    }

    public ITruck CreateTruck()
    {
        return new ClassicTruck();
    }
}
