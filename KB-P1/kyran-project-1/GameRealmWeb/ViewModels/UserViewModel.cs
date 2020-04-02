using GameRealm.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameRealmWeb.ViewModels
{
    public class UserViewModel
    {

		public UserViewModel()
		{ }
		
		public User User { get; set; }
		public List<Games> Cart { get; set; }
		public List<Orders> OrderList { get; set; }
		public List<Locations> locationList { get; set; }
		public List<Games> gameList { get; set; }
		public long storeID { get; set; }
		public long GameID { get; set; }
	}
}
