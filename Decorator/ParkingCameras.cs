using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ParkingCameras : AbstractOptionsDecorator
    {
        public ParkingCameras(ICar car) : base(car)
        {
            this.Description = "Nice Parking Cameras";
            this.Price = 1500;
        }

    }
}
