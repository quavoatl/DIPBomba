using System.Collections.Generic;
using Composite.Interfaces;
using static System.Console;

namespace Composite.ConcreteClasses
{
    public class Menu : AbstractMenuComponent
    {
        private string _name;
        private string _description;
        private List<AbstractMenuComponent> _menuComponents;

        public List<AbstractMenuComponent> MenuComponents { get=> _menuComponents; set=> _menuComponents =value; }
        public Menu(string name, string description)
        {
            this._name = name;
            this._description = description;
            this._menuComponents = new List<AbstractMenuComponent>();
        }

        public override void add(AbstractMenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override object GetMenuComponent(int i)
        {
            return _menuComponents[i];
        }

        public override void Print()
        {
            WriteLine($"Menu name: {_name} \n" +
                      $"  Short description: {_description}");
            foreach(var component in _menuComponents)
            {
                component.Print();
            }
            WriteLine();
        }

    }
}
