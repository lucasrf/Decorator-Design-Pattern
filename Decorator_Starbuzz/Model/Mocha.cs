using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            switch (_beverage.size)
            {
                case 1:
                    return (base.Cost() + 0.10);
                case 2:
                    return (base.Cost() + 0.15);
                case 3:
                    return (base.Cost() + 0.20);
                default:
                    return (base.Cost());
            }

        }
    }
}
