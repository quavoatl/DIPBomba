using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.ConcreteComponents;
using AbstractFactory.DesktopComponents.ConcreteComponents.MotherBoardTypes;
using AbstractFactory.DesktopComponents.ConcreteComponents.VideoCardTypes;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.DesktopComponents.DesktopTypes
{
    public class OfficeDesktop : Desktop
    {
        public OfficeDesktop(ICpu cpu, IMotherBoard motherBoard, IVideoCard videoCard) : base(cpu, motherBoard, videoCard)
        {
        }
    }
}
