using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class HouseBlend : Beverage
    {
        public HouseBlend(int _size)
        {
            size = _size;
        }
        public override double Cost()
        {
            return 4.00;
        }
    }
}
