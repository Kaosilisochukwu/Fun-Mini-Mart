using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMartLibrary
{
    public enum Role
    {
        Customer,
        Admin
    }
    public class UserRole
    {
        public int UserId { get; }
        public Role RoleDescription { get; set; }
    }
}
