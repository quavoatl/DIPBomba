using System;
using System.Collections.Generic;
using System.Text;
using PrintComponent;

namespace PrintOfficeDocumentClient
{
    public class PrintOfficeDocument : PrintDocumentTemplate
    {
        public override void PrintHeader()
        {
            Console.WriteLine("----This is the Office Document Header");
        }

        public override void PrintBody()
        {
            Console.WriteLine("--This is the Office Document Body");
        }
    }
}
