using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component
{
    public class Suzuki : ICar
    {
        public string GetColor()
        {
            return "BLUE";
        }

        public double GetPrice()
        {
            return 600000;
        }
    }
}
