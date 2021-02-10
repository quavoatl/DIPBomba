using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("x", "y");
            IDatabaseManager databaseManager = new DatabaseManager(user);
            databaseManager.ExecuteSomeQuery("Insert");
            databaseManager.ExecuteSomeQuery("Delete");

            Console.WriteLine("***************");

            User user2 = new User("admin", "admin");
            databaseManager = new DatabaseManager(user2, new DatabaseManagerDeleteProxy());
            databaseManager.ExecuteSomeQuery("Insert");
            databaseManager.ExecuteSomeQuery("Delete");
        }
    }
}
