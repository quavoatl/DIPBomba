﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.DesktopComponents.Interfaces;

namespace AbstractFactory.DesktopComponents.ConcreteComponents.MotherBoardTypes
{
    public class GigabyteMotherBoard : IMotherBoard
    {
        public void PrintMotherboardDescription()
        {
            Console.WriteLine("You selected Gigabyte MotherBoard");
        }
    }
}
