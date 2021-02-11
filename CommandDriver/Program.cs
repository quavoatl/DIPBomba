using System;
using System.Collections.Generic;
using BookModel;
using CartComponentBackup;
using CommandsComponent;
using DataStorage;
using ShopComponent;

namespace CommandDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            IShop shop = new Shop(new DataStorageManager());
            ICart userCart = new Cart(shop);

            ICommandManager commandManager = new CommandManager();

            ListRemainingBooksInShop(shop);
            Console.WriteLine("Add a book to your shopping list: ");

            var id = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            commandManager.ExecuteCommand(new AddToShoppingCartCommand(userCart, shop.GetBooks().Find(b => b.Id.Equals(id))));
            ListShoppingCartOfUser(userCart);
            ListRemainingBooksInShop(shop);

            commandManager.UndoLastCommand();
            ListShoppingCartOfUser(userCart);
            ListRemainingBooksInShop(shop);

        }

        static void ListDetailsOfShoppingCart(List<Book> listOfBooks)
        {
            foreach (var book in listOfBooks)
            {
                Console.WriteLine($"Book id: {book.Id} / Name: {book.Name} / Quantity: {book.Quantity}");
            }
        }

        static void ListShoppingCartOfUser(ICart cart)
        {
            Console.Write($"User has: {cart.GetItemsInCart()} items in cart");
            Console.WriteLine();

        }

        static void ListRemainingBooksInShop(IShop shop)
        {
            var shopItems = shop.GetBooks();
            foreach (var shopItem in shopItems)
            {
                Console.WriteLine($"Book ID: {shopItem.Id} / book name: {shopItem.Name} / book quantity: {shopItem.Quantity}");
            }
            Console.WriteLine();
        }
    }
}
