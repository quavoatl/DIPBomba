using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class SamsungTelevision : ITelevision
    {
        public string Type { get; set; }
        public void TurnOf()
        {
            Console.WriteLine($"Turning off the {Type} TV...");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Powering up the {Type} TV...");
        }

        public SamsungTelevision(string name)
        {
            this.Type = name;
        }
    }
}
