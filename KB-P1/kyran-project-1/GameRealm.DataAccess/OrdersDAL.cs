using Microsoft.EntityFrameworkCore;
using GameRealm.DataAccess.Model;
using GameRealm.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GameRealm.DataAccess
{
    public class OrdersDAL
        //customer data access library
    {
        public void SaveOrder(IDataOrder order, ICustomer customer, IDataStore store)
        {
            using Game_RealmContext context = new Game_RealmContext();
            var O_Orders = new Orders();
            // add BusinessLogic Order to DBOrders
            O_Orders.CustomerId = customer.CustomerId;
            O_Orders.StoreId = store.StoreId;
            O_Orders.Checkout = order.Total;

            O_Orders.Time = DateTime.Now; // local time


            context.Add(O_Orders);
            context.SaveChanges();
        }

        public void SaveOrder(Orders order, ICustomer customer, IDataStore store)
        {
            using Game_RealmContext context = new Game_RealmContext();
            var O_Orders = new Orders();
            // add BusinessLogic Order to DBOrders
            O_Orders.CustomerId = customer.CustomerId;
            O_Orders.StoreId = store.StoreId;
            O_Orders.Checkout = order.Checkout;

            O_Orders.Time = DateTime.Now; // local time


            context.Add(O_Orders);
            context.SaveChanges();
        }

        public List<Orders> LoadOrders()
        {
            using Game_RealmContext context = new Game_RealmContext();
            return context.Orders.Include("Orderlines").Include("Customers").ToList();
        }
    }
}
