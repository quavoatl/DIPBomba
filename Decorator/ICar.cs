using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface ICar
    {
        public List<ICar> OptionsDescription { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        List<ICar> GetOptions();
        void GetOptionInfo(OptionStrategy optionStrategy);
        double GetCost();
    }
}
