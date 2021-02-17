using System;
using System.Collections.Generic;
using BookModel;

namespace DataStorage
{
    public interface IDataStorage
    {
        Book GetBook(int id);
        List<Book> GetBooks();
    }
}
