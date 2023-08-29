using System;

namespace class_vehicle
{
    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    sealed class Car : Vehicle
    {
        // Some Car-specific members or methods can be added here
    }

    class ElectricCar : Car
    {
        // This class tries to inherit from the sealed class Car, which will result in a compilation error.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();

            ElectricCar electricCar = new ElectricCar();    // This line will cause a compilation error
            Console.Read();
        }
    }

}
