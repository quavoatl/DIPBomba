namespace Visitor
{
    public class Euro6TaxVisitor : ICarVisitor
    {
        public void Visit(Car car)
        {
            car.Price = car.Price + 500;
        }
    }
}