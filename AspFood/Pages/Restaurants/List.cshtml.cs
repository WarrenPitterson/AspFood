﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFood.Core;
using ASPFood.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace AspFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }


        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        public IEnumerable <Restaurant> Restaurant{ get; set; }

        [BindProperty (SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet(string searchTerm)
        {
           
            Message = config["Message"];
            Restaurant = restaurantData.GetRestaurantsByName(searchTerm);
        }
    }
}