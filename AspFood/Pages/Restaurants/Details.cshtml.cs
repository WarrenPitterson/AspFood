﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFood.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspFood.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        public Restaurant Restaurant { get; set; }
        public void OnGet(int restaurantId)
        {
            Restaurant = new Restaurant
            {
                Id = restaurantId
            };
        }
    }
}