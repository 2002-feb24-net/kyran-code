using Microsoft.EntityFrameworkCore;
using GameRealm.DataAccess.Model;
using GameRealm.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameRealm.DataAccess
{
    public class LocationsDAL
    //customer data access library
    {
        public void SaveStore(IDataStore store)
        {
            using Game_RealmContext context = new Game_RealmContext();
            var S_Stores = new Locations();
            // add BusinessLogic Store to DbStores
            S_Stores.StoreName = store.StoreName;
            S_Stores.Street = store.Street;
            S_Stores.City = store.City;
            S_Stores.State = store.State;
            S_Stores.ZipCode = store.Zipcode;


            context.Add(S_Stores);
            context.SaveChanges();
        }

        public void InitializeStore(Locations S_Stores, IDataStore store)
        {
            using Game_RealmContext context = new Game_RealmContext();
            store.StoreName = S_Stores.StoreName;
            store.Street = S_Stores.Street;
            store.City = S_Stores.City;
            store.State = S_Stores.State;
            store.Zipcode = S_Stores.ZipCode;
            store.StoreId = S_Stores.StoreId;
        }

        public List<Locations> LoadAllStores()
        {
            using Game_RealmContext context = new Game_RealmContext();
            return context.Locations.ToList();

        }

        public Locations LoadStoreByID(int storeID)
        {
            using Game_RealmContext context = new Game_RealmContext();

            var storeMatched = from store in context.Locations
                               where store.StoreId == storeID
                               select store;

            return storeMatched.First();
        }
    }
}
