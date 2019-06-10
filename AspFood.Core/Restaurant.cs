using System;

namespace AspFood.Core
{
    public class Restaurant
    {
        public int ID { get; set;}
        public string Name {get; set;}
        public string Location {get; set;}
        public FoodType Food { get; set; }

    }
}
