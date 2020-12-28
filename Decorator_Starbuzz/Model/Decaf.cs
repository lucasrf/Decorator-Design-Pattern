using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class Decaf : Beverage
    {
        public Decaf(int _size)
        {
            size = _size;
        }
        public override double Cost()
        {
            return 3.00;
        }
    }
}
