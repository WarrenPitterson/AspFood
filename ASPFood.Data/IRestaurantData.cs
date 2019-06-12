using AspFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASPFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Warren's Noodles", Location = "Manchester", Food = FoodType.Chinese },
                new Restaurant { Id = 2, Name = "Ben's Banging Curries", Location = "Manchester", Food = FoodType.Indian },
                new Restaurant { Id = 3, Name = "Peter's Pizza World", Location = "Manchester", Food = FoodType.Pizza }
            };
        }


        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }

}
