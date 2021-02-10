using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverComponent
{
    public class ShopObserver : IShopObserver
    {
        private List<string> _cartItems;
        private string _shopObserverKeyword;

        public ShopObserver(string keyword)
        {
            _cartItems = new List<string>();
            _shopObserverKeyword = keyword;
        }

        public List<string> GetCartItems()
        {
            return _cartItems;
        }

        public void Notify(List<string> items)
        {
            foreach (var item in items)
            {
                if(item.Contains(_shopObserverKeyword) && !_cartItems.Contains(item)) _cartItems.Add(item);
            }
        }
    }
}
