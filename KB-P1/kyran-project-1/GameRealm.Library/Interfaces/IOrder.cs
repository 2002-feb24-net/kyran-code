using System;
using System.Collections.Generic;
using System.Text;

namespace GameRealm.Library
{
    public interface IOrder
    {
        List<Games> AllProductsOnOrder
        // each item and price/cost
        // each product ordered and its price
        { get; set; }

        User WhoOrdered  // link each order to one specific customer
                         // probably other people without access should not see who ordered what (protect privacy)
        { get; set; }

     
        
    }
}
