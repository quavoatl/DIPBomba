using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public interface IDatabaseManager
    {
        public User CurrentUser { get; set; }
        void ExecuteSomeQuery(string query);
    }
}
