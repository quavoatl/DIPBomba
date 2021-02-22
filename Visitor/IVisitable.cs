namespace Visitor
{
    public interface IVisitable
    {
        void Accept(ICarVisitor visitor);
    }

}