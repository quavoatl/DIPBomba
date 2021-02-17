using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookModel;

namespace DataStorage
{
    public class DataStorageManager : IDataStorage
    {
        private List<Book> _booksInDb;

        public DataStorageManager()
        {
            _booksInDb = new List<Book>()
            {
                new Book(1, "xyz", 10),
                new Book(2, "abc", 2)
            };
        }

        public Book GetBook(int id)
        {
            return _booksInDb.FirstOrDefault(b => b.Id.Equals(id));
        }

        public List<Book> GetBooks()
        {
            return _booksInDb;
        }
    }
}
