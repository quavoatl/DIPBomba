using System;
using PrintComponent;

namespace PrintOfficeDocumentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDocumentTemplate printer = new PrintOfficeDocument();
            printer.PrintDocument();
        }
    }
}
