using System;

namespace BuyService
{
    public class OrderedProduct
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderedDate { get; set; }
        public string OrderName { get; set; }
        public string Address { get; set; }
        public string Receiver { get; set; }
    }
}