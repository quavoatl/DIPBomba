using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class DesktopConfigurationDirector
    {
        private IDesktopBuilder _builder = null;

        public DesktopConfigurationDirector(IDesktopBuilder builder)
        {
            _builder = builder;
        }

        public Desktop BuildDesktop()
        {
            _builder.BuildCPU();
            _builder.BuildFansSystem();
            _builder.BuildGraphicsCard();
            _builder.BuildMotherboard();

            return _builder.GetDesktop();
        }
    }
}
