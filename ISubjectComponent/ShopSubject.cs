using System;
using System.Collections.Generic;
using System.Text;
using ObserverComponent;

namespace ISubjectComponent
{
    public class ShopSubject : IShopSubject
    {
        private List<IShopObserver> _listOfObservers;
        private List<string> _listOfAvailableItems;

        public ShopSubject()
        {
            _listOfObservers = new List<IShopObserver>();
            _listOfAvailableItems = new List<string>();
        }

        public void Subscribe(IShopObserver observer)
        {
            _listOfObservers.Add(observer);
        }

        public void UpdateListOfItems(List<string> items)
        {
            _listOfAvailableItems.AddRange(items);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _listOfObservers)
            {
                observer.Notify(_listOfAvailableItems);
            }
        }
    }
}
