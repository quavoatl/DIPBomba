using System;
using System.Collections.Generic;
using System.Text;

namespace State2.Interfaces
{
    public interface ICarState
    {
        void PowerUp();
        void PowerOff();
        void SwitchGearUp();
        void SwitchGearDown();
    }
}
