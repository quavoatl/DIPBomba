using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

            AbstractBaseLevel forest = new Forest("Black Forest", 2, 5, new SkilledPlayer("mama", 1));
            AbstractBaseLevel dungeon = new Dungeon("Magic Dungeon", 3, 10, new NoobPlayer("tata", 2));

            Console.WriteLine(forest.GetHashCode() + " " + forest.ShowInfoAboutTheLevel());
            Console.WriteLine(dungeon.GetHashCode() + " " + dungeon.ShowInfoAboutTheLevel());
            Console.WriteLine();

            AbstractBaseLevel forestCopy = (AbstractBaseLevel)forest.Clone();
            AbstractBaseLevel dungeonCopy = (AbstractBaseLevel)dungeon.Clone();

            forestCopy.Difficulty = 99;

            Console.WriteLine("Copy of forest: " + forestCopy.GetHashCode() + " " + forestCopy.ShowInfoAboutTheLevel());
            Console.WriteLine("Copy of dungeon: " + dungeonCopy.GetHashCode() + " " + dungeonCopy.ShowInfoAboutTheLevel());
            Console.WriteLine("------------------");
            forestCopy.CurrentPlayer.Id = 2; //demonstrate reference type problem of shallow copy, to overcome this create a deep copy in Clone()
            Console.WriteLine(forest.GetHashCode() + " " + forest.ShowInfoAboutTheLevel());
            Console.WriteLine(dungeon.GetHashCode() + " " + dungeon.ShowInfoAboutTheLevel());
            Console.WriteLine();
            Console.WriteLine("Copy of forest: " + forestCopy.GetHashCode() + " " + forestCopy.ShowInfoAboutTheLevel());
            Console.WriteLine("Copy of dungeon: " + dungeonCopy.GetHashCode() + " " + dungeonCopy.ShowInfoAboutTheLevel());

            Console.ReadLine();
        }
    }
}
