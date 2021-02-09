using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class AbstractBaseLevel : ICloneable
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int NumberOfNPCs { get; set; }
        public AbstractCurrentPlayer CurrentPlayer { get; set; }

        protected AbstractBaseLevel(string name, int difficulty, int numberOfNpCs, AbstractCurrentPlayer currentPlayer)
        {
            Name = name;
            Difficulty = difficulty;
            NumberOfNPCs = numberOfNpCs;
            CurrentPlayer = currentPlayer;
        }

        public abstract string ShowInfoAboutTheLevel();

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
