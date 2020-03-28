using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Dacia : ICar
    {
        protected List<ICar> optionsDescription;
        public List<ICar> OptionsDescription { get; set; }
        public string Description { get; set; }   
        public double Price { get; set; }   
        public List<ICar> GetOptions()
        {
           optionsDescription.Add(this);
           return optionsDescription;
        }

        public void GetOptionInfo(OptionStrategy optionStrategy)
        {
            throw new NotImplementedException();
        }

        public double GetCost()
        {
            return Price;
        }

        public Dacia(string description, double price)
        {
            optionsDescription = new List<ICar>();
            Description = description;
            Price = price;
        }
    }
}
