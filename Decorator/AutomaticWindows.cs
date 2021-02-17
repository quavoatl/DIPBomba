using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class AutomaticWindows : AbstractOptionsDecorator
    {
        public AutomaticWindows(ICar car) : base(car)
        {
            this.Description = "Nice Automatic Windows";
            this.Price = 1200;
        }

    }
}
