using System;
using System.Collections.Generic;
using System.Text;

namespace State2.Interfaces
{
    public abstract class AbstractGear 
    {
        private int _value;
        public int Value { get=> _value; set => this._value = value; }
        public AbstractGear(int gear)
        {
            this._value = gear;
        }
    }
}
