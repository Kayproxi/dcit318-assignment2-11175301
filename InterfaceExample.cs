using System;

namespace InterfaceExample
{
    // Interface
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            Console.ReadLine();
        }
    }
}
