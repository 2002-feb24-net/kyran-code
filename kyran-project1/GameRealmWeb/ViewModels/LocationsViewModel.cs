using GameRealm.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRealmWeb.ViewModels
{
    public class LocationsViewModel
    {
        public string uName { get; set; }
        public string uLocation { get; set; }
        public List<Games> Games{get; set;}
        public List<Orders> Orders { get; set; }
        public List<Locations> uLoc { get; set; }
    }
}
