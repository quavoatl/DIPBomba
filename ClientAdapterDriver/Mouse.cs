using System;
using System.Collections.Generic;
using System.Text;

namespace ClientAdapterDriver
{
    public class Mouse
    {
        public string SocketType { get; set; }

        public Mouse(string socketType)
        {
            SocketType = socketType;
        }
       
    }
}
