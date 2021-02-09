using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GamingDesktopBuilder : IDesktopBuilder
    {
        private Desktop _desktop;

        public GamingDesktopBuilder()
        {
            _desktop = new Desktop();
        }

        public void BuildMotherboard()
        {
            _desktop.AddComponent("Gigabyte Gaming Motherboard");
        }

        public void BuildCPU()
        {
           _desktop.AddComponent("Intel I7 9770k");
        }

        public void BuildGraphicsCard()
        {
            _desktop.AddComponent("nVidia GTX 3090");
        }

        public void BuildFansSystem()
        {
            _desktop.AddComponent("5 fans for gaming");
        }

        public Desktop GetDesktop()
        {
            return _desktop;
        }
    }
}
