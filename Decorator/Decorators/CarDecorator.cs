using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        public string GetColor()
        {
            return car.GetColor();
        }

        public double GetPrice()
        {
            return car.GetPrice();
        }

        public abstract double GetDiscount();
        public abstract double FinalPrice { get;}
    }
}
