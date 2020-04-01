using System;
using System.Collections.Generic;

namespace GameRealm.DataAccess.Model
{
    public partial class Games
    {
        public Games()
        {
            Inventory = new HashSet<Inventory>();
            Orderline = new HashSet<Orderline>();
        }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime? Release { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orderline> Orderline { get; set; }
    }
}
