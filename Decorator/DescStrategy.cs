using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DescStrategy : OptionStrategy
    {
        protected ICar _car;
        public void GetDetail(ICar car)
        {
            this._car = car;
            var array = _car.OptionsDescription.ToArray();
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Description}");
            }
        }
    }
}
