using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class AbstractCurrentPlayer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public AbstractCurrentPlayer(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
