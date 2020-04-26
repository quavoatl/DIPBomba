using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteStates
{
    public class SwitchGearUpState : ICarState
    {
        private ICar _car;
        public SwitchGearUpState(ICar car)
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
        }

        public void SwitchGearUp()
        {
            var currentGear = _car.Gears.IndexOf(_car.CurrentGear);
            if (!((currentGear + 1) >= _car.Gears.Count))
            {
                _car.CurrentGear = _car.Gears[currentGear + 1];
                Console.WriteLine($"The car is now in: {_car.CurrentGear.Value}");
            }
            else
            {
                Console.WriteLine("You are already in the highest gear available");
            }
        }

        public void SwitchGearDown()
        {
            _car.CurrentState = _car.SwitchGearDownState;
            _car.CurrentState.SwitchGearDown();
        }
    }
}
