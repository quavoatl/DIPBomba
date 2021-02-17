using System;
using System.Collections.Generic;
using System.Text;
using BookModel;
using ShopComponent;

namespace CartComponentBackup
{
    public class Cart : ICart
    {
        private IShop _shop;
        private List<int> _shoppingCart;
        private List<int> _wishList;

        public Cart(IShop shop)
        {
            _shop = shop;
            _shoppingCart = new List<int>();
            _wishList = new List<int>();
        }

        public void IncreaseShoppingCartItems(Book book)
        {
            _shop.DecreaseBookCount(book.Id);
            _shoppingCart.Add(book.Id);
        }

        public void DecreaseShoppingCartItems(Book book)
        {
            _shop.IncreaseBookCount(book.Id);
            _shoppingCart.Remove(book.Id);
        }

        public void DecreaseWishListItems(Book book)
        {
            _shop.DecreaseBookCount(book.Id);
            _wishList.Add(book.Id);
        }

        public void IncreaseWishListItems(Book book)
        {
            _shop.IncreaseBookCount(book.Id);
            _wishList.Remove(book.Id);
        }

        public int GetItemsInCart()
        {
            return _shoppingCart.Count;
        }

        public int GetItemsInWishList()
        {
            return _wishList.Count;
        }
    }
}
