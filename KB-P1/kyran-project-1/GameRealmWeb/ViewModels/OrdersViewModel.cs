using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameRealm.DataAccess.Model;

namespace GameRealmWeb.ViewModels
{
    public class OrdersViewModel
    {
        public string Username { get; set; }
        public string Location { get; set; }
        public List<Orders> Orders { get; set; }

    }
}
