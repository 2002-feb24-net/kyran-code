using GameRealm.Interface;
using System.Collections.Generic;
using System.Linq;
using GameRealm.Library;
using GameRealm.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameRealm.DataAccess
{
    public class CustomerDAL
    //customer data access library
    {
        Game_RealmContext ctx = new Game_RealmContext();
        public void Add(Library.Customer customer)
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

        public Model.Customer LoadbyID(int customerID)
        {
            return ctx.Customer.Find(customerID);
        }

        public void Remove(int id)
        {
            var removeCust = ctx.Customer.Find(id);
            ctx.Customer.Remove(removeCust);
            ctx.SaveChanges();
        }
        public int AddCust(string fName, string lName, string username, string email, string pass)
        {
            var new_cust = new Model.Customer
            {
                FirstName = fName,
                Email = email,
                UserName = username,
                Password = pass,
                LastName = lName
            };
            try
            {
                ctx.Customer.Add(new_cust);
                ctx.SaveChanges();
            }
            catch (DbUpdateException)
            {
                Console.WriteLine("Email/username already exists");
            }
            return new_cust.CustomerId;
        }
    }
}
