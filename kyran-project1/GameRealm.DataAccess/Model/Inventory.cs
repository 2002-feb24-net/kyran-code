using System;
using System.Collections.Generic;

namespace GameRealm.DataAccess.Model
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Title { get; set; }

        public virtual Games Product { get; set; }
        public virtual Locations Store { get; set; }
    }
}
