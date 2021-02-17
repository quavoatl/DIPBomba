using System;
using System.Collections.Generic;
using System.Text;
using BookModel;
using CartComponentBackup;

namespace CommandsComponent
{
    public class AddToShoppingCartCommand : ICommand
    {
        private ICart _cart;
        private Book _book;

        public AddToShoppingCartCommand(ICart cart, Book book)
        {
            _cart = cart;
            _book = book;
        }

        public void Execute()
        {
            _cart.IncreaseShoppingCartItems(_book);
        }

        public void Undo()
        {
            _cart.DecreaseShoppingCartItems(_book);
        }

        public bool CanExecute()
        {
            if (_book.Quantity > 0) return true;
            return false;
        }
    }
}
