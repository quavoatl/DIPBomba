using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteStates
{
    public class PowerUpState : ICarState
    {
        private ICar _car;
        public PowerUpState(ICar car)
        {
            this._car = car;
        }

        public void PowerOff()
        {
            Console.WriteLine("Car is now off");
            _car.CurrentState = _car.PowerOffState;
        }

        public void PowerUp()
        {
            Console.WriteLine("Car is already powered up");
            _car.CurrentGear = _car.Gears[0];
        }

        public void SwitchGearUp()
        {
            Console.WriteLine("Switching the gear up...");
            _car.CurrentState = _car.SwitchGearUpState;
            _car.CurrentState.SwitchGearUp();
        }

        public void SwitchGearDown()
        {
            Console.WriteLine("Switching the gear down...");
            _car.CurrentState = _car.SwitchGearDownState;
            _car.CurrentState.SwitchGearDown();
        }
    }
}
