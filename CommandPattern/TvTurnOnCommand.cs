using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TvTurnOnCommand : ICommand
    {
        protected ITelevision _tv;

        public TvTurnOnCommand(ITelevision tv)
        {
            this._tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }

        public void Undo()
        {
            _tv.TurnOf();
        }
    }
}
