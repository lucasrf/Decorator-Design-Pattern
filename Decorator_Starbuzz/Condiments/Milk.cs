using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            switch (_beverage.size)
            {
                case 1:
                    return (base.Cost() + 0.05);
                case 2:
                    return (base.Cost() + 0.10);
                case 3:
                    return (base.Cost() + 0.15);
                default:
                    return (base.Cost());
            }

        }
    }
}
