using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMartLibrary
{
    public class Product
    {
        public int ProductId { get; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public string AddedBy { get; }
        public DateTime DateAdded { get; set; }
    }
}
