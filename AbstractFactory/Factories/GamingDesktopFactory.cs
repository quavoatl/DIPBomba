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
    public class GamingDesktopFactory : IDesktopFactory
    {
        public ICpu CreateCpu()
        {
            return new IntelCpu();
        }

        public IMotherBoard CreateMotherBoard()
        {
            return new GigabyteMotherBoard();
        }

        public IVideoCard CreateVideoCard()
        {
            return new NvidiaVideoCard();
        }
    }
}
