using System;
using BookModel;

namespace CartComponentBackup
{
    public interface ICart
    {
        void IncreaseShoppingCartItems(Book book);
        void DecreaseShoppingCartItems(Book book);
        void DecreaseWishListItems(Book book);
        void IncreaseWishListItems(Book book);
        int GetItemsInCart();
        int GetItemsInWishList();
    }
}
