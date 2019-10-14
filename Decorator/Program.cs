using Decorator.Component;
using Decorator.Decorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            var car = new Hyundai();

            CarDecorator carDecorator = new HyundaiSpecialCar(car);

            Console.WriteLine($"It has Color : {carDecorator.GetColor()} and Price : {carDecorator.GetPrice()} after discount of {carDecorator.GetDiscount()}");
            Console.WriteLine($"Final Price : {carDecorator.FinalPrice}");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
