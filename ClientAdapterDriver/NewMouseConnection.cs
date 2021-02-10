using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAdapterDriver
{
    public class NewMouseConnection : IMouseConnection
    {
        private Mouse _mouse;

        public NewMouseConnection(Mouse mouse)
        {
            _mouse = mouse;
        }

        public void ConnectMouse()
        {
            if (_mouse.SocketType.Equals("NewType"))
            {
                Console.WriteLine("Connected the mouse using the new socket type");
            }
            else
            {
                Console.WriteLine("Can't connect this mouse");
            }
        }
    }
}
