using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.DesktopComponents.DesktopTypes
{
    public abstract class Desktop
    {
        protected ICpu _cpu;
        protected IMotherBoard _motherBoard;
        protected IVideoCard _videoCard;

        protected Desktop(ICpu cpu, IMotherBoard motherBoard, IVideoCard videoCard)
        {
            _cpu = cpu;
            _motherBoard = motherBoard;
            _videoCard = videoCard;
        }
        public virtual void ShowDesktopSpecifications()
        {
            _cpu.PrintCpuDescription();
            _motherBoard.PrintMotherboardDescription();
            _videoCard.PrintVideoCardDescription();
        }
    }
}
