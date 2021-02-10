using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAdapterDriver
{
    public class OldMouseConnectionAdapter: IMouseConnection
    {
        private Mouse _mouse;

        public OldMouseConnectionAdapter(Mouse mouse)
        {
            _mouse = mouse;
            if(_mouse.SocketType.Equals("OldType")) _mouse.SocketType = "NewType";
            // this acts like the middle component between your old mouse and
            // the Motherboard Socket which is a newer type
        }

        public void ConnectMouse()
        {
            if(_mouse.SocketType.Equals("NewType")) Console.WriteLine("Old mouse connected to Motherboard using adapter");
        }
    }
}
