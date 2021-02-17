using System;

namespace PrintComponent
{
    public abstract class PrintDocumentTemplate
    {
        private void PrintTemplate()
        {
            PrintLogo();
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public void PrintDocument()
        {
            PrintTemplate();
        }

        private void PrintLogo()
        {
            Console.WriteLine("------ This is the default Logo -------");
        }

        public abstract void PrintHeader();
        public abstract void PrintBody();

        private void PrintFooter()
        {
            Console.WriteLine("------ Default Footer -------");
        }
    }
}
