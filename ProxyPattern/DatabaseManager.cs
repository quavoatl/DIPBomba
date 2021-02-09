using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class DatabaseManager : IDatabaseManager
    {
        public IDatabaseManager DatabaseManagerProxy { get; set ; }
        public User CurrentUser { get; set; }
        public DatabaseManager(User user,IDatabaseManager databaseManagerProxy = null)
        {
            this.CurrentUser = user;
            this.DatabaseManagerProxy = databaseManagerProxy;
            if(databaseManagerProxy != null) this.DatabaseManagerProxy.CurrentUser = this.CurrentUser;
        }

        public void ExecuteSomeQuery(string query)
        {
            if (query.Equals("Insert"))
            {
                Console.WriteLine("Insert query completed");
            }
            else if (query.Equals("Delete"))
            {
                try
                {
                    DatabaseManagerProxy.ExecuteSomeQuery(query);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Da-mi un proxy ca te fut in bot");
                }
            }
        }
    }
}

