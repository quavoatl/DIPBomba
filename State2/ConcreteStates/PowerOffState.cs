using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;

namespace State2.ConcreteStates
{
    public class PowerOffState : ICarState
    {
        private ICar _car;
        public PowerOffState(ICar car)
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
            Console.WriteLine($"Car has been powered up, current gear: {_car.CurrentGear.Value}");
            _car.CurrentState = _car.PowerUpState;
        }

        public void SwitchGearUp()
        {
            Console.WriteLine("Please power up the card first");
        }

        public void SwitchGearDown()
        {
            Console.WriteLine("Please power up the card first");
        }
    }
}
