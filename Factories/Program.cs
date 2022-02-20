using Factories.AbstractFactory;
using Factories.FactoryMethod;
using System;

namespace Factories
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");

            var micro1 = MotherboardFactory.GetMotherboard(ProcessorModels.I9);
            var micro2 = MotherboardFactory.GetMotherboard(ProcessorModels.Threadripper);
            Console.WriteLine(micro1.Architecture());
            Console.WriteLine(micro2.Architecture());

            Console.WriteLine();

            Console.WriteLine("Abstract Factory");

            VehicleFactory factory;
            Car car;
            Truck truck;

            factory = new FordFactory();
            car = factory.CreateCar("X3");
            truck = factory.CreateTruck("Ranger");
            PrintCarDescription(car);
            PrintTruckDescription(truck);

            factory = new TeslaFactory();
            car = factory.CreateCar("Model S");
            truck = factory.CreateTruck("Cybertruck");
            PrintCarDescription(car);
            PrintTruckDescription(truck);

            factory = new FerrariFactory();
            car = factory.CreateCar("Aventador");
            PrintCarDescription(car);
        }

        private static void PrintTruckDescription(Truck truck)
        {
            Console.WriteLine($"Building: {truck.Description} - {truck.Name}");
        }

        private static void PrintCarDescription(Car car)
        {
            Console.WriteLine($"Building: {car.Description} - {car.Name}");
        }
    }
}