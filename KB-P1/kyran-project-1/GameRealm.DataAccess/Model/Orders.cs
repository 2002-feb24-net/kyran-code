using System;
using System.Collections.Generic;

namespace GameRealm.DataAccess.Model
{
    public partial class Orders
    {
        public Orders()
        {
            Orderline = new HashSet<Orderline>();
        }

        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Time { get; set; }
        public decimal? Checkout { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Locations Store { get; set; }
        public virtual ICollection<Orderline> Orderline { get; set; }
    }
}
