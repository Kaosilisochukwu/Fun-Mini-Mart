using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMartLibrary
{
    public enum Status
    {
        Sold,
        Saved,
        Pending
    }
    public class Order
    {
        public int UserId { get; }  
        public int ProductId { get; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string SoldBy { get; }
        public DateTime DateSold { get; set; }
        public Status SalesStatus { get; set; }
    }
}
