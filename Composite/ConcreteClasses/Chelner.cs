using System;
using System.Collections.Generic;
using System.Text;
using Composite.Interfaces;

namespace Composite.ConcreteClasses
{
    public class Chelner
    {
        private ISpecification _specification;
        private List<AbstractMenuComponent> _allMenus;
        public Chelner(List<AbstractMenuComponent> allMenus)
        {
            this._allMenus = allMenus;
        }

        public void Print(ISpecification specification = null)
        {
            this._specification = specification;
            if (specification == null)
            {
                foreach (var i in _allMenus) i.Print();
            }
            else PrintSpecification();
        }

        private void PrintSpecification()
        {
            foreach (var menu in _allMenus)
            {
                if (CheckIsMenu(menu)) PrintMenuItemBySpecification(menu);
            }
        }

        private bool CheckIsMenu(AbstractMenuComponent menu)
        {
            if (menu.GetType().Name.Equals("Menu")) return true;
            else return false;
        }

        private void PrintMenuItemBySpecification(AbstractMenuComponent menu)
        {
            Menu menuCopy = (Menu)menu;
            for (int i = 0; i < menuCopy.MenuComponents.Count; i++)
            {
                try
                {
                    _specification.IsSatisfied(menuCopy.MenuComponents[i]);
                }
                catch (Exception ex)
                {
                    if (CheckIsMenu(menuCopy.MenuComponents[i])) PrintMenuItemBySpecification(menuCopy.MenuComponents[i]);
                }
            }
        }
    }
}
