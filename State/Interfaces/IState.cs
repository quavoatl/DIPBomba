using System;
using System.Collections.Generic;
using System.Text;

namespace State.Interfaces
{
    public interface IState
    {
        void ReadyForOperation();
        void AddMoney(double money);

        bool SelectSoda(AbstractSoda soda);
        void ReleaseSoda();
    }
}
