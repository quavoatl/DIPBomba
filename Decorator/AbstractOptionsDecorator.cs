using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class AbstractOptionsDecorator : ICar
    {
        protected OptionStrategy _optionStrategy;
        protected ICar _car;
        protected List<ICar> _optionsDescription;
        public List<ICar> OptionsDescription
        {
            get => _optionsDescription; set => _optionsDescription = value;
        }

        public string Description { get; set; }
        public double Price { get; set; }


        public List<ICar> GetOptions()
        {
            _optionsDescription = _car.GetOptions();
            _optionsDescription.Add(this);
            return _optionsDescription;
        }

        public void GetOptionInfo(OptionStrategy optionStrategy)
        {
            this._optionStrategy = optionStrategy;
            _optionStrategy.GetDetail(this);
        }

        public double GetCost()
        {
            return Price;
        }

        public AbstractOptionsDecorator(ICar car)
        {
            _optionsDescription = new List<ICar>();
            this._car = car;
        }
    }
}
