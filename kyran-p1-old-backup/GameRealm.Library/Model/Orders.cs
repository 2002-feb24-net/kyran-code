
using System;
using System.Collections.Generic;
using GameRealm.Interface;

namespace GameRealm.Library
{
    public class Orders : IOrder, IDataOrder
    {
        // hold items and prices and additionally total

        // each item and price/cost
        // each product ordered and its price
        public List<Games> AllProductsOnOrder { get; set; }
     
    
        public User WhoOrdered { get; set; } // link each order to one specific customer
                                 // probably other people without access should not see who ordered what (protect privacy)
        
        public Orders(Games productAndPrice, User userPlacingOrder)
            // this only constructs an order with one product and price in it, but need a method to add additional products to order
            // ensures there are no empty orders (bc that is nonsensical)
        {
            /*AllProductsOnOrder = new List<Product> (); // instantiate list
            AllProductsOnOrder.Add(productAndPrice);*/
            // should add to a list of Dictionaries
            // Each dictionary has a product name (unique) and a potentionally duplicate price

            // need a list to spit out the line by line summary of the order

            // can total the prices to give the order total

            // need to handle user linked to order in another method
            // also save Order on user to keep order history on each user
            // each user should have an order history member

            /*WhoOrdered = userPlacingOrder;

            foreach (var product in AllProductsOnOrder)
                Total += product.Cost;*/
            Total = productAndPrice.Cost;
        }

        public void AddToOrder(Games productAndPrice)
        {
            AllProductsOnOrder.Add(productAndPrice);
        }

        // calculate sum of all products in the order
        // need private backing field
        private decimal? _total;
        public decimal? Total
        {
            get;

            set;
           /* { buggy
                foreach (var product in AllProductsOnOrder)
                        _total += product.Cost;
            }*/
        }

        public DateTime TimeOrdered { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int OrderId { get; set; }
    }
}
