using System;
using System.Collections.Generic;
using System.Text;

namespace GameRealm.Interface
{
    public interface IDataStore
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}
