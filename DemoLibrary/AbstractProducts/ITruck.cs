namespace DemoLibrary.AbstractProducts;

/// <summary>
/// Base interface for Truck product.
/// All variants of the Truck product must implement this interface.
/// </summary>
public interface ITruck
{
    // Truck is able to do its own thing
    string Haul();

    // ...but it also can collaborate with the Car.
    // The Abstract Factory makes sure that all products it creates are of
    // the same variant and thus, compatible.
    string AskForACar(ICar car);
}
