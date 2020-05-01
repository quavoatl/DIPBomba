using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteDevice
    {
        private ICommand _command;

        public RemoteDevice(ICommand command)
        {
            this._command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
