using System;
using System.Collections.Generic;
using System.Text;
using GameRealm.Interface;

namespace GameRealm.Library
{
    public class Customer : User, ICustomer
    {
        // implements username and password validation from User
        // have to override username methods because using Full name ("FirstName LastName")
        // otherwise methods would talk about username when user inputs full name
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int CustomerId { get; set; }

        public Customer( string fName, string lName, string uniqueUsername, string password)
            // registers a customer, can load data from existing customer in db
        {
            firstName = fName;
            lastName = lName;
            Username = uniqueUsername;
            Password = password;
            /*Username = uniqueUsername;
            Password = password;*/

        }

        static string SearchCustomerByName (string cname)
        {
            //connect to database get loaded list
            throw new NotImplementedException();
        }

        


    }
}
