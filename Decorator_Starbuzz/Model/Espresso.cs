using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class Espresso : Beverage
    {
        public Espresso(int _size)
        {
            size = _size;
        }
        public override double Cost()
        {
            return 2.00;
        }
    }
}
