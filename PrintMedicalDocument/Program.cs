using System;
using PrintComponent;

namespace PrintMedicalDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDocumentTemplate printer = new PrintMedicalDocumentClient.PrintMedicalDocument();
            printer.PrintDocument();
        }
    }
}
