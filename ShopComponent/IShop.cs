using System;
using System.Collections.Generic;
using BookModel;

namespace ShopComponent
{
    public interface IShop
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        int DecreaseBookCount(int id);
        int IncreaseBookCount(int id);


    }
}
