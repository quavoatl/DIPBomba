﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
