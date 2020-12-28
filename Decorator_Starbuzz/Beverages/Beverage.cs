using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Starbuzz.Model
{
    public abstract class Beverage
    {
        public string description;
        public int size;

        public abstract double Cost();
        public string GetDescription() => description;
        public int GetSize() => size;
    }
}
