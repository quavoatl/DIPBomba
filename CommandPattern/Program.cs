using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteDevice remoteDevice = new RemoteDevice(new TvTurnOnCommand(new SamsungTelevision("Samsung 43 Inches 4k")));
            remoteDevice.PressButton();
        }
    }
}
