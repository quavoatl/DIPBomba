using System;
using System.Collections.Generic;
using System.Text;

namespace State2.Interfaces
{
    public interface ICar
    {
        string Model { get; set; }
        AbstractGear CurrentGear { get; set; }
        List<AbstractGear> Gears { get; set; }
        ICarState CurrentState { get; set; }

        ICarState PowerUpState { get; set; }
        ICarState PowerOffState { get; set; }
        ICarState SwitchGearUpState { get; set; }
        ICarState SwitchGearDownState { get; set; }

        void PowerUp();
        void PowerOff();
        void SwitchGearUp();
        void SwitchGearDown();
    }
}
