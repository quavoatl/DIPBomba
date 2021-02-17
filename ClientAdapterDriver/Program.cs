using System;

namespace ClientAdapterDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse("OldType");

            IMouseConnection mouseConnection = new OldMouseConnectionAdapter(mouse);
            mouseConnection.ConnectMouse();
        }
    }
}
