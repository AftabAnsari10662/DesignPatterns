using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class HyundaiSpecialCar : CarDecorator
    {
        private readonly ICar car;

        public HyundaiSpecialCar(ICar car) : base(car)
        {
            this.car = car;
        }

        public override double FinalPrice {
            get => GetPrice() - GetDiscount();
        }

        public override double GetDiscount()
        {
            return this.car.GetPrice() * 0.1;
        }
    }
}
