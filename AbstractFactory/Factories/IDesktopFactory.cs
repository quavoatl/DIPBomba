using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.DesktopTypes;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.Factories
{
    public enum DesktopType
    {
        Office,
        Gaming
    }

    public interface IDesktopFactory
    {
        ICpu CreateCpu();
        IMotherBoard CreateMotherBoard();
        IVideoCard CreateVideoCard();
    }
}
