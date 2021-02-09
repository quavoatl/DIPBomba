using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Desktop
    {
        private List<string> components = new List<string>();

        public void AddComponent(string component)
        {
            if (components != null)
            {
                components.Add(component);
            }
        }

        public void ListComponents()
        {
            foreach (var component in components)
            {
                Console.WriteLine($"Component: {component}");
            }
        }
    }
}
