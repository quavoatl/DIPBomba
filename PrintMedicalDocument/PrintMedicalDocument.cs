using System;
using System.Collections.Generic;
using System.Text;
using PrintComponent;

namespace PrintMedicalDocumentClient
{
    public class PrintMedicalDocument : PrintDocumentTemplate
    {
        public override void PrintHeader()
        {
            Console.WriteLine("----This is the Medical Document Header");
        }

        public override void PrintBody()
        {
            Console.WriteLine("--This is the Medical Document Body");
        }
    }
}
