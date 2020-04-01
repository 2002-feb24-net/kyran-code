using GameRealm.Interface;
using System.Collections.Generic;
using System.Linq;
using GameRealm.Library;
using GameRealm.DataAccess.Model;

namespace GameRealm.DataAccess
{
    public class CustomerDAL
    //customer data access library
    {
        public void SaveCustomer(ICustomer customer)
        {
            using Game_RealmContext  ctx= new Game_RealmContext();
            var C_Customer = new Model.Customer();
            // add BusinessLogic Customer to DbCustomer
            C_Customer.FirstName = customer.firstName;
            C_Customer.LastName = customer.lastName;
            C_Customer.Password = customer.Password;
            C_Customer.UserName = customer.Username;


            ctx.Add(C_Customer);
            ctx.SaveChanges();
        }

        public List<Model.Customer> LoadAllCustomers()
        {
            using Game_RealmContext ctx = new Game_RealmContext();
            return ctx.Customer.ToList();

        }

        public Model.Customer LoadCustomerByID(int customerID)
        {
            using Game_RealmContext ctx = new Game_RealmContext();

            var customerMatched = from customer in ctx.Customer
                                   where customer.CustomerId == customerID
                                   select customer;

            return customerMatched.First();
        }

        public List<Model.Customer> LoadCustomersByName(string fName, string lName)
        {
            using Game_RealmContext ctx = new Game_RealmContext();

            var customersMatched = from customer in ctx.Customer
                                   where customer.FirstName == fName && customer.LastName == lName
                                   select customer;

            return customersMatched.ToList();
        }

        public int GetCustomerID(string username, string password)
        {
            using Game_RealmContext ctx = new Game_RealmContext();
            var customerIDList = from customer in ctx.Customer
                                 where username == customer.UserName
                                 && password == customer.Password
                                 select customer.CustomerId;
            var customerID = customerIDList.FirstOrDefault(); // unique combination so can return single, no duplicates possible from db
            return customerID;
        }
    }
}
