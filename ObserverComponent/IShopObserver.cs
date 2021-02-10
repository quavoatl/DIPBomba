using System;
using System.Collections.Generic;

namespace ObserverComponent
{
    public interface IShopObserver
    {
        List<string> GetCartItems();
        void Notify(List<string> items);
    }
}
