﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMartLibrary
{
    public class User
    {
        public int UserId { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        string Password { get; set; }
        public string Address { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
