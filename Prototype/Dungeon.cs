using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Dungeon : AbstractBaseLevel
    {
        public Dungeon(string name, int diff, int npc, AbstractCurrentPlayer player) : base(name, diff, npc, player) { }

        public override string ShowInfoAboutTheLevel()
        {
            return $"This map is: {Name}, has a difficulty of: {Difficulty} and a number of npcs: {NumberOfNPCs} / " +
                   $"player info: {CurrentPlayer.Name} / {CurrentPlayer.Id}";
        }

    }
}
