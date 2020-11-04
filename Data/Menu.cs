/* Author: Riley Smith
 * Class name: Menu.cs
 * Purpose: Static class used to store instances of all menu items.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.ComponentModel;
using System.Linq;


namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Static method for the entree items.
        /// </summary>
        /// <returns>A list of instances for the entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BriarheartBurger());
            list.Add(new DoubleDraugr());
            list.Add(new GardenOrcOmelette());
            list.Add(new PhillyPoacher());
            list.Add(new SmokehouseSkeleton());
            list.Add(new ThalmorTriple());
            list.Add(new ThugsTBone());
            return list;
        }

        /// <summary>
        /// Static method for the side items.
        /// </summary>
        /// <returns>A list of instances for the sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size))) {
                list.Add(new DragonbornWaffleFries() { Size = size });
                list.Add(new FriedMiraak() { Size = size });
                list.Add(new MadOtarGrits() { Size = size });
                list.Add(new VokunSalad() { Size = size });
            }
            return list;
        }

        /// <summary>
        /// Static method for the drink items.
        /// </summary>
        /// <returns>A list of instances for the drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                list.Add(new AretinoAppleJuice() { Size = size });
                list.Add(new CandlehearthCoffee() { Size = size });
                list.Add(new MarkarthMilk() { Size = size });
                list.Add(new SailorSoda() { Size = size });
                list.Add(new WarriorWater() { Size = size });
            }
            return list;
        }

        /// <summary>
        /// Static method for the all menu items.
        /// </summary>
        /// <returns>A list of instances for all menu items.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Drinks());
            list.AddRange(Entrees());
            list.AddRange(Sides());
            return list;
        }

        /// <summary>
        /// Searches the menu for matching menu items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of menu items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return FullMenu();
            foreach (IOrderItem i in FullMenu())
            {
                if (i is Entree e)
                {
                    string lowerCaseString = i.ToString().ToLower();
                    if (i.ToString() != null && lowerCaseString.Contains(terms.ToLower()))
                    {
                        results.Add(i);
                    }
                }
                else if (i is Side s)
                {
                    string lowerCaseString = s.Name.ToLower();
                    if (s.Name != null && lowerCaseString.Contains(terms.ToLower()))
                    {
                        results.Add(i);
                    }
                }
                else if (i is Drink d)
                {
                    string lowerCaseString = d.Name.ToLower();
                    if (d.Name != null && lowerCaseString.Contains(terms.ToLower()))
                    {
                        results.Add(i);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible item types
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Filters the provided collection of menu items.
        /// </summary>
        /// <param name="list">The collection of menu items to filter.</param>
        /// <param name="itemTypes">The item types to include.</param>
        /// <returns>A collection containing only menu items that match the filter.</returns>
        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> list, IEnumerable<string> itemTypes)
        {
            if (itemTypes == null || itemTypes.Count() == 0) return list;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem i in list)
            {
                if(itemTypes.Contains("Entree"))
                {
                    if (i is Entree e)
                    {
                        results.Add(i);
                    }
                }
                if (itemTypes.Contains("Side"))
                {
                    if (i is Side s)
                    {
                        results.Add(i);
                    }
                }
                if (itemTypes.Contains("Drink"))
                {
                    if (i is Drink d)
                    {
                        results.Add(i);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with caloric intake falling within
        /// the specified range
        /// </summary>
        /// <param name="list">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            if (min == null && max == null) return list;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in list)
                {
                    if (i.Calories <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem i in list)
                {
                    if (i.Calories >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in list)
            {
                if (i.Calories >= min && i.Calories <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu items
        /// to those with prices falling within
        /// the specified range
        /// </summary>
        /// <param name="list">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list, double? min, double? max)
        {
            if (min == null && max == null) return list;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem i in list)
                {
                    if (i.Price <= max) results.Add(i);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem i in list)
                {
                    if (i.Price >= min) results.Add(i);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem i in list)
            {
                if (i.Price >= min && i.Price <= max)
                {
                    results.Add(i);
                }
            }
            return results;
        }
    }
}
