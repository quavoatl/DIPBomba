using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car daciaLogan = new OldCar();
            Car toyotaAuris = new NewCar();
            // car without euro pollution standard tax added

            ICarVisitor euro3TaxVisitor = new Euro3TaxVisitor();
            ICarVisitor euro6TaxVisitor = new Euro6TaxVisitor();

            Console.WriteLine(daciaLogan.Price);
            Console.WriteLine(toyotaAuris.Price);

            Console.WriteLine("**************");

            daciaLogan.Accept(euro3TaxVisitor);
            toyotaAuris.Accept(euro6TaxVisitor);
            Console.WriteLine(daciaLogan.Price);
            Console.WriteLine(toyotaAuris.Price);
        }
    }
}
