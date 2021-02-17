using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
          ICar dacia = new AutomaticWindows(new ParkingCameras(new Dacia("Logan MCV",5200)));
          dacia.GetOptions();
          dacia.GetOptionInfo(new DescStrategy());
          dacia.GetOptionInfo(new PriceStrategy());
        }
    }
}
