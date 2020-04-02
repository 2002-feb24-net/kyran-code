using Microsoft.EntityFrameworkCore;
using GameRealm.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameRealm.DataAccess
{
    public class CustomerRepository : GameRepository<Customer>
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        /*public List<Customers> LoadCustomersByName(string fullName)
        {
            using DbRestaurantContext context = new DbRestaurantContext();

            var customersMatched = from customer in context.Customers
                                   where customer.FullName == fullName
                                   select customer;

            return customersMatched.ToList();
        }*/
    }
}
