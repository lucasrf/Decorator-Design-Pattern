using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class DarkRoast : Beverage
    {
        public DarkRoast(int _size)
        {
            size = _size;
        }
        public override double Cost()
        {
            return 3.00;
        }
    }
}
