using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OfficeDesktop : IDesktopBuilder
    {
        private Desktop _desktop;

        public OfficeDesktop()
        {
            _desktop = new Desktop();
        }

        public void BuildMotherboard()
        {
            _desktop.AddComponent("Asus Office Motherboard");
        }

        public void BuildCPU()
        {
            _desktop.AddComponent("AMD R2600x");
        }

        public void BuildGraphicsCard()
        {
            _desktop.AddComponent("nVidia GTX 1050 Ti");
        }

        public void BuildFansSystem()
        {
            _desktop.AddComponent("2 fans for standard office desktop");
        }

        public Desktop GetDesktop()
        {
            return _desktop;
        }
    }
}
