using System;

namespace PrototypeV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            ShapeStorage.ShapeDictionary.Add(circle.Id, circle);

            Shape rectangle = new Rectangle();
            ShapeStorage.ShapeDictionary.Add(rectangle.Id, rectangle);

            Shape square = new Square();
            ShapeStorage.ShapeDictionary.Add(square.Id, square);

            circle.Draw();
            rectangle.Draw();
            square.Draw();

            Console.WriteLine("*********************");
            Shape cachedCircle = ShapeStorage.GetCachedShape(3);

            cachedCircle.Draw();
            circle.Draw();
            Console.ReadKey();
        }
    }
}
