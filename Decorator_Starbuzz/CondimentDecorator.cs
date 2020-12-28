using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public CondimentDecorator(Beverage component)
        {
            this._beverage = component;
        }

        public void SetBeverage(Beverage component)
        {
            this._beverage = component;
        }

        // The Decorator delegates all work to the wrapped component.
        public override double Cost()
        {
            if (this._beverage != null)
            {
                return this._beverage.Cost();
            }
            else
            {
                return 0;
            }
        }
    }
}
