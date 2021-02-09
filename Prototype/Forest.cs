using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Forest : AbstractBaseLevel
    {
        public Forest(string name, int diff, int npc, AbstractCurrentPlayer player) : base(name,diff,npc,player) { }

        public override string ShowInfoAboutTheLevel()
        {
            return $"The name of this map: {Name}, with a difficulty of: {Difficulty}, NPCs: {NumberOfNPCs} / " +
                   $"player details: {CurrentPlayer.Name} / {CurrentPlayer.Id}";
        }

        
    }
}
