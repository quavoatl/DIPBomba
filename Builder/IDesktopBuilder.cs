using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IDesktopBuilder
    {
        void BuildMotherboard();
        void BuildCPU();
        void BuildGraphicsCard();
        void BuildFansSystem();
        Desktop GetDesktop();

    }

}
