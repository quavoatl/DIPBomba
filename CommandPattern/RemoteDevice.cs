using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class RemoteDevice : ICommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();
        private ICommand _currentCommand;

        public RemoteDevice()
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
