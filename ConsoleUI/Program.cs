// The client code works with factories and products only through abstract
// types: AbstractFactory and AbstractProduct. This lets you pass any
// factory or product subclass to the client code without breaking it.

using DemoLibrary.AbstractFactories;
using DemoLibrary.ConcreteFactories;

new Client().Main();

class Client
{
    public void Main()
    {
        // The client code can work with any concrete factory class.
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ModernVehicleFactory());
        Console.WriteLine();

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ClassicVehicleFactory());
    }

    public void ClientMethod(IVehicleFactory factory)
    {
        var car = factory.CreateCar();
        var truck = factory.CreateTruck();

        Console.WriteLine(car.Drive());
        Console.WriteLine(truck.AskForACar(car));
    }
}