using System;
using System.Collections.Generic;
using ObserverComponent;

namespace ISubjectComponent
{
    public interface IShopSubject
    {
        void Subscribe(IShopObserver observer);
        void UpdateListOfItems(List<string> items);
        void NotifyObservers();
    }
}
