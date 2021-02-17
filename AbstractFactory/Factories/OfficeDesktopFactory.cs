using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.ConcreteComponents;
using AbstractFactory.DesktopComponents.ConcreteComponents.MotherBoardTypes;
using AbstractFactory.DesktopComponents.ConcreteComponents.VideoCardTypes;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.Factories
{
    public class OfficeDesktopFactory : IDesktopFactory
    {
        public ICpu CreateCpu()
        {
            return new AmdCpu();
        }

        public IMotherBoard CreateMotherBoard()
        {
            return new AsusMotherBoard();
        }

        public IVideoCard CreateVideoCard()
        {
            return new AmdVideoCard();
        }
    }
}
