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

        public bool alwaysTrue = true;

        public double? minCalories = 0;
        public double? maxCalories = 0;
        public double? minPrice = 0;
        public double? maxPrice = 0;

        /// <summary>
        /// The current search terms.
        /// </summary>
        public string searchTerms { get; set; } = "";

        /// <summary>
        /// The filtered item types
        /// </summary>
        public string[] itemTypes { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page.
        /// </summary>
        public void OnGet(string SearchTerms, string[] ItemTypes, double? CaloricIntakeMin, double? CaloricIntakeMax, double? PriceMin, double? PriceMax)
        {
            entrees = new List<Entree>();
            sides = new List<Side>();
            drinks = new List<Drink>();
            searchTerms = SearchTerms;
            itemTypes = ItemTypes;
            minCalories = CaloricIntakeMin;
            maxCalories = CaloricIntakeMax;
            minPrice = PriceMin;
            maxPrice = PriceMax;
            IEnumerable<IOrderItem> list = Menu.FullMenu();
            list = Menu.Search(searchTerms);
            IEnumerable<IOrderItem> newList = Menu.FilterByItemType(list, itemTypes);
            IEnumerable<IOrderItem> newListTwo = Menu.FilterByCalories(newList, CaloricIntakeMin, CaloricIntakeMax);
            IEnumerable<IOrderItem> newListThree = Menu.FilterByCalories(newListTwo, PriceMin, PriceMax);
            foreach (IOrderItem i in newListThree)
            {
                if (i is Entree e)
                {
                    entrees.Add(e);
                }
                if (i is Side s)
                {
                    sides.Add(s);
                }
                if (i is Drink d)
                {
                    drinks.Add(d);
                }
            }
        }
    }
}

