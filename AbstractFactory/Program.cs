using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.DesktopTypes;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDesktopFactory desktopFactory = new OfficeDesktopFactory();

            Desktop desktop = new OfficeDesktop(desktopFactory.CreateCpu(), desktopFactory.CreateMotherBoard(),
                desktopFactory.CreateVideoCard());

            desktop.ShowDesktopSpecifications();

            Console.ReadKey();

        }
    }
}
