using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeV2
{
    public abstract class Shape : ICloneable
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Inside {Type} Draw() method / HashCode: {this.GetHashCode()}");
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
