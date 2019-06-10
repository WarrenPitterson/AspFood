using AspFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASPFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { ID = 1, Name = "Warren's Noodles", Location = "Manchester", Food = FoodType.Chinese },
                new Restaurant { ID = 2, Name = "Ben's Banging Curries", Location = "Manchester", Food = FoodType.Indian },
                new Restaurant { ID = 3, Name = "Peeta's Pizza World", Location = "Manchester", Food = FoodType.Pizza }
            };
        }


        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }

}
