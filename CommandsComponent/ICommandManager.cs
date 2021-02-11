using System;
using System.Collections.Generic;
using System.Text;

namespace CommandsComponent
{
    public interface ICommandManager
    {
        void ExecuteCommand(ICommand command);
        void UndoLastCommand();
    }
}
