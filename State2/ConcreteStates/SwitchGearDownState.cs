using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteStates
{
    public class SwitchGearDownState : ICarState
    {
        private ICar _car;
        public SwitchGearDownState(ICar car)
        {
            this._car = car;
        }

        public void PowerOff()
        {
            Console.WriteLine("Car is now off");
            _car.CurrentState = _car.PowerOffState;
            _car.CurrentGear = _car.Gears[0];
        }

        public void PowerUp()
        {
            Console.WriteLine("Car is already powered up");
        }

        public void SwitchGearUp()
        {
            _car.CurrentState = _car.SwitchGearUpState;
            _car.CurrentState.SwitchGearUp();
        }

        public void SwitchGearDown()
        {
            var currentGear = _car.Gears.IndexOf(_car.CurrentGear);
            if (currentGear - 1 >= 0)
            {
                _car.CurrentGear = _car.Gears[currentGear - 1];
                Console.WriteLine($"The car is now in: {_car.CurrentGear.Value}");
            }
            else
            {
                Console.WriteLine("You are already in the lowest gear available");
            }
        }
    }
}
