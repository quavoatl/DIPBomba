using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeV2
{
    public class ShapeStorage
    {
        public static Dictionary<int, Shape> ShapeDictionary = new Dictionary<int, Shape>();

        public static Shape GetCachedShape(int id)
        {
            Shape cachedShape = ShapeDictionary[id];
            int hash = cachedShape.GetHashCode();

            
            return (Shape) cachedShape.Clone();
        }
    }
}
