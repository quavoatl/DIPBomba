using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.DesktopComponents.ConcreteComponents
{
    public class IntelCpu : ICpu
    {
        public void PrintCpuDescription()
        {
            Console.WriteLine("You selected an Intel CPU");
        }
    }
}
