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
//using System.Windows.Documents.DocumentStructures;

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
            List<IOrderItem> list2 = new List<IOrderItem>();
            if (SearchTerms != null)
            {
                string[] searchTermList = SearchTerms.Split(' ');

                list = from item in Menu.FullMenu()
                       where item.Name != null && searchTermList.Any(s => (item.Name.Contains(s, StringComparison.InvariantCultureIgnoreCase)) || searchTermList.Any(s => item.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase)))
                       select item;
            }
            if (itemTypes != null && itemTypes.Length != 0)
            {
                    list = list.Where(item =>
                        item.ItemType != null &&
                        itemTypes.Contains(item.ItemType)
                        );
            }
            if (CaloricIntakeMin != null)
            {
                list = list.Where(item =>
                    item.Calories >= CaloricIntakeMin
                     );
            }
            if (CaloricIntakeMax != null)
            {
                list = list.Where(item =>
                    item.Calories <= CaloricIntakeMax
                     );
            }
            if (PriceMin != null)
            {
                list = list.Where(item =>
                    item.Price >= PriceMin
                     );
            }
            if (PriceMax != null)
            {
                list = list.Where(item =>
                    item.Price <= PriceMax
                     );
            }
            foreach (IOrderItem i in list)
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

