using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommandManager
    {
        void ExecuteCommand(ICommand command);
        void UndoLastCommand();
    }
}
