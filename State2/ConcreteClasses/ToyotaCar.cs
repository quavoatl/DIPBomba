using System;
using System.Collections.Generic;
using System.Text;
using State2.Interfaces;
using State2.ConcreteStates;
using State2.ConcreteClasses.Gears;

namespace State2.ConcreteClasses
{
    public class ToyotaCar : ICar
    {
        private string _model;
        private ICarState _currentState; 
        private ICarState _powerUpState;
        private ICarState _powerOffState;
        private ICarState _switchGearUpState;
        private ICarState _switchGearDownState;
        private List<AbstractGear> _gears;
        private AbstractGear _currentGear;

        public string Model { get=> _model; set=> _model = value; }
        public List<AbstractGear> Gears { get => _gears; set => _gears = value; }
        public ICarState CurrentState { get => _currentState; set => _currentState = value; }
        public ICarState PowerUpState { get => _powerUpState; set => _powerUpState = value; }
        public ICarState PowerOffState { get => _powerOffState; set => _powerOffState = value; }
        public ICarState SwitchGearUpState { get => _switchGearUpState; set => _switchGearUpState = value; }
        public ICarState SwitchGearDownState { get => _switchGearDownState; set => _switchGearDownState = value; }
        public AbstractGear CurrentGear { get => _currentGear; set => _currentGear = value; }

        public ToyotaCar(string model)
        {
            _gears = new List<AbstractGear>(new AbstractGear[] { new FirstGear(1), new SecondGear(2), new ThirdGear(3), new FourthGear(4) });
            _powerUpState = new PowerUpState(this);
            _powerOffState = new PowerOffState(this);
            _switchGearUpState = new SwitchGearUpState(this);
            _switchGearDownState = new SwitchGearDownState(this);
            this._model = model;
            _currentState = PowerOffState;
            _currentGear = _gears[0];
        }

        public void PowerOff()
        {
            _currentState.PowerOff();
        }

        public void PowerUp()
        {
            _currentState.PowerUp();
        }

        public void SwitchGearUp()
        {
            _currentState.SwitchGearUp();
        }

        public void SwitchGearDown()
        {
            _currentState.SwitchGearDown();
        }
    }
}
