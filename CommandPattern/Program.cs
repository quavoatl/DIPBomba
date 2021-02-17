using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommandManager commandManager = new RemoteDevice();
            commandManager.ExecuteCommand(new TvTurnOnCommand(new SamsungTelevision("Samsung 43 Inches 4k")));
            commandManager.UndoLastCommand();
        }
    }
}
 