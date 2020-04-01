using GameRealm.Interface;
using System;
using System.Collections.Generic;

namespace GameRealm.Library
{
    public class Games : IDataProduct
    {
        // make an object to hold hot wings and price, cola drink and price
        public int GameID { get; set; }
        public string GameName { get; set; }
        public decimal? Cost { get; set; }

        // previously had a dictionary, but the class already links Name and Price so do not need a dictionary

        public Games (string name, decimal? price)
        {
            GameName = name;
            Cost = price;

            //DecrementInventory();
        }






    }
}
