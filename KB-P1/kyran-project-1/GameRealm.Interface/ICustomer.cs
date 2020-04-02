using System;

namespace GameRealm.Interface
{
    public interface ICustomer
    {
        public int CustomerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
