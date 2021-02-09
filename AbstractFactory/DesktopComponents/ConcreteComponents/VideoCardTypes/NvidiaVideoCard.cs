using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.DesktopComponents.ConcreteComponents.VideoCardTypes
{
    public class NvidiaVideoCard : IVideoCard
    {
        public void PrintVideoCardDescription()
        {
            Console.WriteLine("You selected a Nvidia Video Card");
        }
    }
}
