using System;
using System.Collections.Generic;
using System.Text;
using BookModel;
using DataStorage;

namespace ShopComponent
{
    public class Shop : IShop
    {
        private IDataStorage _dataStorage;

        public Shop(IDataStorage dataStorage)
        {
            _dataStorage = dataStorage;
        }

        public List<Book> GetBooks()
        {
            return _dataStorage.GetBooks();
        }

        public Book GetBook(int id)
        {
            return _dataStorage.GetBook(id);
        }

        public int DecreaseBookCount(int id)
        {
            var book = GetBook(id);
            book.Quantity = book.Quantity - 1;

            return book.Quantity;
        }

        public int IncreaseBookCount(int id)
        {
            var book = GetBook(id);
            book.Quantity = book.Quantity + 1;

            return book.Quantity;
        }
    }
}
