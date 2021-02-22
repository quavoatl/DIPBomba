namespace Visitor
{
    public class Euro3TaxVisitor : ICarVisitor
    {
        public void Visit(Car car)
        {
            car.Price = car.Price + 2000;
        }
    }
}