using System;
using System.Collections.Generic;
using System.Text;

namespace CommandsComponent
{
    public class CommandManager : ICommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();
        private ICommand _currentCommand;

        public CommandManager()
        {
        }

        public void ExecuteCommand(ICommand command)
        {
            _currentCommand = command;
            _commands.Push(_currentCommand);
            _currentCommand.Execute();
        }

        public void UndoLastCommand()
        {
            _currentCommand.Undo();
            _commands.Pop();
        }
    }
}
