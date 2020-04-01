using Microsoft.EntityFrameworkCore;
using GameRealm.DataAccess.Model;
using GameRealm.Interface;
using GameRealm.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameRealm.DataAccess
{
    public class InventoryDAL
        //customer data access library
    {/*
        public void SaveInventory(IDataInventory inventory, IDataProduct product, IDataStore store)
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            var I_Inventory = new Inventory();
            // add BusinessLogic Inventory to DbInventory
            I_Inventory.ProductId = product.ProductId;
            I_Inventory.StoreId = store.StoreId;

            I_Inventory.Quantity = inventory.Quantity;


            context.Add(I_Inventory);
            context.SaveChanges();
        }

       *//* public List<Inventorys> LoadInventorys()
        {
            using DbRestaurantContext context = new DbRestaurantContext();
            return context.Inventorys.ToList();

        }*/


    }
}
