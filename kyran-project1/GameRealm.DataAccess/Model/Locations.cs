using System;
using System.Collections.Generic;

namespace GameRealm.DataAccess.Model
{
    public partial class Locations
    {
        public Locations()
        {
            Inventory = new HashSet<Inventory>();
            Orders = new HashSet<Orders>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
