using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class DatabaseManagerDeleteProxy : IDatabaseManager
    {
        public User CurrentUser { get; set; }

        public void ExecuteSomeQuery(string query)
        {
            if (CurrentUser.Username.Equals("admin") && CurrentUser.Password.Equals("admin"))
            {
                Console.WriteLine("Delete query completed");
            }
            else
            {
                Console.WriteLine("Your delete query was not permitted");
            }
        }
    }
}
