/*
 * Author: Riley Smith
 * Class: Index.cshtml.cs
 * Purpose: Contains the functionality for the main page of the website. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Entree> entrees;
        public List<Side> sides;
        public List<Drink> drinks;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            entrees = new List<Entree>();
            sides = new List<Side>();
            drinks = new List<Drink>();
            foreach (IOrderItem i in Menu.Entrees())
            {
                if (i is Entree e)
                {
                    entrees.Add(e);
                }
            }
            foreach (IOrderItem i in Menu.Sides())
            {
                if (i is Side s)
                {
                    sides.Add(s);
                }

            }
            foreach (IOrderItem i in Menu.Drinks())
            {
                if (i is Drink d)
                {
                    drinks.Add(d);
                }
            }
        }
    }
}
