using System;

namespace InventoryService
{
    public class InventoryModel
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}