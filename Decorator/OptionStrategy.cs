using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface OptionStrategy
    {
        void GetDetail(ICar car);
    }
}
