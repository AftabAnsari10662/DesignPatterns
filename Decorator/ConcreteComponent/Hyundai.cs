using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public class Hyundai : ICar
    {
        public string GetColor()
        {
            return "RED";
        }

        public double GetPrice()
        {
            return 500000;
        }
    }
}
